namespace GestionMaterialesConstruccion.Formularios
{
    partial class FrmMateriales
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

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.NumericUpDown numStockMinimo;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.NumericUpDown numPrecioUnitario;
        private System.Windows.Forms.Label lblValorTotalTitulo;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.ListBox lstMateriales;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMensaje;

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.numStockMinimo = new System.Windows.Forms.NumericUpDown();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.numPrecioUnitario = new System.Windows.Forms.NumericUpDown();
            this.lblValorTotalTitulo = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lstMateriales = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).BeginInit();
            this.SuspendLayout();
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //
            // lblNombre
            //
            this.lblNombre.Location = new System.Drawing.Point(20, 20);
            this.lblNombre.Size = new System.Drawing.Size(90, 23);
            this.lblNombre.Text = "Nombre";
            //
            // txtNombre
            //
            this.txtNombre.Location = new System.Drawing.Point(120, 17);
            this.txtNombre.Size = new System.Drawing.Size(200, 23);
            //
            // lblCodigo
            //
            this.lblCodigo.Location = new System.Drawing.Point(20, 55);
            this.lblCodigo.Size = new System.Drawing.Size(90, 23);
            this.lblCodigo.Text = "Codigo";
            //
            // txtCodigo
            //
            this.txtCodigo.Location = new System.Drawing.Point(120, 52);
            this.txtCodigo.Size = new System.Drawing.Size(200, 23);
            //
            // lblCantidad
            //
            this.lblCantidad.Location = new System.Drawing.Point(20, 90);
            this.lblCantidad.Size = new System.Drawing.Size(100, 23);
            this.lblCantidad.Text = "Stock actual";
            //
            // numCantidad
            //
            this.numCantidad.Location = new System.Drawing.Point(120, 87);
            this.numCantidad.Size = new System.Drawing.Size(200, 23);
            this.numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numCantidad.Enabled = false;
            //
            // lblTipo
            //
            this.lblTipo.Location = new System.Drawing.Point(20, 125);
            this.lblTipo.Size = new System.Drawing.Size(90, 23);
            this.lblTipo.Text = "Tipo";
            //
            // txtTipo
            //
            this.txtTipo.Location = new System.Drawing.Point(120, 122);
            this.txtTipo.Size = new System.Drawing.Size(200, 23);
            //
            // lblStockMinimo
            //
            this.lblStockMinimo.Location = new System.Drawing.Point(20, 160);
            this.lblStockMinimo.Size = new System.Drawing.Size(100, 23);
            this.lblStockMinimo.Text = "Stock mínimo";
            //
            // numStockMinimo
            //
            this.numStockMinimo.Location = new System.Drawing.Point(120, 157);
            this.numStockMinimo.Size = new System.Drawing.Size(200, 23);
            this.numStockMinimo.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numStockMinimo.Value = new decimal(new int[] { 5, 0, 0, 0 });
            //
            // lblPrecioUnitario
            //
            this.lblPrecioUnitario.Location = new System.Drawing.Point(20, 195);
            this.lblPrecioUnitario.Size = new System.Drawing.Size(100, 23);
            this.lblPrecioUnitario.Text = "Precio unitario";
            //
            // numPrecioUnitario
            //
            this.numPrecioUnitario.Location = new System.Drawing.Point(120, 192);
            this.numPrecioUnitario.Size = new System.Drawing.Size(200, 23);
            this.numPrecioUnitario.DecimalPlaces = 2;
            this.numPrecioUnitario.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            this.numPrecioUnitario.ValueChanged += new System.EventHandler(this.numPrecioUnitario_ValueChanged);
            //
            // lblValorTotalTitulo
            //
            this.lblValorTotalTitulo.Location = new System.Drawing.Point(20, 230);
            this.lblValorTotalTitulo.Size = new System.Drawing.Size(100, 23);
            this.lblValorTotalTitulo.Text = "Valor total";
            //
            // lblValorTotal
            //
            this.lblValorTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblValorTotal.Location = new System.Drawing.Point(120, 230);
            this.lblValorTotal.Size = new System.Drawing.Size(200, 23);
            this.lblValorTotal.Text = "$0";
            //
            // lstMateriales
            //
            this.lstMateriales.Location = new System.Drawing.Point(360, 17);
            this.lstMateriales.Size = new System.Drawing.Size(320, 200);
            this.lstMateriales.SelectedIndexChanged += new System.EventHandler(this.lstMateriales_SelectedIndexChanged);
            //
            // btnAceptar
            //
            this.btnAceptar.Location = new System.Drawing.Point(20, 270);
            this.btnAceptar.Size = new System.Drawing.Size(90, 30);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(120, 270);
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(220, 270);
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(320, 270);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnVolver
            //
            this.btnVolver.Location = new System.Drawing.Point(20, 310);
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(20, 350);
            this.lblMensaje.Size = new System.Drawing.Size(660, 40);
            //
            // FrmMateriales
            //
            this.ClientSize = new System.Drawing.Size(700, 440);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.numStockMinimo);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.numPrecioUnitario);
            this.Controls.Add(this.lblValorTotalTitulo);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lstMateriales);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMateriales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Materiales";
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMinimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioUnitario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
