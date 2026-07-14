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
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblDetalle = new Label();
            txtDetalle = new TextBox();
            lblProveedor = new Label();
            cmbProveedor = new ComboBox();
            lblPrecioTotal = new Label();
            txtPrecioTotal = new TextBox();
            lstCompras = new ListBox();
            btnAceptar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnDetalle = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.Location = new Point(20, 20);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(90, 23);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(120, 17);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(20, 55);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(90, 23);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(120, 52);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            // 
            // lblDetalle
            // 
            lblDetalle.Location = new Point(20, 90);
            lblDetalle.Name = "lblDetalle";
            lblDetalle.Size = new Size(90, 23);
            lblDetalle.TabIndex = 4;
            lblDetalle.Text = "Detalle";
            // 
            // txtDetalle
            // 
            txtDetalle.Location = new Point(120, 87);
            txtDetalle.Name = "txtDetalle";
            txtDetalle.Size = new Size(200, 23);
            txtDetalle.TabIndex = 5;
            // 
            // lblProveedor
            // 
            lblProveedor.Location = new Point(20, 125);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(90, 23);
            lblProveedor.TabIndex = 6;
            lblProveedor.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProveedor.Location = new Point(120, 122);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(200, 23);
            cmbProveedor.TabIndex = 7;
            // 
            // lblPrecioTotal
            // 
            lblPrecioTotal.Location = new Point(20, 160);
            lblPrecioTotal.Name = "lblPrecioTotal";
            lblPrecioTotal.Size = new Size(90, 23);
            lblPrecioTotal.TabIndex = 8;
            lblPrecioTotal.Text = "Precio Total";
            // 
            // txtPrecioTotal
            // 
            txtPrecioTotal.Enabled = false;
            txtPrecioTotal.Location = new Point(120, 157);
            txtPrecioTotal.Name = "txtPrecioTotal";
            txtPrecioTotal.Size = new Size(200, 23);
            txtPrecioTotal.TabIndex = 9;
            // 
            // lstCompras
            // 
            lstCompras.ItemHeight = 15;
            lstCompras.Location = new Point(360, 17);
            lstCompras.Name = "lstCompras";
            lstCompras.Size = new Size(320, 199);
            lstCompras.TabIndex = 10;
            lstCompras.SelectedIndexChanged += lstCompras_SelectedIndexChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(20, 240);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(90, 30);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(120, 240);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 30);
            btnModificar.TabIndex = 12;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(220, 240);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(320, 240);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnDetalle
            // 
            btnDetalle.Location = new Point(416, 240);
            btnDetalle.Name = "btnDetalle";
            btnDetalle.Size = new Size(160, 30);
            btnDetalle.TabIndex = 15;
            btnDetalle.Text = "Detalle de Compra...";
            btnDetalle.UseVisualStyleBackColor = true;
            btnDetalle.Click += btnDetalle_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(20, 280);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(660, 40);
            lblMensaje.TabIndex = 16;
            // 
            // FrmCompras
            // 
            ClientSize = new Size(700, 330);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblFecha);
            Controls.Add(dtpFecha);
            Controls.Add(lblDetalle);
            Controls.Add(txtDetalle);
            Controls.Add(lblProveedor);
            Controls.Add(cmbProveedor);
            Controls.Add(lblPrecioTotal);
            Controls.Add(txtPrecioTotal);
            Controls.Add(lstCompras);
            Controls.Add(btnAceptar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnDetalle);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmCompras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestionar Compras";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
