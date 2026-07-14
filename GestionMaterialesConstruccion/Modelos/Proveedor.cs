using System.ComponentModel.DataAnnotations;

namespace GestionMaterialesConstruccion.Modelos
{
    public class Proveedor : Persona
    {
        [Required, MaxLength(20)]
        public string Codigo { get; set; }

        [MaxLength(30)]
        public string Telefono { get; set; }

        public TipoProveedor Tipo { get; set; }

        public List<Compra> Compras { get; set; } = new();

        public override string ToString() => $"{Codigo} - {Apellido}, {Nombre} ({Tipo})";
    }
}
