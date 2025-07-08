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
            GenerarFactura();
            txtCliente.MaxLength = 50;
            txtDescripcion.MaxLength = 80;
            dtpFecha.Enabled = false;
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

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) )
            {
                MessageBox.Show("Error en el campo Precio.", "Ingrese un Precio valido", MessageBoxButtons.OK);
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad))
            {
                MessageBox.Show("Error en el campo Cantidad.", "Ingrese una Cantidad valida", MessageBoxButtons.OK);
                return;
            }

            var cliente = new CNCliente(txtCliente.Text, txtTelef1.Text, txtRnc.Text);

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

                CNMemoriaTemporal.FacturasGeneradas.Add(factura);
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
                }).ToList();

            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar");
            }

            LimpiarCampos();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //TODO se añaden contado y credito para el CB del tipo de factura
            cbTipo.Items.Add("Contado");
            cbTipo.Items.Add("Crédito");
            cbTipo.SelectedIndex = 0;
        }



        //TODO Metodo Generar Factura (Aqui esta)
        private void GenerarFactura()
        {
            FacturaDatos data = new FacturaDatos();
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                SqlDataAdapter adapt;
                conn.Open();

                DataTable dt = new DataTable();

                adapt = new SqlDataAdapter("SELECT * FROM Factura", conn);

                adapt.Fill(dt);

                dgvFactura.DataSource = dt;

                conn.Close();
            }
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

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdCliente.Text, out int idCliente))
            {
                MessageBox.Show("Por favor ingrese un Id válido.");
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
            
            this.Dispose();
        }

        private void txtCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquear la tecla
            }
        }
    }
}
