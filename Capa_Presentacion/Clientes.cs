using capa_negocios;
using Capa_negocios;
using ConexionDatos;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Presentacion
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreC.Text))
            {
                MessageBox.Show("Por favor completa los campos obligatorios: Nombre, Teléfono y RNC.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefC.Text)) 
            {
                MessageBox.Show("Por favor completa los campos obligatorios: Nombre, Teléfono y RNC.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRncC.Text))
            {
                MessageBox.Show("Por favor completa los campos obligatorios: Nombre, Teléfono y RNC.");
                return;
            }
            // Crear nuevo cliente con los datos del formulario
            CNCliente cliente = new CNCliente(
                txtNombreC.Text.Trim(),
                txtTelefC.Text.Trim(),
                txtRncC.Text.Trim()

            )
            {
                Correo = txtCorreoC.Text.Trim()
            };

            // Llamar a la capa de datos para guardar en base
            CNClienteDal datos = new CNClienteDal();
            int resultado = datos.InsertarCliente(cliente);

            if (resultado > 0)
            {
                MessageBox.Show("Exito al guardar datos de factura");
                this.DialogResult = DialogResult.OK;
                this.Close(); // Cierra el formulario si todo salió bien
            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar");
            }
            LimpiarCampos();


            /*  // Validaciones
            if (string.IsNullOrWhiteSpace(txtCliente.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Nombre del cliente y descripción del producto son obligatorios.");
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || !int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Precio o cantidad inválidos.");
                return;
            }

            if (!decimal.TryParse(txtDescuento.Text, out decimal descuento))
            {
                descuento = 0; // Se permite facturación sin descuento
            }

            var cliente = new CNCliente(txtCliente.Text, txtTelef1.Text, txtRnc.Text, descuento);

            Factura factura = cbTipo.SelectedItem?.ToString() == "Contado"
                ? new FacturaContado(cliente)
                : new FacturaCredito(cliente);

            factura.Descripcion = txtDescripcion.Text;
            factura.Precio = precio;
            factura.Cantidad = cantidad;
            factura.Fecha = dtpFecha.Value;
            factura.CalcularTotales();

            //TODO captura de exito o error al infresar datos
            int result = FacturaDal.IngresarDatos(factura);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar datos de factura");

                CNMemoriaTemporal.FacturasGeneradas.Add(factura);
                dgvFactura.DataSource = null;
                dgvFactura.DataSource = CNMemoriaTemporal.FacturasGeneradas.Select(f => new
                {
                    f.Cliente.Nombre,
                    f.Descripcion,
                    f.Cantidad,
                    f.Precio,
                    f.SubTotal,
                    f.Descuento,
                    f.Total,
                    Tipo = f.TipoFactura(),
                    f.Fecha
                }).ToList();

            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar");
            }

            LimpiarCampos();*/
        }
        private void LimpiarCampos()
        {
            txtNombreC.Text = "";
            txtTelefC.Text = "";
            txtRncC.Text = "";
            txtCorreoC.Text = "";
           
        }
    }
}
