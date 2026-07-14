using GestionMaterialesConstruccion.Controladoras;

namespace GestionMaterialesConstruccion.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            var empleado = SesionActual.EmpleadoActual;
            lblBienvenida.Text = empleado != null
                ? $"Bienvenido, {empleado.Nombre} {empleado.Apellido} ({empleado.Rol})"
                : "Bienvenido";
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            using var frm = new FrmProveedores();
            frm.ShowDialog();
        }

        private void btnMateriales_Click(object sender, EventArgs e)
        {
            using var frm = new FrmMateriales();
            frm.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            using var frm = new FrmCompras();
            frm.ShowDialog();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            // CUD 0007/0011/0016 - Verificar Permisos
            if (!SesionActual.TienePermisoAdministrador())
            {
                MessageBox.Show("No tiene permisos para gestionar empleados.", "Acceso denegado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var frm = new FrmEmpleados();
            frm.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            SesionActual.CerrarSesion();
            Hide();

            using var frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                var empleado = SesionActual.EmpleadoActual;
                lblBienvenida.Text = empleado != null
                    ? $"Bienvenido, {empleado.Nombre} {empleado.Apellido} ({empleado.Rol})"
                    : "Bienvenido";
                Show();
            }
            else
            {
                Close();
                Application.Exit();
            }
        }
    }
}
