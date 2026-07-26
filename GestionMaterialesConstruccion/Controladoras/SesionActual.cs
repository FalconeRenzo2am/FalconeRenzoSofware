using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// Mantiene el empleado logueado y expone qué permisos (accesos) le otorga su Rol.
    /// </summary>
    public static class SesionActual
    {
        public static Empleado EmpleadoActual { get; private set; }

        public static void IniciarSesion(Empleado empleado)
        {
            EmpleadoActual = empleado;
        }

        public static void CerrarSesion()
        {
            EmpleadoActual = null;
        }

        public static bool TienePermiso(string nombrePermiso)
        {
            return EmpleadoActual?.Rol?.Permisos.Any(p => p.Nombre == nombrePermiso) ?? false;
        }
    }
}
