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

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Panel pnlGrafico;
        private System.Windows.Forms.ListBox lstDatos;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMensaje;

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.pnlGrafico = new System.Windows.Forms.Panel();
            this.lstDatos = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblTitulo
            //
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Size = new System.Drawing.Size(400, 30);
            this.lblTitulo.Text = "Reportes y Gráficos";
            //
            // btnStock
            //
            this.btnStock.Location = new System.Drawing.Point(20, 55);
            this.btnStock.Size = new System.Drawing.Size(210, 30);
            this.btnStock.Text = "Stock de Materiales";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            //
            // btnCompras
            //
            this.btnCompras.Location = new System.Drawing.Point(240, 55);
            this.btnCompras.Size = new System.Drawing.Size(210, 30);
            this.btnCompras.Text = "Compras por Proveedor";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            //
            // pnlGrafico
            //
            this.pnlGrafico.BackColor = System.Drawing.Color.White;
            this.pnlGrafico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrafico.Location = new System.Drawing.Point(20, 95);
            this.pnlGrafico.Size = new System.Drawing.Size(440, 300);
            this.pnlGrafico.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGrafico_Paint);
            //
            // lstDatos
            //
            this.lstDatos.Location = new System.Drawing.Point(480, 95);
            this.lstDatos.Size = new System.Drawing.Size(220, 300);
            //
            // btnVolver
            //
            this.btnVolver.Location = new System.Drawing.Point(20, 405);
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(140, 405);
            this.lblMensaje.Size = new System.Drawing.Size(560, 30);
            //
            // FrmReportes
            //
            this.ClientSize = new System.Drawing.Size(720, 450);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnCompras);
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
