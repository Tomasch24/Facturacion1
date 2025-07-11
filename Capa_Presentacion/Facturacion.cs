using capa_negocios;
using Capa_negocios;
using Capa_Presentacion;
using ConexionDatos;
using Microsoft.Data.SqlClient;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace capa_presentacion
{
    public partial class Facturacion : Form
    {

        public Facturacion()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Today;
            GenerarFactura();
            txtCliente.MaxLength = 50;
            txtDescripcion.MaxLength = 80;
            dtpFecha.Enabled = false;
            txtIdCliente.MaxLength = 5;
            txtIdCliente.Hide();
            lblId.Hide();
            txtPrecio.MaxLength = 6;
        }

        //TODO Evento del boton guardar para Facturar y guardar en la base de datos
        private void button1_Click(object sender, EventArgs e)
        {

            //TODO Capturas de error de los textbox
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("El campo Cliente esta incompleto.", "Favor completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtTelef1.MaskCompleted)
            {
                MessageBox.Show("El campo Teléfono está incompleto.", "Favor completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtRnc.MaskCompleted)
            {
                MessageBox.Show("El campo RNC está incompleto.", "Favor completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Error en el campo Referencia Producto.", "Ingrese una Referencia Producto de producto valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Error en el campo Cantidad.", "Ingrese una Cantidad valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Error en el campo Precio.", "Ingrese un Precio valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CNCliente cliente;
            if (int.TryParse(txtIdCliente.Text, out int id))
            {
                cliente = CNClienteDal.BuscarPorId(id);
            }
            else
            {
                cliente = new CNCliente(txtCliente.Text, txtTelef1.Text, txtRnc.Text, "");
            }


            Factura factura = cbTipo.SelectedItem?.ToString() == "Contado"
                ? new FacturaContado(cliente)
                : new FacturaCredito(cliente);

            factura.Descripcion = txtDescripcion.Text;
            factura.Precio = precio;
            factura.Cantidad = cantidad;
            factura.AplicarDescuento();
            factura.Fecha = dtpFecha.Value;
            factura.CalcularTotales();

            //TODO captura de exito o error al infresar datos
            int result = FacturaDal.IngresarDatos(factura);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar datos de factura", "Factura guardada con Exito", MessageBoxButtons.OK);


                GenerarFactura();

            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimpiarCampos();
            txtCantidad.Value = 1;
            txtIdCliente.Hide();
            lblId.Hide();
            txtCliente.ReadOnly = false;
            txtTelef1.ReadOnly = false;
            txtRnc.ReadOnly = false;

        }
        private void GenerarFactura()
        {
            var lista = FacturaDal.GenerarFacturas();

            dgvFactura.DataSource = null;
            dgvFactura.DataSource = lista.Select(f => new
            {
                IdFactura = f.IdFactura,
                IdCliente = f.Cliente?.IdCliente > 0 ? f.Cliente.IdCliente.ToString() : "No registrado",
                Nombre = f.Cliente?.Nombre ?? f.NombreFactura ?? "Desconocido",
                Telefono = f.TelefonoF,
                Rnc = f.RncF,
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
        private void Form1_Load(object sender, EventArgs e)
        {
            GenerarFactura();
            this.WindowState = FormWindowState.Maximized;
            //TODO se añaden contado y credito para el CB del tipo de factura
            cbTipo.Items.Add("Contado");
            cbTipo.Items.Add("Crédito");
            cbTipo.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Today;
        }

        //TODO Metodo para Limpiar Campos
        private void LimpiarCampos()
        {
            txtCliente.Text = "";
            txtTelef1.Text = "";
            txtRnc.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtIdCliente.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes C = new Clientes();

            C.Show();
            this.Dispose();

        }
        //TODO Envento del boton para buscar clientes registrados por id
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                MessageBox.Show("Por favor ingrese un Id de cliente válido.");
                return;
            }

            CNCliente cliente = CNClienteDal.BuscarPorId(idCliente);

            if (cliente != null)
            {
                txtCliente.Text = cliente.Nombre;
                txtTelef1.Text = cliente.Telefono;
                txtRnc.Text = cliente.RNC;
                txtCliente.Tag = cliente; // Guarda el cliente para usarlo al facturar
            }
            else
            {
                MessageBox.Show("Cliente no encontrado.");
            }
            btnBuscarC2.Show();
            txtCliente.ReadOnly = true;
            txtTelef1.ReadOnly = true;
            txtRnc.ReadOnly = true;

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal MP = new MenuPrincipal();
            MP.BringToFront();
            this.Dispose();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //TODO Permitir  que el usuario solo pueda usar letras, espacios y teclas de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquear la tecla
            }
        }
        //TODO Envento del boton para buscar Facturas por id
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int id))
            {
                MessageBox.Show("Por favor ingrese un Id de factura válido.");
                return;
            }

            Factura factura = FacturaDal.BuscarFacturaPorId(id);

            if (factura != null)
            {
                dgvFactura.DataSource = new[]
                {
                     new
                     {

                         IdFactura = factura.IdFactura,
                         IdCliente = factura.Cliente?.IdCliente > 0 ? factura.Cliente.IdCliente.ToString() : "No registrado",
                         Nombre = factura.Cliente?.Nombre ?? factura.NombreFactura ?? "Desconocido",
                         factura.TelefonoF,
                         factura.RncF,
                         factura.Descripcion,
                         factura.Cantidad,
                         factura.Precio,
                         factura.SubTotal,
                         factura.Descuento,
                         factura.Total,
                         Tipo = factura.TipoFactura(),
                         factura.Fecha
                     }
                };
            }
            else
            {
                MessageBox.Show("No se encontró ninguna factura con ese Id.");
            }
            LimpiarCampos();
            btnBuscarF.Show();
            txtIdCliente.Hide();
            lblId.Hide();
            pbAtras.Show();

        }

        private void txtIdCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btnBuscarC2.Hide();
            txtIdCliente.Show();
            lblId.Show();
            txtIdCliente.Text = "";
            btnBuscarF.Show();
            
        }

        private void btnBuscarF_Click(object sender, EventArgs e)
        {
            btnBuscarF.Hide();
            txtIdCliente.Show();
            lblId.Show();
            txtIdCliente.Text = "";
            btnBuscarC2.Show();
        }

        //TODO evento KeyPress encargado de que nose puedan colocar letras en el precio
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            GenerarFactura();
            pbAtras.Hide();
        }
    }
}
