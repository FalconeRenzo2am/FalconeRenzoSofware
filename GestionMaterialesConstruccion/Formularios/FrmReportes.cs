using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// Gestión de Reportes y Gráficos (adaptado a lo que existe en el sistema:
    /// compras, stock y proveedores; no hay ventas ni clientes). Los gráficos se
    /// dibujan a mano con GDI+, sin dependencias externas.
    /// </summary>
    public partial class FrmReportes : Form
    {
        private enum TipoReporte
        {
            StockPorMaterial,
            ComprasPorProveedor,
            ComprasPorMes,
            MaterialesMasComprados,
            ComprasPorCategoria,
            EstadoStock,
            EvolucionStock,
            MaterialesSinMovimiento
        }

        private enum TipoGrafico
        {
            BarrasVerticales,
            BarrasHorizontales,
            Torta,
            Lineas,
            Ninguno
        }

        private class OpcionReporte
        {
            public string Texto { get; set; }
            public TipoReporte Tipo { get; set; }
            public override string ToString() => Texto;
        }

        private static readonly Color[] PaletaColores =
        {
            Color.SteelBlue, Color.IndianRed, Color.SeaGreen, Color.Goldenrod,
            Color.MediumPurple, Color.DarkOrange, Color.Teal, Color.SlateGray
        };

        private readonly ReporteControladora controladora = new();
        private List<ReporteItem> datosActuales = new();
        private TipoGrafico tipoGraficoActual = TipoGrafico.BarrasVerticales;
        private bool esGraficoEstadoStock = false;

        public FrmReportes()
        {
            InitializeComponent();

            dtpDesde.Value = DateTime.Now.AddMonths(-6);
            dtpHasta.Value = DateTime.Now;

            cmbReporte.Items.Add(new OpcionReporte { Texto = "Stock por Material", Tipo = TipoReporte.StockPorMaterial });
            cmbReporte.Items.Add(new OpcionReporte { Texto = "Compras por Proveedor", Tipo = TipoReporte.ComprasPorProveedor });
            cmbReporte.Items.Add(new OpcionReporte { Texto = "Compras por Mes", Tipo = TipoReporte.ComprasPorMes });
            cmbReporte.Items.Add(new OpcionReporte { Texto = "Materiales más Comprados", Tipo = TipoReporte.MaterialesMasComprados });
            cmbReporte.Items.Add(new OpcionReporte { Texto = "Compras por Categoría", Tipo = TipoReporte.ComprasPorCategoria });
            cmbReporte.Items.Add(new OpcionReporte { Texto = "Estado del Stock", Tipo = TipoReporte.EstadoStock });
            cmbReporte.Items.Add(new OpcionReporte { Texto = "Evolución del Stock", Tipo = TipoReporte.EvolucionStock });
            cmbReporte.Items.Add(new OpcionReporte { Texto = "Materiales sin Movimiento", Tipo = TipoReporte.MaterialesSinMovimiento });

            ActualizarIndicadores();
            cmbReporte.SelectedIndex = 0;
        }

        private void ActualizarIndicadores()
        {
            var kpis = controladora.ObtenerIndicadores();
            lblKpiComprasHistorico.Text = $"Comprado (histórico): {kpis.TotalCompradoHistorico:C}";
            lblKpiComprasMes.Text = $"Comprado este mes: {kpis.TotalCompradoMesActual:C}";
            lblKpiMaterialesComprados.Text = $"Materiales distintos comprados: {kpis.CantidadMaterialesDistintosComprados}";
            lblKpiProveedores.Text = $"Proveedores: {kpis.CantidadProveedores}";
            lblKpiStockTotal.Text = $"Stock total disponible: {kpis.StockTotalDisponible}";
            lblKpiStockCritico.Text = $"Materiales en stock crítico: {kpis.MaterialesConStockCritico}";
            lblKpiValorStock.Text = $"Valor total del stock: {kpis.ValorTotalStock:C}";
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarReporteActual();
        }

        private void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value.Date > dtpHasta.Value.Date)
            {
                lblMensaje.Text = "La fecha 'Desde' no puede ser posterior a 'Hasta'.";
                return;
            }

            ActualizarIndicadores();
            CargarReporteActual();
        }

        private void CargarReporteActual()
        {
            if (cmbReporte.SelectedItem is not OpcionReporte opcion) return;

            lblMensaje.Text = string.Empty;
            var desde = dtpDesde.Value.Date;
            var hasta = dtpHasta.Value.Date;

            switch (opcion.Tipo)
            {
                case TipoReporte.StockPorMaterial:
                    MostrarDatos(controladora.ObtenerStockPorMaterial(), TipoGrafico.BarrasVerticales);
                    break;
                case TipoReporte.ComprasPorProveedor:
                    MostrarDatos(controladora.ObtenerTotalComprasPorProveedor(), TipoGrafico.BarrasVerticales);
                    break;
                case TipoReporte.ComprasPorMes:
                    MostrarDatos(controladora.ObtenerComprasPorMes(desde, hasta), TipoGrafico.BarrasVerticales);
                    break;
                case TipoReporte.MaterialesMasComprados:
                    MostrarDatos(controladora.ObtenerMaterialesMasComprados(), TipoGrafico.BarrasHorizontales);
                    break;
                case TipoReporte.ComprasPorCategoria:
                    MostrarDatos(controladora.ObtenerComprasPorCategoria(), TipoGrafico.Torta);
                    break;
                case TipoReporte.EstadoStock:
                    MostrarDatos(controladora.ObtenerEstadoStock(), TipoGrafico.Torta, esEstadoStock: true);
                    break;
                case TipoReporte.EvolucionStock:
                    MostrarDatos(controladora.ObtenerEvolucionStock(desde, hasta), TipoGrafico.Lineas);
                    break;
                case TipoReporte.MaterialesSinMovimiento:
                    MostrarMaterialesSinMovimiento();
                    break;
            }
        }

        private void MostrarDatos(List<ReporteItem> datos, TipoGrafico tipoGrafico, bool esEstadoStock = false)
        {
            datosActuales = datos;
            tipoGraficoActual = tipoGrafico;
            esGraficoEstadoStock = esEstadoStock;

            lstDatos.DataSource = null;
            lstDatos.DataSource = datosActuales;

            if (datosActuales.Count == 0)
                lblMensaje.Text = "No hay datos para mostrar en este reporte todavía.";

            pnlGrafico.Invalidate();
        }

        private void MostrarMaterialesSinMovimiento()
        {
            datosActuales = new List<ReporteItem>();
            tipoGraficoActual = TipoGrafico.Ninguno;
            esGraficoEstadoStock = false;

            var materiales = controladora.ObtenerMaterialesSinMovimiento();
            lstDatos.DataSource = null;
            lstDatos.DataSource = materiales
                .Select(m => new ReporteItem { Etiqueta = $"{m.Codigo} - {m.Nombre}", Valor = m.Cantidad })
                .ToList();

            lblMensaje.Text = materiales.Count == 0
                ? "Todos los materiales tienen compras registradas."
                : "Materiales sin ninguna compra registrada (código - nombre, stock actual).";

            pnlGrafico.Invalidate();
        }

        private void pnlGrafico_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.Clear(Color.White);

            if (tipoGraficoActual == TipoGrafico.Ninguno)
            {
                using var fuenteAviso = new Font("Segoe UI", 9);
                g.DrawString("Este reporte se ve en la lista de la derecha (no aplica gráfico).",
                    fuenteAviso, Brushes.Gray, 10, 10);
                return;
            }

            if (datosActuales.Count == 0)
                return;

            switch (tipoGraficoActual)
            {
                case TipoGrafico.BarrasVerticales:
                    DibujarBarrasVerticales(g);
                    break;
                case TipoGrafico.BarrasHorizontales:
                    DibujarBarrasHorizontales(g);
                    break;
                case TipoGrafico.Torta:
                    DibujarTorta(g);
                    break;
                case TipoGrafico.Lineas:
                    DibujarLineas(g);
                    break;
            }
        }

        private void DibujarBarrasVerticales(Graphics g)
        {
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

        private void DibujarBarrasHorizontales(Graphics g)
        {
            const int margenIzquierdo = 140;
            const int margenDerecho = 60;
            const int margenSuperior = 10;
            const int margenInferior = 10;

            int anchoDisponible = pnlGrafico.Width - margenIzquierdo - margenDerecho;
            int altoDisponible = pnlGrafico.Height - margenSuperior - margenInferior;
            int cantidadBarras = datosActuales.Count;
            int altoBarra = Math.Max(altoDisponible / cantidadBarras, 1);
            decimal valorMaximo = datosActuales.Max(d => d.Valor);
            if (valorMaximo <= 0) valorMaximo = 1;

            using var pincelBarra = new SolidBrush(Color.SeaGreen);
            using var fuenteTexto = new Font("Segoe UI", 8);
            using var formatoEtiqueta = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };

            for (int i = 0; i < cantidadBarras; i++)
            {
                var item = datosActuales[i];
                int anchoBarra = (int)((double)(item.Valor / valorMaximo) * anchoDisponible);
                int y = margenSuperior + i * altoBarra;
                int altoReal = Math.Max(altoBarra - 6, 2);

                var areaEtiqueta = new RectangleF(0, y, margenIzquierdo - 10, altoReal);
                g.DrawString(item.Etiqueta, fuenteTexto, Brushes.Black, areaEtiqueta, formatoEtiqueta);

                g.FillRectangle(pincelBarra, margenIzquierdo, y, Math.Max(anchoBarra, 1), altoReal);
                g.DrawString(item.Valor.ToString("0.##"), fuenteTexto, Brushes.Black, margenIzquierdo + anchoBarra + 4, y + altoReal / 2f - 7);
            }
        }

        private void DibujarTorta(Graphics g)
        {
            const int margen = 20;
            const int anchoLeyenda = 160;

            int diametro = Math.Min(pnlGrafico.Width - anchoLeyenda - margen * 2, pnlGrafico.Height - margen * 2);
            if (diametro <= 0) diametro = 10;

            var rectanguloTorta = new Rectangle(margen, margen, diametro, diametro);
            decimal total = datosActuales.Sum(d => d.Valor);
            if (total <= 0) total = 1;

            using var fuenteTexto = new Font("Segoe UI", 8);
            float anguloInicial = 0f;
            int y = margen;

            for (int i = 0; i < datosActuales.Count; i++)
            {
                var item = datosActuales[i];
                float angulo = (float)(item.Valor / total) * 360f;
                var color = esGraficoEstadoStock
                    ? ColorEstadoStock(item.Etiqueta)
                    : PaletaColores[i % PaletaColores.Length];

                using (var pincel = new SolidBrush(color))
                {
                    if (angulo > 0)
                        g.FillPie(pincel, rectanguloTorta, anguloInicial, Math.Max(angulo, 0.1f));
                }
                anguloInicial += angulo;

                using var pincelLeyenda = new SolidBrush(color);
                g.FillRectangle(pincelLeyenda, margen * 2 + diametro, y, 12, 12);
                decimal porcentaje = item.Valor / total * 100;
                g.DrawString($"{item.Etiqueta} ({porcentaje:0.#}%)", fuenteTexto, Brushes.Black, margen * 2 + diametro + 18, y - 2);
                y += 20;
            }
        }

        private static Color ColorEstadoStock(string etiqueta) => etiqueta switch
        {
            "Sin stock" => Color.Red,
            "Bajo" => Color.Gold,
            "Normal" => Color.Green,
            _ => Color.Gray
        };

        private void DibujarLineas(Graphics g)
        {
            const int margenInferior = 50;
            const int margenSuperior = 20;
            const int margenLateral = 40;

            int anchoDisponible = pnlGrafico.Width - margenLateral * 2;
            int altoDisponible = pnlGrafico.Height - margenSuperior - margenInferior;
            int cantidadPuntos = datosActuales.Count;

            using var lapiz = new Pen(Color.SteelBlue, 2);
            using var pincelPunto = new SolidBrush(Color.SteelBlue);
            using var fuenteTexto = new Font("Segoe UI", 7);
            using var formatoEtiqueta = new StringFormat
            {
                Alignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };

            decimal valorMaximo = datosActuales.Max(d => d.Valor);
            decimal valorMinimo = Math.Min(datosActuales.Min(d => d.Valor), 0);
            if (valorMaximo == valorMinimo) valorMaximo = valorMinimo + 1;

            if (cantidadPuntos == 1)
            {
                int xUnico = margenLateral + anchoDisponible / 2;
                int yUnico = margenSuperior + altoDisponible / 2;
                g.FillEllipse(pincelPunto, xUnico - 3, yUnico - 3, 6, 6);
                return;
            }

            var puntos = new PointF[cantidadPuntos];
            for (int i = 0; i < cantidadPuntos; i++)
            {
                float x = margenLateral + i * (anchoDisponible / (float)(cantidadPuntos - 1));
                float proporcion = (float)((datosActuales[i].Valor - valorMinimo) / (valorMaximo - valorMinimo));
                float y = margenSuperior + altoDisponible - proporcion * altoDisponible;
                puntos[i] = new PointF(x, y);
            }

            g.DrawLines(lapiz, puntos);

            for (int i = 0; i < cantidadPuntos; i++)
            {
                g.FillEllipse(pincelPunto, puntos[i].X - 3, puntos[i].Y - 3, 6, 6);

                if (i % Math.Max(cantidadPuntos / 10, 1) == 0 || i == cantidadPuntos - 1)
                {
                    var areaEtiqueta = new RectangleF(puntos[i].X - 30, pnlGrafico.Height - margenInferior + 4, 60, margenInferior - 6);
                    g.DrawString(datosActuales[i].Etiqueta, fuenteTexto, Brushes.Black, areaEtiqueta, formatoEtiqueta);
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
