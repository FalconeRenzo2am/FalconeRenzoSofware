using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// Detalle de una Compra (líneas de material comprado). Cada línea confirmada
    /// repone stock del material asociado (ver CompraControladora.AgregarDetalle).
    /// </summary>
    public partial class FrmDetalleCompra : Form
    {
        private readonly CompraControladora controladora = new();
        private readonly MaterialControladora controladoraMateriales = new();
        private readonly int compraId;
        private DetalleCompra detalleSeleccionado;

        public FrmDetalleCompra(int compraId)
        {
            InitializeComponent();
            this.compraId = compraId;
            CargarMateriales();
            CargarLista();
        }

        private void CargarMateriales()
        {
            cmbMaterial.DataSource = controladoraMateriales.ObtenerTodos();
            cmbMaterial.DisplayMember = nameof(Material.Nombre);
            cmbMaterial.ValueMember = nameof(Material.Id);
        }

        private void CargarLista()
        {
            var compra = controladora.ObtenerPorId(compraId);
            Text = $"Detalle de Compra - {compra?.Codigo}";

            lstDetalle.DataSource = null;
            lstDetalle.DataSource = compra?.Detalles ?? new List<DetalleCompra>();
            LimpiarFormulario();
        }

        private void lstDetalle_SelectedIndexChanged(object sender, EventArgs e)
        {
            detalleSeleccionado = lstDetalle.SelectedItem as DetalleCompra;
            if (detalleSeleccionado == null) return;

            cmbMaterial.SelectedValue = detalleSeleccionado.MaterialId;
            numCantidad.Value = detalleSeleccionado.Cantidad;
            txtCodigo.Text = detalleSeleccionado.Codigo;
            numPrecioParcial.Value = detalleSeleccionado.PrecioParcial;
        }

        private void numCantidadOPrecioParcial_ValueChanged(object sender, EventArgs e)
        {
            decimal precioPorUnidad = numCantidad.Value > 0 ? numPrecioParcial.Value / numCantidad.Value : 0;
            lblPrecioPorUnidad.Text = precioPorUnidad.ToString("C");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var detalle = new DetalleCompra
                {
                    Codigo = txtCodigo.Text.Trim(),
                    MaterialId = (cmbMaterial.SelectedItem as Material)?.Id ?? 0,
                    Cantidad = (int)numCantidad.Value,
                    PrecioParcial = numPrecioParcial.Value
                };

                controladora.AgregarDetalle(compraId, detalle);
                CargarMateriales();
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (detalleSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un detalle de la lista.";
                return;
            }

            try
            {
                detalleSeleccionado.Codigo = txtCodigo.Text.Trim();
                detalleSeleccionado.MaterialId = (cmbMaterial.SelectedItem as Material)?.Id ?? 0;
                detalleSeleccionado.Cantidad = (int)numCantidad.Value;
                detalleSeleccionado.PrecioParcial = numPrecioParcial.Value;

                controladora.ModificarDetalle(detalleSeleccionado);
                CargarMateriales();
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (detalleSeleccionado == null)
            {
                lblMensaje.Text = "Debe seleccionar un detalle de la lista.";
                return;
            }

            try
            {
                controladora.EliminarDetalle(detalleSeleccionado.Id);
                CargarMateriales();
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

        private void LimpiarFormulario()
        {
            detalleSeleccionado = null;
            lstDetalle.ClearSelected();
            if (cmbMaterial.Items.Count > 0)
                cmbMaterial.SelectedIndex = -1;
            numCantidad.Value = 0;
            txtCodigo.Clear();
            numPrecioParcial.Value = 0;
            lblMensaje.Text = string.Empty;
        }
    }
}
