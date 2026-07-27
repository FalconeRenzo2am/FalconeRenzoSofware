using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int? RolId { get; set; }

        [ForeignKey(nameof(RolId))]
        public Rol Rol { get; set; }

        public override string ToString() => $"{Legajo} - {Apellido}, {Nombre} ({Rol?.Nombre ?? "Rol no asignado"})";
    }
}
