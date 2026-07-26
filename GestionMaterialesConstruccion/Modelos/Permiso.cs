using System.ComponentModel.DataAnnotations;

namespace GestionMaterialesConstruccion.Modelos
{
    public class Permiso
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(150)]
        public string Descripcion { get; set; }

        public List<Rol> Roles { get; set; } = new();

        public override string ToString() => Nombre;
    }
}
