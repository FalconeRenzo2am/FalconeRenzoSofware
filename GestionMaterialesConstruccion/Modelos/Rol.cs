using System.ComponentModel.DataAnnotations;

namespace GestionMaterialesConstruccion.Modelos
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(150)]
        public string Descripcion { get; set; }

        public List<Permiso> Permisos { get; set; } = new();

        public override string ToString() => Nombre;
    }
}
