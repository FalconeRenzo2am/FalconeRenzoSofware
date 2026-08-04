using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        public int StockMinimo { get; set; } = 5;

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioUnitario { get; set; }

        [NotMapped]
        public decimal ValorTotal => Cantidad * PrecioUnitario;

        public override string ToString() =>
            $"{Codigo} - {Nombre} (Stock: {Cantidad} x {PrecioUnitario:C} = {ValorTotal:C})";
    }
}
