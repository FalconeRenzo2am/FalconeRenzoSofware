using GestionMaterialesConstruccion.Datos;
using GestionMaterialesConstruccion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// R01 - Gestionar Proveedores (CUD 0001/0004/0005/0006).
    /// </summary>
    public class ProveedorControladora
    {
        public List<Proveedor> ObtenerTodos()
        {
            using var contexto = new AppDbContext();
            return contexto.Proveedores.OrderBy(p => p.Apellido).ToList();
        }

        public void Agregar(Proveedor proveedor)
        {
            ValidarDatos(proveedor);

            using var contexto = new AppDbContext();
            if (contexto.Proveedores.Any(p => p.Codigo == proveedor.Codigo))
                throw new InvalidOperationException("Ya existe un proveedor con ese código.");

            contexto.Proveedores.Add(proveedor);
            contexto.SaveChanges();
        }

        public void Modificar(Proveedor proveedor)
        {
            ValidarDatos(proveedor);

            using var contexto = new AppDbContext();
            var existente = contexto.Proveedores.Find(proveedor.Id);
            if (existente == null)
                throw new InvalidOperationException("El proveedor seleccionado ya no existe.");

            if (contexto.Proveedores.Any(p => p.Codigo == proveedor.Codigo && p.Id != proveedor.Id))
                throw new InvalidOperationException("Ya existe otro proveedor con ese código.");

            existente.Nombre = proveedor.Nombre;
            existente.Apellido = proveedor.Apellido;
            existente.Dni = proveedor.Dni;
            existente.Codigo = proveedor.Codigo;
            existente.Telefono = proveedor.Telefono;
            existente.Tipo = proveedor.Tipo;

            contexto.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var contexto = new AppDbContext();
            var existente = contexto.Proveedores.Find(id);
            if (existente == null)
                throw new InvalidOperationException("El proveedor seleccionado ya no existe.");

            if (contexto.Compras.Any(c => c.ProveedorId == id))
                throw new InvalidOperationException("No se puede eliminar: el proveedor tiene compras registradas.");

            contexto.Proveedores.Remove(existente);
            contexto.SaveChanges();
        }

        private static void ValidarDatos(Proveedor proveedor)
        {
            if (string.IsNullOrWhiteSpace(proveedor.Nombre) ||
                string.IsNullOrWhiteSpace(proveedor.Apellido) ||
                string.IsNullOrWhiteSpace(proveedor.Dni) ||
                string.IsNullOrWhiteSpace(proveedor.Codigo))
            {
                throw new ArgumentException("Nombre, apellido, DNI y código son obligatorios.");
            }
        }
    }
}
