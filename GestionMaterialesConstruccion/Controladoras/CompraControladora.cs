using GestionMaterialesConstruccion.Datos;
using GestionMaterialesConstruccion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// R03 - Gestionar Compra (requerimiento "CORE"): CUD 0003/0012/0013/0014.
    /// Cada línea de Detalle de Compra confirmada repone stock del material asociado
    /// (regla de negocio equivalente al concepto "Reponer" del modelo de dominio),
    /// y el precio total de la compra se recalcula como la suma de sus detalles.
    /// </summary>
    public class CompraControladora
    {
        public List<Compra> ObtenerTodas()
        {
            using var contexto = new AppDbContext();
            return contexto.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.Detalles)
                    .ThenInclude(d => d.Material)
                .OrderByDescending(c => c.Fecha)
                .ToList();
        }

        public Compra ObtenerPorId(int id)
        {
            using var contexto = new AppDbContext();
            return contexto.Compras
                .Include(c => c.Proveedor)
                .Include(c => c.Detalles)
                    .ThenInclude(d => d.Material)
                .FirstOrDefault(c => c.Id == id);
        }

        public void Agregar(Compra compra)
        {
            ValidarDatos(compra);

            using var contexto = new AppDbContext();
            if (contexto.Compras.Any(c => c.Codigo == compra.Codigo))
                throw new InvalidOperationException("Ya existe una compra con ese código.");

            if (!contexto.Proveedores.Any(p => p.Id == compra.ProveedorId))
                throw new InvalidOperationException("Debe seleccionar un proveedor válido.");

            compra.PrecioTotal = 0;
            contexto.Compras.Add(compra);
            contexto.SaveChanges();
        }

        public void Modificar(Compra compra)
        {
            ValidarDatos(compra);

            using var contexto = new AppDbContext();
            var existente = contexto.Compras.Find(compra.Id);
            if (existente == null)
                throw new InvalidOperationException("La compra seleccionada ya no existe.");

            if (contexto.Compras.Any(c => c.Codigo == compra.Codigo && c.Id != compra.Id))
                throw new InvalidOperationException("Ya existe otra compra con ese código.");

            existente.Codigo = compra.Codigo;
            existente.Fecha = compra.Fecha;
            existente.Detalle = compra.Detalle;
            existente.ProveedorId = compra.ProveedorId;

            contexto.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var contexto = new AppDbContext();
            var existente = contexto.Compras
                .Include(c => c.Detalles)
                .FirstOrDefault(c => c.Id == id);

            if (existente == null)
                throw new InvalidOperationException("La compra seleccionada ya no existe.");

            // Revertir el stock repuesto por cada línea de detalle antes de eliminar la compra.
            foreach (var detalle in existente.Detalles)
            {
                var material = contexto.Materiales.Find(detalle.MaterialId);
                if (material != null)
                    material.Cantidad -= detalle.Cantidad;
            }

            contexto.Compras.Remove(existente);
            contexto.SaveChanges();
        }

        public void AgregarDetalle(int compraId, DetalleCompra detalle)
        {
            ValidarDetalle(detalle);

            using var contexto = new AppDbContext();
            var compra = contexto.Compras.Find(compraId);
            if (compra == null)
                throw new InvalidOperationException("La compra seleccionada ya no existe.");

            var material = contexto.Materiales.Find(detalle.MaterialId);
            if (material == null)
                throw new InvalidOperationException("Debe seleccionar un material válido.");

            if (contexto.DetallesCompra.Any(d => d.Codigo == detalle.Codigo))
                throw new InvalidOperationException("Ya existe un detalle con ese código.");

            detalle.CompraId = compraId;
            contexto.DetallesCompra.Add(detalle);

            // Regla de negocio: la compra a un proveedor repone stock del material.
            material.Cantidad += detalle.Cantidad;

            contexto.SaveChanges();
            RecalcularTotal(contexto, compraId);
        }

        public void ModificarDetalle(DetalleCompra detalle)
        {
            ValidarDetalle(detalle);

            using var contexto = new AppDbContext();
            var existente = contexto.DetallesCompra.Find(detalle.Id);
            if (existente == null)
                throw new InvalidOperationException("El detalle seleccionado ya no existe.");

            if (contexto.DetallesCompra.Any(d => d.Codigo == detalle.Codigo && d.Id != detalle.Id))
                throw new InvalidOperationException("Ya existe otro detalle con ese código.");

            var materialAnterior = contexto.Materiales.Find(existente.MaterialId);
            if (materialAnterior != null)
                materialAnterior.Cantidad -= existente.Cantidad;

            var materialNuevo = contexto.Materiales.Find(detalle.MaterialId);
            if (materialNuevo == null)
                throw new InvalidOperationException("Debe seleccionar un material válido.");

            materialNuevo.Cantidad += detalle.Cantidad;

            existente.Codigo = detalle.Codigo;
            existente.MaterialId = detalle.MaterialId;
            existente.Cantidad = detalle.Cantidad;
            existente.PrecioParcial = detalle.PrecioParcial;

            contexto.SaveChanges();
            RecalcularTotal(contexto, existente.CompraId);
        }

        public void EliminarDetalle(int detalleId)
        {
            using var contexto = new AppDbContext();
            var existente = contexto.DetallesCompra.Find(detalleId);
            if (existente == null)
                throw new InvalidOperationException("El detalle seleccionado ya no existe.");

            var material = contexto.Materiales.Find(existente.MaterialId);
            if (material != null)
                material.Cantidad -= existente.Cantidad;

            int compraId = existente.CompraId;
            contexto.DetallesCompra.Remove(existente);
            contexto.SaveChanges();
            RecalcularTotal(contexto, compraId);
        }

        private static void RecalcularTotal(AppDbContext contexto, int compraId)
        {
            var compra = contexto.Compras.Find(compraId);
            if (compra == null) return;

            compra.PrecioTotal = contexto.DetallesCompra
                .Where(d => d.CompraId == compraId)
                .Sum(d => d.PrecioParcial);

            contexto.SaveChanges();
        }

        private static void ValidarDatos(Compra compra)
        {
            if (string.IsNullOrWhiteSpace(compra.Codigo))
                throw new ArgumentException("El código de la compra es obligatorio.");

            if (compra.ProveedorId <= 0)
                throw new ArgumentException("Debe seleccionar un proveedor.");
        }

        private static void ValidarDetalle(DetalleCompra detalle)
        {
            if (string.IsNullOrWhiteSpace(detalle.Codigo))
                throw new ArgumentException("El código del detalle es obligatorio.");

            if (detalle.MaterialId <= 0)
                throw new ArgumentException("Debe seleccionar un material.");

            if (detalle.Cantidad <= 0)
                throw new ArgumentException("La cantidad debe ser mayor a cero.");

            if (detalle.PrecioParcial < 0)
                throw new ArgumentException("El precio parcial no puede ser negativo.");
        }
    }
}
