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
            MDTGV();
            GenerarFactura();
            txtCliente.MaxLength = 50;
            txtDescripcion.MaxLength = 80;
            dtpFecha.Enabled = false;
        }
        public void MDTGV()
        {
            FacturaDatos datos = new FacturaDatos();
            SqlConnection conn = new SqlConnection(datos.conexion);
            SqlDataAdapter adapt;
        }
        //TODO Evento del boton guardar para insertar los datos a la base de datos
        private void button1_Click(object sender, EventArgs e)
        {

            // Validaciones
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Error en el campo Cliente.", "Ingrese un Nombre valido", MessageBoxButtons.OK);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Error en el campo Descripcion.", "Ingrese una Descripcion de producto valida", MessageBoxButtons.OK);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Error en el campo Precio.", "Ingrese un Precio valido", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Error en el campo Cantidad.", "Ingrese una Cantidad valida", MessageBoxButtons.OK);
                return;
            }
            CNCliente cliente;
            if (int.TryParse(txtIdCliente.Text, out int id))
            {
                cliente = CNClienteDal.BuscarPorId(id);
            }
            else
            {
                cliente = new CNCliente(txtCliente.Text, txtTelef1.Text, txtRnc.Text);
            }

            //var cliente = new CNCliente(txtCliente.Text, txtTelef1.Text, txtRnc.Text);

            Factura factura = cbTipo.SelectedItem?.ToString() == "Contado"
                ? new FacturaContado(cliente)
                : new FacturaCredito(cliente);

            factura.Descripcion = txtDescripcion.Text;
            factura.Precio = precio;
            factura.Cantidad = cantidad;
            factura.AplicarDescuentoSiCorresponde();
            factura.Fecha = dtpFecha.Value;
            factura.CalcularTotales();

            //TODO captura de exito o error al infresar datos
            int result = FacturaDal.IngresarDatos(factura);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar datos de factura");

                /* CNMemoriaTemporal.FacturasGeneradas.Add(factura);
                 dgvFactura.DataSource = null;
                 dgvFactura.DataSource = CNMemoriaTemporal.FacturasGeneradas.Select(f => new
                 {

                     IdCliente = f.Cliente?.IdCliente > 0 ? f.Cliente.IdCliente.ToString() : "Cliente no registrado",
                     f.Cliente.Nombre,
                     f.Descripcion,
                     f.Cantidad,
                     f.Precio,
                     f.SubTotal,
                     f.Descuento,
                     f.Total,
                     Tipo = f.TipoFactura(),
                     f.Fecha
                 }).ToList();*/
                GenerarFactura();

            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar");
            }

            LimpiarCampos();


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
            dtpFecha.MinDate = DateTime.Today;
            dtpFecha.MaxDate = DateTime.Now;
        }

        //TODO Metodo para Limpiar Campos
        private void LimpiarCampos()
        {
            txtCliente.Text = "";
            txtTelef1.Text = "";
            txtRnc.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clientes C = new Clientes();

            C.Show();
            this.Dispose();

        }

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
        }
    }
}
