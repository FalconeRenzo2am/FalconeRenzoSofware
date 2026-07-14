using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// R01 - Gestionar Proveedores.
    /// </summary>
    public partial class FrmProveedores : Form
    {
        private readonly ProveedorControladora controladora = new();
        private List<Proveedor> proveedores = new();
        private Proveedor proveedorSeleccionado;

        public FrmProveedores()
        {
            InitializeComponent();
            cmbTipo.DataSource = Enum.GetValues(typeof(TipoProveedor));
            CargarLista();
        }

        private void CargarLista()
        {
            proveedores = controladora.ObtenerTodos();
            lstProveedores.DataSource = null;
            lstProveedores.DataSource = proveedores;
            LimpiarFormulario();
        }

        private void lstProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            proveedorSeleccionado = lstProveedores.SelectedItem as Proveedor;
            if (proveedorSeleccionado == null) return;

            txtNombre.Text = proveedorSeleccionado.Nombre;
            txtApellido.Text = proveedorSeleccionado.Apellido;
            txtDni.Text = proveedorSeleccionado.Dni;
            txtCodigo.Text = proveedorSeleccionado.Codigo;
            txtTelefono.Text = proveedorSeleccionado.Telefono;
            cmbTipo.SelectedItem = proveedorSeleccionado.Tipo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var proveedor = new Proveedor
                {
                    Nombre = txtNombre.Text.Trim(),
                    Apellido = txtApellido.Text.Trim(),
                    Dni = txtDni.Text.Trim(),
                    Codigo = txtCodigo.Text.Trim(),
                    Telefono = txtTelefono.Text.Trim(),
                    Tipo = (TipoProveedor)(cmbTipo.SelectedItem ?? TipoProveedor.Natural)
                };

                controladora.Agregar(proveedor);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un proveedor de la lista.";
                return;
            }

            try
            {
                proveedorSeleccionado.Nombre = txtNombre.Text.Trim();
                proveedorSeleccionado.Apellido = txtApellido.Text.Trim();
                proveedorSeleccionado.Dni = txtDni.Text.Trim();
                proveedorSeleccionado.Codigo = txtCodigo.Text.Trim();
                proveedorSeleccionado.Telefono = txtTelefono.Text.Trim();
                proveedorSeleccionado.Tipo = (TipoProveedor)(cmbTipo.SelectedItem ?? TipoProveedor.Natural);

                controladora.Modificar(proveedorSeleccionado);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (proveedorSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un proveedor de la lista.";
                return;
            }

            try
            {
                controladora.Eliminar(proveedorSeleccionado.Id);
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
            proveedorSeleccionado = null;
            lstProveedores.ClearSelected();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
            txtCodigo.Clear();
            txtTelefono.Clear();
            cmbTipo.SelectedIndex = -1;
            lblMensaje.Text = string.Empty;
        }
    }
}
