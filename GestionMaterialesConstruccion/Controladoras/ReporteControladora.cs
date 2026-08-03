using GestionMaterialesConstruccion.Datos;
using GestionMaterialesConstruccion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// Gestión de Reportes y Gráficos: consultas de solo lectura que resumen
    /// información ya cargada en el sistema (stock, compras, proveedores) para
    /// mostrarlas en indicadores (KPIs), tablas y gráficos. No hay módulo de
    /// ventas/clientes en el sistema, así que todo se basa en Compras y Stock.
    /// </summary>
    public class ReporteControladora
    {
        private static readonly string[] MesesAbrev =
        {
            "Ene", "Feb", "Mar", "Abr", "May", "Jun", "Jul", "Ago", "Sep", "Oct", "Nov", "Dic"
        };

        public IndicadoresDashboard ObtenerIndicadores()
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();
            var ahora = DateTime.Now;
            var inicioMes = new DateTime(ahora.Year, ahora.Month, 1);

            return new IndicadoresDashboard
            {
                TotalCompradoHistorico = contexto.Compras.Sum(c => (decimal?)c.PrecioTotal) ?? 0,
                TotalCompradoMesActual = contexto.Compras
                    .Where(c => c.Fecha >= inicioMes)
                    .Sum(c => (decimal?)c.PrecioTotal) ?? 0,
                CantidadMaterialesDistintosComprados = contexto.DetallesCompra
                    .Select(d => d.MaterialId)
                    .Distinct()
                    .Count(),
                CantidadProveedores = contexto.Proveedores.Count(),
                StockTotalDisponible = contexto.Materiales.Sum(m => (int?)m.Cantidad) ?? 0,
                MaterialesConStockCritico = contexto.Materiales.Count(m => m.Cantidad <= m.StockMinimo)
            };
        }

        public List<ReporteItem> ObtenerStockPorMaterial()
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();
            return contexto.Materiales
                .OrderByDescending(m => m.Cantidad)
                .Select(m => new ReporteItem { Etiqueta = m.Nombre, Valor = m.Cantidad })
                .ToList();
        }

        public List<ReporteItem> ObtenerTotalComprasPorProveedor()
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();
            return contexto.Compras
                .GroupBy(c => new { c.Proveedor.Id, c.Proveedor.Nombre, c.Proveedor.Apellido })
                .Select(g => new ReporteItem
                {
                    Etiqueta = g.Key.Nombre + " " + g.Key.Apellido,
                    Valor = g.Sum(c => c.PrecioTotal)
                })
                .OrderByDescending(r => r.Valor)
                .ToList();
        }

        public List<ReporteItem> ObtenerComprasPorMes(DateTime desde, DateTime hasta)
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();
            return contexto.Compras
                .Where(c => c.Fecha >= desde && c.Fecha <= hasta)
                .GroupBy(c => new { c.Fecha.Year, c.Fecha.Month })
                .Select(g => new { g.Key.Year, g.Key.Month, Total = g.Sum(c => c.PrecioTotal) })
                .OrderBy(g => g.Year).ThenBy(g => g.Month)
                .ToList()
                .Select(g => new ReporteItem
                {
                    Etiqueta = $"{MesesAbrev[g.Month - 1]} {g.Year}",
                    Valor = g.Total
                })
                .ToList();
        }

        public List<ReporteItem> ObtenerMaterialesMasComprados(int top = 8)
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();
            return contexto.DetallesCompra
                .GroupBy(d => new { d.Material.Id, d.Material.Nombre })
                .Select(g => new ReporteItem { Etiqueta = g.Key.Nombre, Valor = g.Sum(d => d.Cantidad) })
                .OrderByDescending(r => r.Valor)
                .Take(top)
                .ToList();
        }

        public List<ReporteItem> ObtenerComprasPorCategoria()
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();
            return contexto.DetallesCompra
                .GroupBy(d => d.Material.Tipo)
                .Select(g => new ReporteItem { Etiqueta = g.Key, Valor = g.Sum(d => d.PrecioParcial) })
                .OrderByDescending(r => r.Valor)
                .ToList();
        }

        public List<ReporteItem> ObtenerEstadoStock()
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();
            var materiales = contexto.Materiales.ToList();

            int sinStock = materiales.Count(m => m.Cantidad <= 0);
            int stockBajo = materiales.Count(m => m.Cantidad > 0 && m.Cantidad <= m.StockMinimo);
            int stockNormal = materiales.Count(m => m.Cantidad > m.StockMinimo);

            return new List<ReporteItem>
            {
                new() { Etiqueta = "Normal", Valor = stockNormal },
                new() { Etiqueta = "Bajo", Valor = stockBajo },
                new() { Etiqueta = "Sin stock", Valor = sinStock }
            };
        }

        public List<ReporteItem> ObtenerEvolucionStock(DateTime desde, DateTime hasta)
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();

            // Como el stock solo crece al confirmar compras (no hay ventas), la evolución
            // es la suma acumulada de las cantidades compradas a lo largo del tiempo.
            decimal stockInicial = contexto.Compras
                .Where(c => c.Fecha < desde)
                .SelectMany(c => c.Detalles)
                .Sum(d => (int?)d.Cantidad) ?? 0;

            var comprasEnRango = contexto.Compras
                .Include(c => c.Detalles)
                .Where(c => c.Fecha >= desde && c.Fecha <= hasta)
                .OrderBy(c => c.Fecha)
                .ToList();

            var resultado = new List<ReporteItem>();
            decimal acumulado = stockInicial;

            foreach (var grupo in comprasEnRango.GroupBy(c => c.Fecha.Date).OrderBy(g => g.Key))
            {
                acumulado += grupo.SelectMany(c => c.Detalles).Sum(d => d.Cantidad);
                resultado.Add(new ReporteItem { Etiqueta = grupo.Key.ToString("dd/MM"), Valor = acumulado });
            }

            return resultado;
        }

        public List<Material> ObtenerMaterialesSinMovimiento()
        {
            using var contexto = ConexionBD.Instancia.CrearContexto();
            return contexto.Materiales
                .Where(m => !contexto.DetallesCompra.Any(d => d.MaterialId == m.Id))
                .OrderBy(m => m.Nombre)
                .ToList();
        }
    }
}
