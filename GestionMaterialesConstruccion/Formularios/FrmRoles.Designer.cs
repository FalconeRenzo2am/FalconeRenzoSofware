namespace GestionMaterialesConstruccion.Formularios
{
    partial class FrmRoles
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
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblPermisos;
        private System.Windows.Forms.CheckedListBox clbPermisos;
        private System.Windows.Forms.ListBox lstRoles;
        private System.Windows.Forms.Label lblEmpleadosRol;
        private System.Windows.Forms.CheckedListBox clbEmpleados;
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.clbPermisos = new System.Windows.Forms.CheckedListBox();
            this.lstRoles = new System.Windows.Forms.ListBox();
            this.lblEmpleadosRol = new System.Windows.Forms.Label();
            this.clbEmpleados = new System.Windows.Forms.CheckedListBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
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
            // lblDescripcion
            //
            this.lblDescripcion.Location = new System.Drawing.Point(20, 55);
            this.lblDescripcion.Size = new System.Drawing.Size(90, 23);
            this.lblDescripcion.Text = "Descripción";
            //
            // txtDescripcion
            //
            this.txtDescripcion.Location = new System.Drawing.Point(120, 52);
            this.txtDescripcion.Size = new System.Drawing.Size(200, 23);
            //
            // lblPermisos
            //
            this.lblPermisos.Location = new System.Drawing.Point(20, 90);
            this.lblPermisos.Size = new System.Drawing.Size(200, 23);
            this.lblPermisos.Text = "Permisos (accesos del rol)";
            //
            // clbPermisos
            //
            this.clbPermisos.CheckOnClick = true;
            this.clbPermisos.Location = new System.Drawing.Point(20, 115);
            this.clbPermisos.Size = new System.Drawing.Size(300, 150);
            //
            // lstRoles
            //
            this.lstRoles.Location = new System.Drawing.Point(360, 17);
            this.lstRoles.Size = new System.Drawing.Size(320, 150);
            this.lstRoles.SelectedIndexChanged += new System.EventHandler(this.lstRoles_SelectedIndexChanged);
            //
            // lblEmpleadosRol
            //
            this.lblEmpleadosRol.Location = new System.Drawing.Point(360, 175);
            this.lblEmpleadosRol.Size = new System.Drawing.Size(250, 23);
            this.lblEmpleadosRol.Text = "Empleados con este rol";
            //
            // clbEmpleados
            //
            this.clbEmpleados.CheckOnClick = true;
            this.clbEmpleados.Location = new System.Drawing.Point(360, 200);
            this.clbEmpleados.Size = new System.Drawing.Size(320, 100);
            //
            // btnAceptar
            //
            this.btnAceptar.Location = new System.Drawing.Point(20, 320);
            this.btnAceptar.Size = new System.Drawing.Size(90, 30);
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(120, 320);
            this.btnModificar.Size = new System.Drawing.Size(90, 30);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // btnEliminar
            //
            this.btnEliminar.Location = new System.Drawing.Point(220, 320);
            this.btnEliminar.Size = new System.Drawing.Size(90, 30);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            //
            // btnCancelar
            //
            this.btnCancelar.Location = new System.Drawing.Point(320, 320);
            this.btnCancelar.Size = new System.Drawing.Size(90, 30);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            //
            // btnVolver
            //
            this.btnVolver.Location = new System.Drawing.Point(20, 360);
            this.btnVolver.Size = new System.Drawing.Size(100, 30);
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            //
            // lblMensaje
            //
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(20, 400);
            this.lblMensaje.Size = new System.Drawing.Size(660, 40);
            //
            // FrmRoles
            //
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.clbPermisos);
            this.Controls.Add(this.lstRoles);
            this.Controls.Add(this.lblEmpleadosRol);
            this.Controls.Add(this.clbEmpleados);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblMensaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestionar Roles";
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
