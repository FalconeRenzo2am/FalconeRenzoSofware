using GestionMaterialesConstruccion.Controladoras;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// R05 - Iniciar sesión.
    /// </summary>
    public partial class FrmLogin : Form
    {
        private readonly EmpleadoControladora controladora = new();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = string.Empty;

            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtContrasenia.Text))
            {
                lblMensaje.Text = "Debe ingresar email y contraseña.";
                return;
            }

            try
            {
                var empleado = controladora.IniciarSesion(txtEmail.Text.Trim(), txtContrasenia.Text);
                if (empleado == null)
                {
                    lblMensaje.Text = "Email o contraseña incorrectos.";
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
