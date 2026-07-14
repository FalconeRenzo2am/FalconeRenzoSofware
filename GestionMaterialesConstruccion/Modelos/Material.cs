using System.ComponentModel.DataAnnotations;

namespace GestionMaterialesConstruccion.Modelos
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Codigo { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }

        [Required, MaxLength(30)]
        public string Tipo { get; set; }

        public int Cantidad { get; set; }

        public override string ToString() => $"{Codigo} - {Nombre} (Stock: {Cantidad})";
    }
}
