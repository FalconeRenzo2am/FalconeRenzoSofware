namespace GestionMaterialesConstruccion.Formularios
{
    partial class FrmEmpleados
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
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblContrasenia;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblRolValor;
        private System.Windows.Forms.ListBox lstEmpleados;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCrearRol;
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
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblRolValor = new System.Windows.Forms.Label();
            this.lstEmpleados = new System.Windows.Forms.ListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
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
            // lblLegajo
            //
            this.lblLegajo.Location = new System.Drawing.Point(20, 125);
            this.lblLegajo.Size = new System.Drawing.Size(90, 23);
            this.lblLegajo.Text = "Legajo";
            //
            // txtLegajo
            //
            this.txtLegajo.Location = new System.Drawing.Point(120, 122);
            this.txtLegajo.Size = new System.Drawing.Size(200, 23);
            //
            // lblEmail
            //
            this.lblEmail.Location = new System.Drawing.Point(20, 160);
            this.lblEmail.Size = new System.Drawing.Size(90, 23);
            this.lblEmail.Text = "Email";
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(120, 157);
            this.txtEmail.Size = new System.Drawing.Size(200, 23);
            //
            // lblContrasenia
            //
            this.lblContrasenia.Location = new System.Drawing.Point(20, 195);
            this.lblContrasenia.Size = new System.Drawing.Size(90, 23);
            this.lblContrasenia.Text = "Contraseña";
            //
            // txtContrasenia
            //
            this.txtContrasenia.Location = new System.Drawing.Point(120, 192);
            this.txtContrasenia.Size = new System.Drawing.Size(200, 23);
            //
            // lblRol
            //
            this.lblRol.Location = new System.Drawing.Point(20, 230);
            this.lblRol.Size = new System.Drawing.Size(90, 23);
            this.lblRol.Text = "Rol";
            //
            // lblRolValor
            //
            this.lblRolValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.lblRolValor.Location = new System.Drawing.Point(120, 230);
            this.lblRolValor.Size = new System.Drawing.Size(220, 23);
            this.lblRolValor.Text = "Rol no asignado";
            //
            // lstEmpleados
            //
            this.lstEmpleados.Location = new System.Drawing.Point(360, 17);
            this.lstEmpleados.Size = new System.Drawing.Size(320, 235);
            this.lstEmpleados.SelectedIndexChanged += new System.EventHandler(this.lstEmpleados_SelectedIndexChanged);
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
            // btnCrearRol
            //
            this.btnCrearRol.Location = new System.Drawing.Point(420, 270);
            this.btnCrearRol.Size = new System.Drawing.Size(140, 30);
            this.btnCrearRol.Text = "Crear Rol";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
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
            // FrmEmpleados
            //
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ClientSize = new System.Drawing.Size(700, 430);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblRolValor);
            this.Controls.Add(this.lstEmpleados);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Empleados";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
