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
        private System.Windows.Forms.Label lblPrecioPorUnidadTitulo;
        private System.Windows.Forms.Label lblPrecioPorUnidad;
        private System.Windows.Forms.ListBox lstDetalle;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblMensaje;

        private void InitializeComponent()
        {
            lblMaterial = new Label();
            cmbMaterial = new ComboBox();
            lblCantidad = new Label();
            numCantidad = new NumericUpDown();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblPrecioParcial = new Label();
            numPrecioParcial = new NumericUpDown();
            lblPrecioPorUnidadTitulo = new Label();
            lblPrecioPorUnidad = new Label();
            lstDetalle = new ListBox();
            btnAceptar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnVolver = new Button();
            lblMensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioParcial).BeginInit();
            SuspendLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            //
            // lblMaterial
            // 
            lblMaterial.Location = new Point(20, 20);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(90, 23);
            lblMaterial.TabIndex = 0;
            lblMaterial.Text = "Material";
            // 
            // cmbMaterial
            // 
            cmbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaterial.Location = new Point(120, 17);
            cmbMaterial.Name = "cmbMaterial";
            cmbMaterial.Size = new Size(200, 23);
            cmbMaterial.TabIndex = 1;
            // 
            // lblCantidad
            // 
            lblCantidad.Location = new Point(20, 55);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(90, 23);
            lblCantidad.TabIndex = 2;
            lblCantidad.Text = "Cantidad";
            // 
            // numCantidad
            // 
            numCantidad.Location = new Point(120, 52);
            numCantidad.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(200, 23);
            numCantidad.TabIndex = 3;
            numCantidad.ValueChanged += numCantidadOPrecioParcial_ValueChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.Location = new Point(20, 90);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(90, 23);
            lblCodigo.TabIndex = 4;
            lblCodigo.Text = "Codigo";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(120, 87);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(200, 23);
            txtCodigo.TabIndex = 5;
            // 
            // lblPrecioParcial
            // 
            lblPrecioParcial.Location = new Point(20, 125);
            lblPrecioParcial.Name = "lblPrecioParcial";
            lblPrecioParcial.Size = new Size(90, 23);
            lblPrecioParcial.TabIndex = 6;
            lblPrecioParcial.Text = "Precio Final";
            //
            // numPrecioParcial
            //
            numPrecioParcial.DecimalPlaces = 2;
            numPrecioParcial.Location = new Point(120, 122);
            numPrecioParcial.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numPrecioParcial.Name = "numPrecioParcial";
            numPrecioParcial.Size = new Size(200, 23);
            numPrecioParcial.TabIndex = 7;
            numPrecioParcial.ValueChanged += numCantidadOPrecioParcial_ValueChanged;
            //
            // lblPrecioPorUnidadTitulo
            //
            lblPrecioPorUnidadTitulo.Location = new Point(20, 160);
            lblPrecioPorUnidadTitulo.Name = "lblPrecioPorUnidadTitulo";
            lblPrecioPorUnidadTitulo.Size = new Size(90, 23);
            lblPrecioPorUnidadTitulo.TabIndex = 15;
            lblPrecioPorUnidadTitulo.Text = "Precio x unidad";
            //
            // lblPrecioPorUnidad
            //
            lblPrecioPorUnidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrecioPorUnidad.Location = new Point(120, 160);
            lblPrecioPorUnidad.Name = "lblPrecioPorUnidad";
            lblPrecioPorUnidad.Size = new Size(200, 23);
            lblPrecioPorUnidad.TabIndex = 16;
            lblPrecioPorUnidad.Text = "$0";
            //
            // lstDetalle
            //
            lstDetalle.ItemHeight = 15;
            lstDetalle.Location = new Point(360, 17);
            lstDetalle.Name = "lstDetalle";
            lstDetalle.Size = new Size(320, 199);
            lstDetalle.TabIndex = 8;
            lstDetalle.SelectedIndexChanged += lstDetalle_SelectedIndexChanged;
            //
            // btnAceptar
            //
            btnAceptar.Location = new Point(20, 200);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(90, 30);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            //
            // btnModificar
            //
            btnModificar.Location = new Point(120, 200);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(90, 30);
            btnModificar.TabIndex = 10;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            //
            // btnEliminar
            //
            btnEliminar.Location = new Point(220, 200);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            //
            // btnCancelar
            //
            btnCancelar.Location = new Point(20, 236);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 30);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            //
            // btnVolver
            //
            btnVolver.Location = new Point(600, 255);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(80, 30);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            //
            // lblMensaje
            //
            lblMensaje.ForeColor = Color.Red;
            lblMensaje.Location = new Point(20, 255);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(560, 40);
            lblMensaje.TabIndex = 14;
            //
            // FrmDetalleCompra
            //
            ClientSize = new Size(700, 300);
            Controls.Add(lblMaterial);
            Controls.Add(cmbMaterial);
            Controls.Add(lblCantidad);
            Controls.Add(numCantidad);
            Controls.Add(lblCodigo);
            Controls.Add(txtCodigo);
            Controls.Add(lblPrecioParcial);
            Controls.Add(numPrecioParcial);
            Controls.Add(lblPrecioPorUnidadTitulo);
            Controls.Add(lblPrecioPorUnidad);
            Controls.Add(lstDetalle);
            Controls.Add(btnAceptar);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnVolver);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmDetalleCompra";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle de Compra";
            Font = new Font("Segoe UI", 12F);
            PerformAutoScale();
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecioParcial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
