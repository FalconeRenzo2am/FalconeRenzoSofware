using GestionMaterialesConstruccion.Controladoras;
using GestionMaterialesConstruccion.Modelos;

namespace GestionMaterialesConstruccion.Formularios
{
    /// <summary>
    /// R03 - Gestionar Compra (requerimiento "CORE").
    /// </summary>
    public partial class FrmCompras : Form
    {
        private readonly CompraControladora controladora = new();
        private readonly ProveedorControladora controladoraProveedores = new();
        private List<Compra> compras = new();
        private Compra compraSeleccionada;

        public FrmCompras()
        {
            InitializeComponent();
            CargarProveedores();
            CargarLista();
        }

        private void CargarProveedores()
        {
            var proveedores = controladoraProveedores.ObtenerTodos();
            cmbProveedor.DataSource = proveedores;
            cmbProveedor.ValueMember = nameof(Proveedor.Id);
        }

        private void CargarLista()
        {
            compras = controladora.ObtenerTodas();
            lstCompras.DataSource = null;
            lstCompras.DataSource = compras;
            LimpiarFormulario();
        }

        private void lstCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            compraSeleccionada = lstCompras.SelectedItem as Compra;
            if (compraSeleccionada == null) return;

            txtCodigo.Text = compraSeleccionada.Codigo;
            dtpFecha.Value = compraSeleccionada.Fecha;
            txtDetalle.Text = compraSeleccionada.Detalle;
            cmbProveedor.SelectedValue = compraSeleccionada.ProveedorId;
            txtPrecioTotal.Text = compraSeleccionada.PrecioTotal.ToString("C");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                var compra = new Compra
                {
                    Codigo = txtCodigo.Text.Trim(),
                    Fecha = dtpFecha.Value,
                    Detalle = txtDetalle.Text.Trim(),
                    ProveedorId = (cmbProveedor.SelectedItem as Proveedor)?.Id ?? 0
                };

                controladora.Agregar(compra);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (compraSeleccionada == null)
            {
                lblMensaje.Text = "Debe seleccionar una compra de la lista.";
                return;
            }

            try
            {
                compraSeleccionada.Codigo = txtCodigo.Text.Trim();
                compraSeleccionada.Fecha = dtpFecha.Value;
                compraSeleccionada.Detalle = txtDetalle.Text.Trim();
                compraSeleccionada.ProveedorId = (cmbProveedor.SelectedItem as Proveedor)?.Id ?? 0;

                controladora.Modificar(compraSeleccionada);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (compraSeleccionada == null)
            {
                lblMensaje.Text = "Debe seleccionar una compra de la lista.";
                return;
            }

            try
            {
                controladora.Eliminar(compraSeleccionada.Id);
                CargarLista();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (compraSeleccionada == null)
            {
                lblMensaje.Text = "Debe seleccionar una compra de la lista.";
                return;
            }

            using var frm = new FrmDetalleCompra(compraSeleccionada.Id);
            frm.ShowDialog();
            CargarLista();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            compraSeleccionada = null;
            lstCompras.ClearSelected();
            txtCodigo.Clear();
            dtpFecha.Value = DateTime.Now;
            txtDetalle.Clear();
            if (cmbProveedor.Items.Count > 0)
                cmbProveedor.SelectedIndex = -1;
            txtPrecioTotal.Clear();
            lblMensaje.Text = string.Empty;
        }
    }
}
