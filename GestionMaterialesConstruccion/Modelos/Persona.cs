using System.ComponentModel.DataAnnotations;

namespace GestionMaterialesConstruccion.Modelos
{
    public abstract class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(50)]
        public string Apellido { get; set; }

        [Required, MaxLength(20)]
        public string Dni { get; set; }
    }
}
