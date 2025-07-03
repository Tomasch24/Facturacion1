using capa_negocios;
using Capa_negocios;
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
        }
       
       
        
        
        //TODO Evento del boton guardar para insertar los datos a la base de datos
        private void button1_Click(object sender, EventArgs e)
        {
            Factura factura; //= new Factura(txtCliente.Text, txtTelef1.Text, txtRnc.Text, txtDescuento.Text);


            if (cbTipo.SelectedItem.ToString() == "Contado")
                factura = new FacturaContado(txtCliente.Text, txtTelef1.Text, txtRnc.Text, txtDescuento.Text);
            else
                factura = new FacturaCredito(txtCliente.Text, txtTelef1.Text, txtRnc.Text, txtDescuento.Text);

            //TODO Capturas de error para no dejar los campos Cliente y Referencia de Producto en blanco
            try
            {
                factura.Persona.Nombre = txtCliente.Text;

                if (string.IsNullOrWhiteSpace(factura.Persona.Nombre))

                    throw new Exception("Favor ingrese Nombre del Cliente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el campo Cliente. " + ex.Message);
                return;
            }

            try
            {
                factura.Descripcion = txtDescripcion.Text;

                if (string.IsNullOrWhiteSpace(factura.Descripcion))
                {
                    throw new Exception("Favor Coloque una Referencia del Producto.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el campo Referencia de Producto.  " + ex.Message);
                return;
            }

            //TODO Captura de error para solo ingresar numeros en el campo precio

           /* decimal descuento;

            if (!decimal.TryParse(txtDescuento.Text, out descuento))
            {
                MessageBox.Show("El precio ingresado no es válido. Por favor igrese un valor numerico.");
                return;
            }
            factura.Descuento = descuento;*/
            
            decimal precio;

            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio ingresado no es válido. Por favor igrese un valor numerico.");
                return;
            }
            factura.Precio = precio;

            factura.Telefono = txtTelef1.Text;
            factura.Cliente.RNC = txtRnc.Text;
            factura.Fecha = dtpFecha.Value;
            factura.Cantidad = int.Parse(txtCantidad.Text);

            //TODO captura de exito o error al infresar datos
            int result = FacturaDal.IngresarDatos(factura);

            if (result > 0)
            {
                MessageBox.Show("Exito al guardar datos de factura");
            }
            else
            {
                MessageBox.Show("Error 404: el codigo del cerebro del jeifferson de este codigo dejo de compilar");
            }

            GenerarFactura();
            LimpiarCampos();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
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

        }
    }
}
