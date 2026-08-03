namespace GestionMaterialesConstruccion.Modelos
{
    /// <summary>
    /// Un par etiqueta/valor genérico para alimentar un reporte o gráfico
    /// (por ejemplo: nombre de material + stock, o proveedor + total comprado).
    /// </summary>
    public class ReporteItem
    {
        public string Etiqueta { get; set; }
        public decimal Valor { get; set; }

        public override string ToString() => $"{Etiqueta}: {Valor}";
    }
}
