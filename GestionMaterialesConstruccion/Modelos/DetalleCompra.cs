using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionMaterialesConstruccion.Modelos
{
    public class DetalleCompra
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Codigo { get; set; }

        public int CompraId { get; set; }

        [ForeignKey(nameof(CompraId))]
        public Compra Compra { get; set; }

        public int MaterialId { get; set; }

        [ForeignKey(nameof(MaterialId))]
        public Material Material { get; set; }

        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioParcial { get; set; }

        /// <summary>
        /// Cuánto sale cada unidad del material en esta línea, calculado a partir
        /// del precio final (PrecioParcial) que carga el usuario y la cantidad.
        /// </summary>
        [NotMapped]
        public decimal PrecioPorUnidad => Cantidad > 0 ? PrecioParcial / Cantidad : 0;

        public override string ToString() =>
            $"{Codigo} - {Material?.Nombre} x{Cantidad} = {PrecioParcial:C} ({PrecioPorUnidad:C} c/u)";
    }
}
