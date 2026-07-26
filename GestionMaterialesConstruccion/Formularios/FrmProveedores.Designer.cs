namespace GestionMaterialesConstruccion.Formularios
{
    partial class FrmProveedores
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
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ListBox lstProveedores;
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
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lstProveedores = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // lblApellido
            //
            this.lblApellido.Location = new System.Drawing.Point(20, 55);
            this.lblApellido.Size = new System.Drawing.Size(90, 23);
            this.lblApellido.Text = "Apellido";
            //
            // txtApellido
            //
            this.txtApellido.Location = new System.Drawing.Point(120, 52);
            this.txtApellido.Size = new System.Drawing.Size(200, 23);
            //
            // lblDni
            //
            this.lblDni.Location = new System.Drawing.Point(20, 90);
            this.lblDni.Size = new System.Drawing.Size(90, 23);
            this.lblDni.Text = "DNI";
            //
            // txtDni
            //
            this.txtDni.Location = new System.Drawing.Point(120, 87);
            this.txtDni.Size = new System.Drawing.Size(200, 23);
            //
            // lblCodigo
            //
            this.lblCodigo.Location = new System.Drawing.Point(20, 125);
            this.lblCodigo.Size = new System.Drawing.Size(90, 23);
            this.lblCodigo.Text = "Codigo";
            //
            // txtCodigo
            //
            this.txtCodigo.Location = new System.Drawing.Point(120, 122);
            this.txtCodigo.Size = new System.Drawing.Size(200, 23);
            //
            // lblTelefono
            //
            this.lblTelefono.Location = new System.Drawing.Point(20, 160);
            this.lblTelefono.Size = new System.Drawing.Size(90, 23);
            this.lblTelefono.Text = "Teléfono";
            //
            // txtTelefono
            //
            this.txtTelefono.Location = new System.Drawing.Point(120, 157);
            this.txtTelefono.Size = new System.Drawing.Size(200, 23);
            //
            // lblTipo
            //
            this.lblTipo.Location = new System.Drawing.Point(20, 195);
            this.lblTipo.Size = new System.Drawing.Size(90, 23);
            this.lblTipo.Text = "Tipo";
            //
            // cmbTipo
            //
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Location = new System.Drawing.Point(120, 192);
            this.cmbTipo.Size = new System.Drawing.Size(200, 23);
            //
            // lstProveedores
            //
            this.lstProveedores.Location = new System.Drawing.Point(360, 17);
            this.lstProveedores.Size = new System.Drawing.Size(320, 200);
            this.lstProveedores.SelectedIndexChanged += new System.EventHandler(this.lstProveedores_SelectedIndexChanged);
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
            // btnVolver
            //
            this.btnVolver.Location = new System.Drawing.Point(20, 280);
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(20, 320);
            this.lblMensaje.Size = new System.Drawing.Size(660, 40);
            //
            // FrmProveedores
            //
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lstProveedores);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Proveedores";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
