using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            ActualizarPantalla();
        }

        private void ActualizarPantalla()
        {
            var empleado = SesionActual.EmpleadoActual;
            lblBienvenida.Text = empleado != null
                ? $"Bienvenido, {empleado.Nombre} {empleado.Apellido} ({empleado.Rol?.Nombre})"
                : "Bienvenido";

            btnProveedores.Enabled = SesionActual.TienePermiso(PermisosSistema.GestionProveedores);
            btnMateriales.Enabled = SesionActual.TienePermiso(PermisosSistema.GestionMateriales);
            btnCompras.Enabled = SesionActual.TienePermiso(PermisosSistema.GestionCompras);
            btnEmpleados.Enabled = SesionActual.TienePermiso(PermisosSistema.GestionEmpleados);
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
                ActualizarPantalla();
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
