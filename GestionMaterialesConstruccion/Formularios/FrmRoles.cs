using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// Creación y edición de roles: nombre, descripción, a qué pantallas del sistema
    /// tiene acceso (permisos) y qué empleados lo tienen asignado.
    /// </summary>
    public partial class FrmRoles : Form
    {
        private readonly RolControladora controladora = new();
        private readonly EmpleadoControladora controladoraEmpleados = new();
        private List<Rol> roles = new();
        private Rol rolSeleccionado;

        public FrmRoles()
        {
            InitializeComponent();
            CargarPermisos();
            CargarEmpleados();
            CargarLista();
        }

        private void CargarPermisos()
        {
            clbPermisos.Items.Clear();
            foreach (var permiso in controladora.ObtenerPermisosDisponibles())
                clbPermisos.Items.Add(permiso);
        }

        private void CargarEmpleados()
        {
            clbEmpleados.Items.Clear();
            foreach (var empleado in controladoraEmpleados.ObtenerTodos())
                clbEmpleados.Items.Add(empleado);
        }

        private void CargarLista()
        {
            roles = controladora.ObtenerTodos();
            lstRoles.DataSource = null;
            lstRoles.DataSource = roles;
            LimpiarFormulario();
        }

        private void lstRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            rolSeleccionado = lstRoles.SelectedItem as Rol;
            if (rolSeleccionado == null) return;

            txtNombre.Text = rolSeleccionado.Nombre;
            txtDescripcion.Text = rolSeleccionado.Descripcion;

            for (int i = 0; i < clbPermisos.Items.Count; i++)
            {
                var permiso = (Permiso)clbPermisos.Items[i];
                clbPermisos.SetItemChecked(i, rolSeleccionado.Permisos.Any(p => p.Id == permiso.Id));
            }

            for (int i = 0; i < clbEmpleados.Items.Count; i++)
            {
                var empleado = (Empleado)clbEmpleados.Items[i];
                clbEmpleados.SetItemChecked(i, empleado.RolId == rolSeleccionado.Id);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var rol = new Rol
                {
                    Nombre = txtNombre.Text.Trim(),
                    Descripcion = txtDescripcion.Text.Trim()
                };

                controladora.Agregar(rol, ObtenerPermisosSeleccionados(), ObtenerEmpleadosSeleccionados());
                CargarEmpleados();
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (rolSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un rol de la lista.";
                return;
            }

            try
            {
                rolSeleccionado.Nombre = txtNombre.Text.Trim();
                rolSeleccionado.Descripcion = txtDescripcion.Text.Trim();

                controladora.Modificar(rolSeleccionado, ObtenerPermisosSeleccionados(), ObtenerEmpleadosSeleccionados());
                CargarEmpleados();
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rolSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un rol de la lista.";
                return;
            }

            try
            {
                controladora.Eliminar(rolSeleccionado.Id);
                CargarEmpleados();
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<int> ObtenerPermisosSeleccionados()
        {
            return clbPermisos.CheckedItems.Cast<Permiso>().Select(p => p.Id).ToList();
        }

        private List<int> ObtenerEmpleadosSeleccionados()
        {
            return clbEmpleados.CheckedItems.Cast<Empleado>().Select(e => e.Id).ToList();
        }

        private void LimpiarFormulario()
        {
            rolSeleccionado = null;
            lstRoles.ClearSelected();
            txtNombre.Clear();
            txtDescripcion.Clear();
            for (int i = 0; i < clbPermisos.Items.Count; i++)
                clbPermisos.SetItemChecked(i, false);
            for (int i = 0; i < clbEmpleados.Items.Count; i++)
                clbEmpleados.SetItemChecked(i, false);
            lblMensaje.Text = string.Empty;
        }
    }
}
