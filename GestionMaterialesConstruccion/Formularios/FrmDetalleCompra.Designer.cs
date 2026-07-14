namespace GestionMaterialesConstruccion.Formularios
{
    partial class FrmDetalleCompra
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

        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox cmbMaterial;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numCantidad;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPrecioParcial;
        private System.Windows.Forms.NumericUpDown numPrecioParcial;
        private System.Windows.Forms.ListBox lstDetalle;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblMensaje;

        private void InitializeComponent()
        {
            this.lblMaterial = new System.Windows.Forms.Label();
            this.cmbMaterial = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPrecioParcial = new System.Windows.Forms.Label();
            this.numPrecioParcial = new System.Windows.Forms.NumericUpDown();
            this.lstDetalle = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioParcial)).BeginInit();
            this.SuspendLayout();
            //
            // lblMaterial
            //
            this.lblMaterial.Location = new System.Drawing.Point(20, 20);
            this.lblMaterial.Size = new System.Drawing.Size(90, 23);
            this.lblMaterial.Text = "Material";
            //
            // cmbMaterial
            //
            this.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaterial.Location = new System.Drawing.Point(120, 17);
            this.cmbMaterial.Size = new System.Drawing.Size(200, 23);
            //
            // lblCantidad
            //
            this.lblCantidad.Location = new System.Drawing.Point(20, 55);
            this.lblCantidad.Size = new System.Drawing.Size(90, 23);
            this.lblCantidad.Text = "Cantidad";
            //
            // numCantidad
            //
            this.numCantidad.Location = new System.Drawing.Point(120, 52);
            this.numCantidad.Size = new System.Drawing.Size(200, 23);
            this.numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            //
            // lblCodigo
            //
            this.lblCodigo.Location = new System.Drawing.Point(20, 90);
            this.lblCodigo.Size = new System.Drawing.Size(90, 23);
            this.lblCodigo.Text = "Codigo";
            //
            // txtCodigo
            //
            this.txtCodigo.Location = new System.Drawing.Point(120, 87);
            this.txtCodigo.Size = new System.Drawing.Size(200, 23);
            //
            // lblPrecioParcial
            //
            this.lblPrecioParcial.Location = new System.Drawing.Point(20, 125);
            this.lblPrecioParcial.Size = new System.Drawing.Size(90, 23);
            this.lblPrecioParcial.Text = "Precio Parcial";
            //
            // numPrecioParcial
            //
            this.numPrecioParcial.DecimalPlaces = 2;
            this.numPrecioParcial.Location = new System.Drawing.Point(120, 122);
            this.numPrecioParcial.Size = new System.Drawing.Size(200, 23);
            this.numPrecioParcial.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            //
            // lstDetalle
            //
            this.lstDetalle.Location = new System.Drawing.Point(360, 17);
            this.lstDetalle.Size = new System.Drawing.Size(320, 200);
            this.lstDetalle.SelectedIndexChanged += new System.EventHandler(this.lstDetalle_SelectedIndexChanged);
            //
            // btnAceptar
            //
            this.btnAceptar.Location = new System.Drawing.Point(20, 170);
            this.btnAceptar.Size = new System.Drawing.Size(90, 30);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(120, 170);
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(220, 170);
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(320, 170);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnCerrar
            //
            this.btnCerrar.Location = new System.Drawing.Point(600, 225);
            this.btnCerrar.Size = new System.Drawing.Size(80, 30);
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(20, 225);
            this.lblMensaje.Size = new System.Drawing.Size(560, 40);
            //
            // FrmDetalleCompra
            //
            this.ClientSize = new System.Drawing.Size(700, 270);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.cmbMaterial);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.numCantidad);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblPrecioParcial);
            this.Controls.Add(this.numPrecioParcial);
            this.Controls.Add(this.lstDetalle);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDetalleCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.numCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPrecioParcial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
