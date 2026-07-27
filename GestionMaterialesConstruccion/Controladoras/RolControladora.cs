using GestionMaterialesConstruccion.Datos;
using GestionMaterialesConstruccion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// Creación y edición de roles, los permisos (accesos) que otorgan dentro del sistema,
    /// y qué empleados tienen asignado cada rol.
    /// </summary>
    public class RolControladora
    {
        public List<Rol> ObtenerTodos()
        {
            using var contexto = new AppDbContext();
            return contexto.Roles.Include(r => r.Permisos).OrderBy(r => r.Nombre).ToList();
        }

        public List<Permiso> ObtenerPermisosDisponibles()
        {
            using var contexto = new AppDbContext();
            return contexto.Permisos.OrderBy(p => p.Nombre).ToList();
        }

        public void Agregar(Rol rol, List<int> permisoIds, List<int> empleadoIds)
        {
            ValidarDatos(rol);

            using var contexto = new AppDbContext();
            if (contexto.Roles.Any(r => r.Nombre == rol.Nombre))
                throw new InvalidOperationException("Ya existe un rol con ese nombre.");

            rol.Permisos = contexto.Permisos.Where(p => permisoIds.Contains(p.Id)).ToList();
            contexto.Roles.Add(rol);
            contexto.SaveChanges();

            AsignarEmpleados(contexto, rol.Id, empleadoIds);
            contexto.SaveChanges();
        }

        public void Modificar(Rol rol, List<int> permisoIds, List<int> empleadoIds)
        {
            ValidarDatos(rol);

            using var contexto = new AppDbContext();
            var existente = contexto.Roles.Include(r => r.Permisos).FirstOrDefault(r => r.Id == rol.Id);
            if (existente == null)
                throw new InvalidOperationException("El rol seleccionado ya no existe.");

            if (contexto.Roles.Any(r => r.Nombre == rol.Nombre && r.Id != rol.Id))
                throw new InvalidOperationException("Ya existe otro rol con ese nombre.");

            existente.Nombre = rol.Nombre;
            existente.Descripcion = rol.Descripcion;
            existente.Permisos = contexto.Permisos.Where(p => permisoIds.Contains(p.Id)).ToList();

            AsignarEmpleados(contexto, existente.Id, empleadoIds);
            contexto.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var contexto = new AppDbContext();
            var existente = contexto.Roles.Find(id);
            if (existente == null)
                throw new InvalidOperationException("El rol seleccionado ya no existe.");

            if (contexto.Empleados.Any(e => e.RolId == id))
                throw new InvalidOperationException("No se puede eliminar: hay empleados con ese rol asignado.");

            contexto.Roles.Remove(existente);
            contexto.SaveChanges();
        }

        /// <summary>
        /// Los empleados tildados quedan con este rol; los que tenían este rol y se
        /// destildaron quedan sin rol asignado (RolId = null).
        /// </summary>
        private static void AsignarEmpleados(AppDbContext contexto, int rolId, List<int> empleadoIds)
        {
            var empleadosDelRol = contexto.Empleados.Where(e => e.RolId == rolId).ToList();
            foreach (var empleado in empleadosDelRol)
            {
                if (!empleadoIds.Contains(empleado.Id))
                    empleado.RolId = null;
            }

            var empleadosAAsignar = contexto.Empleados.Where(e => empleadoIds.Contains(e.Id)).ToList();
            foreach (var empleado in empleadosAAsignar)
                empleado.RolId = rolId;
        }

        private static void ValidarDatos(Rol rol)
        {
            if (string.IsNullOrWhiteSpace(rol.Nombre))
                throw new ArgumentException("El nombre del rol es obligatorio.");
        }
    }
}
