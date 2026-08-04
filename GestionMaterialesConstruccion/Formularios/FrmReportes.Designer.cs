namespace GestionMaterialesConstruccion.Formularios
{
    partial class FrmReportes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Label lblKpiComprasHistorico;
        private System.Windows.Forms.Label lblKpiComprasMes;
        private System.Windows.Forms.Label lblKpiMaterialesComprados;
        private System.Windows.Forms.Label lblKpiProveedores;
        private System.Windows.Forms.Label lblKpiStockTotal;
        private System.Windows.Forms.Label lblKpiStockCritico;
        private System.Windows.Forms.Label lblKpiValorStock;
        private System.Windows.Forms.Label lblReporte;
        private System.Windows.Forms.ComboBox cmbReporte;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Button btnAplicarFiltro;
        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMensaje;

        private void InitializeComponent()
        {
            this.lblKpiComprasHistorico = new System.Windows.Forms.Label();
            this.lblKpiComprasMes = new System.Windows.Forms.Label();
            this.lblKpiMaterialesComprados = new System.Windows.Forms.Label();
            this.lblKpiProveedores = new System.Windows.Forms.Label();
            this.lblKpiStockTotal = new System.Windows.Forms.Label();
            this.lblKpiStockCritico = new System.Windows.Forms.Label();
            this.lblKpiValorStock = new System.Windows.Forms.Label();
            this.lblReporte = new System.Windows.Forms.Label();
            this.cmbReporte = new System.Windows.Forms.ComboBox();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.btnAplicarFiltro = new System.Windows.Forms.Button();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //
            // lblKpiComprasHistorico
            //
            this.lblKpiComprasHistorico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpiComprasHistorico.Location = new System.Drawing.Point(20, 15);
            this.lblKpiComprasHistorico.Size = new System.Drawing.Size(280, 20);
            this.lblKpiComprasHistorico.Text = "Comprado (histórico): $0";
            //
            // lblKpiComprasMes
            //
            this.lblKpiComprasMes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpiComprasMes.Location = new System.Drawing.Point(310, 15);
            this.lblKpiComprasMes.Size = new System.Drawing.Size(280, 20);
            this.lblKpiComprasMes.Text = "Comprado este mes: $0";
            //
            // lblKpiMaterialesComprados
            //
            this.lblKpiMaterialesComprados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpiMaterialesComprados.Location = new System.Drawing.Point(600, 15);
            this.lblKpiMaterialesComprados.Size = new System.Drawing.Size(280, 20);
            this.lblKpiMaterialesComprados.Text = "Materiales distintos comprados: 0";
            //
            // lblKpiProveedores
            //
            this.lblKpiProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpiProveedores.Location = new System.Drawing.Point(20, 42);
            this.lblKpiProveedores.Size = new System.Drawing.Size(280, 20);
            this.lblKpiProveedores.Text = "Proveedores: 0";
            //
            // lblKpiStockTotal
            //
            this.lblKpiStockTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpiStockTotal.Location = new System.Drawing.Point(310, 42);
            this.lblKpiStockTotal.Size = new System.Drawing.Size(280, 20);
            this.lblKpiStockTotal.Text = "Stock total disponible: 0";
            //
            // lblKpiStockCritico
            //
            this.lblKpiStockCritico.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpiStockCritico.ForeColor = System.Drawing.Color.DarkRed;
            this.lblKpiStockCritico.Location = new System.Drawing.Point(600, 42);
            this.lblKpiStockCritico.Size = new System.Drawing.Size(280, 20);
            this.lblKpiStockCritico.Text = "Materiales en stock crítico: 0";
            //
            // lblKpiValorStock
            //
            this.lblKpiValorStock.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKpiValorStock.Location = new System.Drawing.Point(20, 69);
            this.lblKpiValorStock.Size = new System.Drawing.Size(280, 20);
            this.lblKpiValorStock.Text = "Valor total del stock: $0";
            //
            // lblReporte
            //
            this.lblReporte.Location = new System.Drawing.Point(20, 115);
            this.lblReporte.Size = new System.Drawing.Size(70, 23);
            this.lblReporte.Text = "Reporte:";
            //
            // cmbReporte
            //
            this.cmbReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReporte.Location = new System.Drawing.Point(95, 112);
            this.cmbReporte.Size = new System.Drawing.Size(230, 23);
            this.cmbReporte.SelectedIndexChanged += new System.EventHandler(this.cmbReporte_SelectedIndexChanged);
            //
            // lblDesde
            //
            this.lblDesde.Location = new System.Drawing.Point(345, 115);
            this.lblDesde.Size = new System.Drawing.Size(45, 23);
            this.lblDesde.Text = "Desde:";
            //
            // dtpDesde
            //
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDesde.Location = new System.Drawing.Point(390, 112);
            this.dtpDesde.Size = new System.Drawing.Size(110, 23);
            //
            // lblHasta
            //
            this.lblHasta.Location = new System.Drawing.Point(510, 115);
            this.lblHasta.Size = new System.Drawing.Size(40, 23);
            this.lblHasta.Text = "Hasta:";
            //
            // dtpHasta
            //
            this.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHasta.Location = new System.Drawing.Point(550, 112);
            this.dtpHasta.Size = new System.Drawing.Size(110, 23);
            //
            // btnAplicarFiltro
            //
            this.btnAplicarFiltro.Location = new System.Drawing.Point(670, 111);
            this.btnAplicarFiltro.Size = new System.Drawing.Size(110, 25);
            this.btnAplicarFiltro.Text = "Aplicar filtro";
            this.btnAplicarFiltro.UseVisualStyleBackColor = true;
            this.btnAplicarFiltro.Click += new System.EventHandler(this.btnAplicarFiltro_Click);
            //
            // pnlGrafico
            //
            this.pnlGrafico.BackColor = System.Drawing.Color.White;
            this.pnlGrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrafico.Location = new System.Drawing.Point(20, 150);
            this.pnlGrafico.Size = new System.Drawing.Size(540, 340);
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            //
            // lstDatos
            //
            this.lstDatos.Location = new System.Drawing.Point(575, 150);
            this.lstDatos.Size = new System.Drawing.Size(290, 340);
            //
            // btnVolver
            //
            this.btnVolver.Location = new System.Drawing.Point(20, 500);
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.ForeColor = System.Drawing.Color.Gray;
            this.lblMensaje.Location = new System.Drawing.Point(140, 500);
            this.lblMensaje.Size = new System.Drawing.Size(720, 30);
            //
            // FrmReportes
            //
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.lblKpiComprasHistorico);
            this.Controls.Add(this.lblKpiComprasMes);
            this.Controls.Add(this.lblKpiMaterialesComprados);
            this.Controls.Add(this.lblKpiProveedores);
            this.Controls.Add(this.lblKpiStockTotal);
            this.Controls.Add(this.lblKpiStockCritico);
            this.Controls.Add(this.lblKpiValorStock);
            this.Controls.Add(this.lblReporte);
            this.Controls.Add(this.cmbReporte);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.btnAplicarFiltro);
            this.Controls.Add(this.pnlGrafico);
            this.Controls.Add(this.lstDatos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes y Gráficos";
            this.ResumeLayout(false);
        }
    }
}
