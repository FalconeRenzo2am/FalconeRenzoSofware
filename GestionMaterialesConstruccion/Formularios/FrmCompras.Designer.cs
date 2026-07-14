namespace GestionMaterialesConstruccion.Formularios
{
    partial class FrmCompras
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

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.ListBox lstCompras;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Label lblMensaje;

        private void InitializeComponent()
        {
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.lstCompras = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            //
            // lblCodigo
            //
            this.lblCodigo.Location = new System.Drawing.Point(20, 20);
            this.lblCodigo.Size = new System.Drawing.Size(90, 23);
            this.lblCodigo.Text = "Codigo";
            //
            // txtCodigo
            //
            this.txtCodigo.Location = new System.Drawing.Point(120, 17);
            this.txtCodigo.Size = new System.Drawing.Size(200, 23);
            //
            // lblFecha
            //
            this.lblFecha.Location = new System.Drawing.Point(20, 55);
            this.lblFecha.Size = new System.Drawing.Size(90, 23);
            this.lblFecha.Text = "Fecha";
            //
            // dtpFecha
            //
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(120, 52);
            this.dtpFecha.Size = new System.Drawing.Size(200, 23);
            //
            // lblDetalle
            //
            this.lblDetalle.Location = new System.Drawing.Point(20, 90);
            this.lblDetalle.Size = new System.Drawing.Size(90, 23);
            this.lblDetalle.Text = "Detalle";
            //
            // txtDetalle
            //
            this.txtDetalle.Location = new System.Drawing.Point(120, 87);
            this.txtDetalle.Size = new System.Drawing.Size(200, 23);
            //
            // lblProveedor
            //
            this.lblProveedor.Location = new System.Drawing.Point(20, 125);
            this.lblProveedor.Size = new System.Drawing.Size(90, 23);
            this.lblProveedor.Text = "Proveedor";
            //
            // cmbProveedor
            //
            this.cmbProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProveedor.Location = new System.Drawing.Point(120, 122);
            this.cmbProveedor.Size = new System.Drawing.Size(200, 23);
            //
            // lblPrecioTotal
            //
            this.lblPrecioTotal.Location = new System.Drawing.Point(20, 160);
            this.lblPrecioTotal.Size = new System.Drawing.Size(90, 23);
            this.lblPrecioTotal.Text = "Precio Total";
            //
            // txtPrecioTotal
            //
            this.txtPrecioTotal.Enabled = false;
            this.txtPrecioTotal.Location = new System.Drawing.Point(120, 157);
            this.txtPrecioTotal.Size = new System.Drawing.Size(200, 23);
            //
            // lstCompras
            //
            this.lstCompras.Location = new System.Drawing.Point(360, 17);
            this.lstCompras.Size = new System.Drawing.Size(320, 200);
            this.lstCompras.SelectedIndexChanged += new System.EventHandler(this.lstCompras_SelectedIndexChanged);
            //
            // btnAceptar
            //
            this.btnAceptar.Location = new System.Drawing.Point(20, 240);
            this.btnAceptar.Size = new System.Drawing.Size(90, 30);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(120, 240);
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(220, 240);
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(320, 240);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnDetalle
            //
            this.btnDetalle.Location = new System.Drawing.Point(360, 240);
            this.btnDetalle.Size = new System.Drawing.Size(160, 30);
            this.btnDetalle.Text = "Detalle de Compra...";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(20, 280);
            this.lblMensaje.Size = new System.Drawing.Size(660, 40);
            //
            // FrmCompras
            //
            this.ClientSize = new System.Drawing.Size(700, 330);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cmbProveedor);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.lstCompras);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Compras";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
