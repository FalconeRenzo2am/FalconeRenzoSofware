using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// R04 - Registrar Empleados.
    /// </summary>
    public partial class FrmEmpleados : Form
    {
        private readonly EmpleadoControladora controladora = new();
        private List<Empleado> empleados = new();
        private Empleado empleadoSeleccionado;

        public FrmEmpleados()
        {
            InitializeComponent();
            cmbRol.DataSource = Enum.GetValues(typeof(RolEmpleado));
            CargarLista();
        }

        private void CargarLista()
        {
            empleados = controladora.ObtenerTodos();
            lstEmpleados.DataSource = null;
            lstEmpleados.DataSource = empleados;
            LimpiarFormulario();
        }

        private void lstEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            empleadoSeleccionado = lstEmpleados.SelectedItem as Empleado;
            if (empleadoSeleccionado == null) return;

            txtNombre.Text = empleadoSeleccionado.Nombre;
            txtApellido.Text = empleadoSeleccionado.Apellido;
            txtDni.Text = empleadoSeleccionado.Dni;
            txtLegajo.Text = empleadoSeleccionado.Legajo;
            txtEmail.Text = empleadoSeleccionado.Email;
            txtContrasenia.Text = empleadoSeleccionado.Contrasenia;
            cmbRol.SelectedItem = empleadoSeleccionado.Rol;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var empleado = new Empleado
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Dni = txtDni.Text.Trim(),
                    Legajo = txtLegajo.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Contrasenia = txtContrasenia.Text,
                    Rol = (RolEmpleado)(cmbRol.SelectedItem ?? RolEmpleado.Empleado)
                };

                controladora.Agregar(empleado);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un empleado de la lista.";
                return;
            }

            try
            {
                empleadoSeleccionado.Nombre = txtNombre.Text.Trim();
                empleadoSeleccionado.Apellido = txtApellido.Text.Trim();
                empleadoSeleccionado.Dni = txtDni.Text.Trim();
                empleadoSeleccionado.Legajo = txtLegajo.Text.Trim();
                empleadoSeleccionado.Email = txtEmail.Text.Trim();
                empleadoSeleccionado.Contrasenia = txtContrasenia.Text;
                empleadoSeleccionado.Rol = (RolEmpleado)(cmbRol.SelectedItem ?? RolEmpleado.Empleado);

                controladora.Modificar(empleadoSeleccionado);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (empleadoSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un empleado de la lista.";
                return;
            }

            try
            {
                controladora.Eliminar(empleadoSeleccionado.Id);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            empleadoSeleccionado = null;
            lstEmpleados.ClearSelected();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtLegajo.Clear();
            txtEmail.Clear();
            txtContrasenia.Clear();
            cmbRol.SelectedIndex = -1;
            lblMensaje.Text = string.Empty;
        }
    }
}
