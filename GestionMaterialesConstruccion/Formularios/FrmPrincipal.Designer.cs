namespace GestionMaterialesConstruccion.Formularios
{
    partial class FrmPrincipal
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

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnCerrarSesion;

        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblBienvenida
            //
            this.lblBienvenida.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.Location = new System.Drawing.Point(30, 20);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(400, 30);
            this.lblBienvenida.Text = "Bienvenido";
            //
            // btnProveedores
            //
            this.btnProveedores.Location = new System.Drawing.Point(30, 70);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(360, 40);
            this.btnProveedores.Text = "Gestionar Proveedores";
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            //
            // btnMateriales
            //
            this.btnMateriales.Location = new System.Drawing.Point(30, 120);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(360, 40);
            this.btnMateriales.Text = "Gestionar Materiales";
            this.btnMateriales.UseVisualStyleBackColor = true;
            this.btnMateriales.Click += new System.EventHandler(this.btnMateriales_Click);
            //
            // btnCompras
            //
            this.btnCompras.Location = new System.Drawing.Point(30, 170);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(360, 40);
            this.btnCompras.Text = "Gestionar Compras";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            //
            // btnEmpleados
            //
            this.btnEmpleados.Location = new System.Drawing.Point(30, 220);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(360, 40);
            this.btnEmpleados.Text = "Gestionar Empleados (solo Administrador)";
            this.btnEmpleados.UseVisualStyleBackColor = true;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            //
            // btnCerrarSesion
            //
            this.btnCerrarSesion.Location = new System.Drawing.Point(30, 280);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(360, 30);
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            //
            // FrmPrincipal
            //
            this.ClientSize = new System.Drawing.Size(420, 340);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.btnProveedores);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnCerrarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Falcone SA - Gestión de Materiales de Construcción";
            this.ResumeLayout(false);
        }
    }
}
