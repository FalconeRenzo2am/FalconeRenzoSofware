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

        public override string ToString() => $"{Codigo} - {Material?.Nombre} x{Cantidad} = {PrecioParcial:C}";
    }
}
