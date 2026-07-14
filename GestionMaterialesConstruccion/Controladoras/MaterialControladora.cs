using GestionMaterialesConstruccion.Datos;
using GestionMaterialesConstruccion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// R02 - Gestionar Materiales (CUD 0002/0008/0009/0010).
    /// </summary>
    public class MaterialControladora
    {
        public List<Material> ObtenerTodos()
        {
            using var contexto = new AppDbContext();
            return contexto.Materiales.OrderBy(m => m.Nombre).ToList();
        }

        public void Agregar(Material material)
        {
            ValidarDatos(material);

            using var contexto = new AppDbContext();
            if (contexto.Materiales.Any(m => m.Codigo == material.Codigo))
                throw new InvalidOperationException("Ya existe un material con ese código.");

            contexto.Materiales.Add(material);
            contexto.SaveChanges();
        }

        public void Modificar(Material material)
        {
            ValidarDatos(material);

            using var contexto = new AppDbContext();
            var existente = contexto.Materiales.Find(material.Id);
            if (existente == null)
                throw new InvalidOperationException("El material seleccionado ya no existe.");

            if (contexto.Materiales.Any(m => m.Codigo == material.Codigo && m.Id != material.Id))
                throw new InvalidOperationException("Ya existe otro material con ese código.");

            existente.Nombre = material.Nombre;
            existente.Codigo = material.Codigo;
            existente.Tipo = material.Tipo;
            existente.Cantidad = material.Cantidad;

            contexto.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var contexto = new AppDbContext();
            var existente = contexto.Materiales.Find(id);
            if (existente == null)
                throw new InvalidOperationException("El material seleccionado ya no existe.");

            if (contexto.DetallesCompra.Any(d => d.MaterialId == id))
                throw new InvalidOperationException("No se puede eliminar: el material tiene compras registradas.");

            contexto.Materiales.Remove(existente);
            contexto.SaveChanges();
        }

        private static void ValidarDatos(Material material)
        {
            if (string.IsNullOrWhiteSpace(material.Nombre) ||
                string.IsNullOrWhiteSpace(material.Codigo) ||
                string.IsNullOrWhiteSpace(material.Tipo))
            {
                throw new ArgumentException("Nombre, código y tipo son obligatorios.");
            }

            if (material.Cantidad < 0)
                throw new ArgumentException("La cantidad no puede ser negativa.");
        }
    }
}
