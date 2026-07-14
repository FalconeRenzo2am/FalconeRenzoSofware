using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Controladoras
{
    /// <summary>
    /// Representa CUD 0007/0011/0016 "Verificar Permisos": mantiene el empleado logueado
    /// y expone si tiene permisos de Administrador para las operaciones de gestión.
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

        public static bool TienePermisoAdministrador()
        {
            return EmpleadoActual != null && EmpleadoActual.Rol == RolEmpleado.Administrador;
        }
    }
}
