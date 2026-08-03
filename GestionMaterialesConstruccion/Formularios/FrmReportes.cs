using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// Gestión de Reportes y Gráficos: gráfico de barras (dibujado a mano con GDI+,
    /// sin dependencias externas) junto con el detalle numérico de cada reporte.
    /// </summary>
    public partial class FrmReportes : Form
    {
        private readonly ReporteControladora controladora = new();
        private List<ReporteItem> datosActuales = new();

        public FrmReportes()
        {
            InitializeComponent();
            MostrarReporte("Stock de Materiales", controladora.ObtenerStockPorMaterial());
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            MostrarReporte("Stock de Materiales", controladora.ObtenerStockPorMaterial());
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            MostrarReporte("Total de Compras por Proveedor", controladora.ObtenerTotalComprasPorProveedor());
        }

        private void MostrarReporte(string titulo, List<ReporteItem> datos)
        {
            lblTitulo.Text = titulo;
            datosActuales = datos;

            lstDatos.DataSource = null;
            lstDatos.DataSource = datosActuales;

            lblMensaje.Text = datosActuales.Count == 0 ? "No hay datos para mostrar todavía." : string.Empty;

            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);

            if (datosActuales.Count == 0)
                return;

            const int margenInferior = 50;
            const int margenSuperior = 20;
            const int margenLateral = 10;

            int anchoDisponible = pnlGrafico.Width - margenLateral * 2;
            int altoDisponible = pnlGrafico.Height - margenSuperior - margenInferior;
            int cantidadBarras = datosActuales.Count;
            int anchoBarra = Math.Max(anchoDisponible / cantidadBarras, 1);
            decimal valorMaximo = datosActuales.Max(d => d.Valor);
            if (valorMaximo <= 0) valorMaximo = 1;

            using var pincelBarra = new SolidBrush(Color.SteelBlue);
            using var fuenteTexto = new Font("Segoe UI", 8);
            using var formatoEtiqueta = new StringFormat
            {
                Alignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };

            for (int i = 0; i < cantidadBarras; i++)
            {
                var item = datosActuales[i];
                int alturaBarra = (int)((double)(item.Valor / valorMaximo) * altoDisponible);
                int x = margenLateral + i * anchoBarra;
                int y = margenSuperior + altoDisponible - alturaBarra;
                int anchoReal = Math.Max(anchoBarra - 8, 2);

                g.FillRectangle(pincelBarra, x, y, anchoReal, alturaBarra);
                g.DrawString(item.Valor.ToString("0.##"), fuenteTexto, Brushes.Black, x, Math.Max(y - 14, 0));

                var areaEtiqueta = new RectangleF(x, pnlGrafico.Height - margenInferior + 4, anchoBarra, margenInferior - 6);
                g.DrawString(item.Etiqueta, fuenteTexto, Brushes.Black, areaEtiqueta, formatoEtiqueta);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
