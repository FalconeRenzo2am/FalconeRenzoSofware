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
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnCerrarSesion;

        private void InitializeComponent()
        {
            lblBienvenida = new Label();
            btnProveedores = new Button();
            btnMateriales = new Button();
            btnCompras = new Button();
            btnEmpleados = new Button();
            btnReportes = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            //
            // lblBienvenida
            // 
            lblBienvenida.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblBienvenida.Location = new Point(30, 20);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(400, 30);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Bienvenido";
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(30, 70);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(360, 40);
            btnProveedores.TabIndex = 1;
            btnProveedores.Text = "Gestionar Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // btnMateriales
            // 
            btnMateriales.Location = new Point(30, 120);
            btnMateriales.Name = "btnMateriales";
            btnMateriales.Size = new Size(360, 40);
            btnMateriales.TabIndex = 2;
            btnMateriales.Text = "Gestionar Materiales";
            btnMateriales.UseVisualStyleBackColor = true;
            btnMateriales.Click += btnMateriales_Click;
            // 
            // btnCompras
            // 
            btnCompras.Location = new Point(30, 170);
            btnCompras.Name = "btnCompras";
            btnCompras.Size = new Size(360, 40);
            btnCompras.TabIndex = 3;
            btnCompras.Text = "Gestionar Compras";
            btnCompras.UseVisualStyleBackColor = true;
            btnCompras.Click += btnCompras_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Location = new Point(30, 220);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(360, 40);
            btnEmpleados.TabIndex = 4;
            btnEmpleados.Text = "Gestionar Empleados ";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            //
            // btnReportes
            //
            btnReportes.Location = new Point(30, 270);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(360, 40);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "Reportes y Gráficos";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            //
            // btnCerrarSesion
            //
            btnCerrarSesion.Location = new Point(30, 330);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(360, 30);
            btnCerrarSesion.TabIndex = 6;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            //
            // FrmPrincipal
            //
            ClientSize = new Size(420, 390);
            Controls.Add(lblBienvenida);
            Controls.Add(btnProveedores);
            Controls.Add(btnMateriales);
            Controls.Add(btnCompras);
            Controls.Add(btnEmpleados);
            Controls.Add(btnReportes);
            Controls.Add(btnCerrarSesion);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Falcone SA - Gestión de Materiales de Construcción";
            Font = new Font("Segoe UI", 12F);
            PerformAutoScale();
            ResumeLayout(false);
        }
    }
}
