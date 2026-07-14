using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionMaterialesConstruccion.Modelos
{
    public class Compra
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(20)]
        public string Codigo { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        [MaxLength(200)]
        public string Detalle { get; set; }

        public int ProveedorId { get; set; }

        [ForeignKey(nameof(ProveedorId))]
        public Proveedor Proveedor { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioTotal { get; set; }

        public List<DetalleCompra> Detalles { get; set; } = new();

        public override string ToString() => $"{Codigo} - {Fecha:dd/MM/yyyy} - Total: {PrecioTotal:C}";
    }
}
