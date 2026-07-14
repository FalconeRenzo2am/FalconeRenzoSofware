using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// R02 - Gestionar Materiales.
    /// </summary>
    public partial class FrmMateriales : Form
    {
        private readonly MaterialControladora controladora = new();
        private List<Material> materiales = new();
        private Material materialSeleccionado;

        public FrmMateriales()
        {
            InitializeComponent();
            CargarLista();
        }

        private void CargarLista()
        {
            materiales = controladora.ObtenerTodos();
            lstMateriales.DataSource = null;
            lstMateriales.DataSource = materiales;
            LimpiarFormulario();
        }

        private void lstMateriales_SelectedIndexChanged(object sender, EventArgs e)
        {
            materialSeleccionado = lstMateriales.SelectedItem as Material;
            if (materialSeleccionado == null) return;

            txtNombre.Text = materialSeleccionado.Nombre;
            txtCodigo.Text = materialSeleccionado.Codigo;
            numCantidad.Value = materialSeleccionado.Cantidad;
            txtTipo.Text = materialSeleccionado.Tipo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var material = new Material
                {
                    Nombre = txtNombre.Text.Trim(),
                    Codigo = txtCodigo.Text.Trim(),
                    Cantidad = (int)numCantidad.Value,
                    Tipo = txtTipo.Text.Trim()
                };

                controladora.Agregar(material);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (materialSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un material de la lista.";
                return;
            }

            try
            {
                materialSeleccionado.Nombre = txtNombre.Text.Trim();
                materialSeleccionado.Codigo = txtCodigo.Text.Trim();
                materialSeleccionado.Cantidad = (int)numCantidad.Value;
                materialSeleccionado.Tipo = txtTipo.Text.Trim();

                controladora.Modificar(materialSeleccionado);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (materialSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un material de la lista.";
                return;
            }

            try
            {
                controladora.Eliminar(materialSeleccionado.Id);
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
            materialSeleccionado = null;
            lstMateriales.ClearSelected();
            txtNombre.Clear();
            txtCodigo.Clear();
            numCantidad.Value = 0;
            txtTipo.Clear();
            lblMensaje.Text = string.Empty;
        }
    }
}
