namespace GestionMaterialesConstruccion.Modelos
{
    /// <summary>
    /// Los indicadores (KPIs) que se muestran como tarjetas resumen al entrar
    /// a "Reportes y Gráficos".
    /// </summary>
    public class IndicadoresDashboard
    {
        public decimal TotalCompradoHistorico { get; set; }
        public decimal TotalCompradoMesActual { get; set; }
        public int CantidadMaterialesDistintosComprados { get; set; }
        public int CantidadProveedores { get; set; }
        public int StockTotalDisponible { get; set; }
        public int MaterialesConStockCritico { get; set; }
        public decimal ValorTotalStock { get; set; }
    }
}
