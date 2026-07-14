using System.ComponentModel.DataAnnotations;

namespace GestionMaterialesConstruccion.Modelos
{
    public class Empleado : Persona
    {
        [Required, MaxLength(20)]
        public string Legajo { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MaxLength(100)]
        public string Contrasenia { get; set; }

        public RolEmpleado Rol { get; set; } = RolEmpleado.Empleado;

        public override string ToString() => $"{Legajo} - {Apellido}, {Nombre} ({Rol})";
    }
}
