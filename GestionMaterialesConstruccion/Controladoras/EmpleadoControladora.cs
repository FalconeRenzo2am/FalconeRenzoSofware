using GestionMaterialesConstruccion.Datos;
using GestionMaterialesConstruccion.Modelos;
using Microsoft.EntityFrameworkCore;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// R04 - Registrar Empleados / R05 - Iniciar sesión.
    /// </summary>
    public class EmpleadoControladora
    {
        public List<Empleado> ObtenerTodos()
        {
            using var contexto = new AppDbContext();
            return contexto.Empleados.Include(e => e.Rol).OrderBy(e => e.Apellido).ToList();
        }

        public Empleado IniciarSesion(string email, string contrasenia)
        {
            using var contexto = new AppDbContext();
            var empleado = contexto.Empleados
                .Include(e => e.Rol)
                    .ThenInclude(r => r.Permisos)
                .FirstOrDefault(e => e.Email == email && e.Contrasenia == contrasenia);

            if (empleado != null)
                SesionActual.IniciarSesion(empleado);

            return empleado;
        }

        public void Agregar(Empleado empleado)
        {
            ValidarDatos(empleado);

            using var contexto = new AppDbContext();
            if (contexto.Empleados.Any(e => e.Email == empleado.Email))
                throw new InvalidOperationException("Ya existe un empleado registrado con ese email.");

            if (!contexto.Roles.Any(r => r.Id == empleado.RolId))
                throw new InvalidOperationException("Debe seleccionar un rol válido.");

            contexto.Empleados.Add(empleado);
            contexto.SaveChanges();
        }

        public void Modificar(Empleado empleado)
        {
            ValidarDatos(empleado);

            using var contexto = new AppDbContext();
            var existente = contexto.Empleados.Find(empleado.Id);
            if (existente == null)
                throw new InvalidOperationException("El empleado seleccionado ya no existe.");

            if (contexto.Empleados.Any(e => e.Email == empleado.Email && e.Id != empleado.Id))
                throw new InvalidOperationException("Ya existe otro empleado registrado con ese email.");

            if (!contexto.Roles.Any(r => r.Id == empleado.RolId))
                throw new InvalidOperationException("Debe seleccionar un rol válido.");

            existente.Nombre = empleado.Nombre;
            existente.Apellido = empleado.Apellido;
            existente.Dni = empleado.Dni;
            existente.Legajo = empleado.Legajo;
            existente.Email = empleado.Email;
            existente.Contrasenia = empleado.Contrasenia;
            existente.RolId = empleado.RolId;

            contexto.SaveChanges();
        }

        public void Eliminar(int id)
        {
            using var contexto = new AppDbContext();
            var existente = contexto.Empleados.Find(id);
            if (existente == null)
                throw new InvalidOperationException("El empleado seleccionado ya no existe.");

            contexto.Empleados.Remove(existente);
            contexto.SaveChanges();
        }

        private static void ValidarDatos(Empleado empleado)
        {
            if (string.IsNullOrWhiteSpace(empleado.Nombre) ||
                string.IsNullOrWhiteSpace(empleado.Apellido) ||
                string.IsNullOrWhiteSpace(empleado.Dni) ||
                string.IsNullOrWhiteSpace(empleado.Legajo) ||
                string.IsNullOrWhiteSpace(empleado.Email) ||
                string.IsNullOrWhiteSpace(empleado.Contrasenia))
            {
                throw new ArgumentException("Todos los campos son obligatorios.");
            }

            if (empleado.RolId <= 0)
                throw new ArgumentException("Debe seleccionar un rol.");
        }
    }
}
