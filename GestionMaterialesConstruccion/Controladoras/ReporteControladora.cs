using GestionMaterialesConstruccion.Datos;
using GestionMaterialesConstruccion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// Gestión de Reportes y Gráficos: consultas de solo lectura que resumen
    /// información ya cargada en el sistema (stock, compras) para mostrarlas
    /// en tablas y gráficos de barras.
    /// </summary>
    public class ReporteControladora
    {
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
    }
}
