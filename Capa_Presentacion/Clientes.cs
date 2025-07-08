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
            this.WindowState = FormWindowState.Maximized;
            Mclientes();
            txtCorreoC.MaxLength = 50;
            txtNombreC.MaxLength = 50;
        }

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreC.Text))
            {
                MessageBox.Show("Error en el campo Nombre.", "Ingrese un Nombre valido", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefC.Text))
            {
                MessageBox.Show("Error en el campo Telefono.", "Ingrese un Telefono valido", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRncC.Text))
            {
                MessageBox.Show("Error en el campo RNC.", "Ingrese un RNC valido", MessageBoxButtons.OK);
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
        }
        private void Mclientes()
        {
            CNClienteDal datos = new CNClienteDal();
            var lista = datos.MostrarClientes();

            dgvClientes.DataSource = lista.Select(c => new
            {
                c.IdCliente,
                c.Nombre,
                c.Telefono,
                c.RNC,
                c.Correo
            }).ToList();
        }
        private void LimpiarCampos()
        {
            txtNombreC.Text = "";
            txtTelefC.Text = "";
            txtRncC.Text = "";
            txtCorreoC.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreC.Text))
                {
                    MessageBox.Show("Error en el campo Nombre.", "Ingrese un Nombre valido", MessageBoxButtons.OK);
                    return;
                }

                throw new Exception("Ha excedido el maximo de 50 caracteres");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el campo Nombre." + ex.Message);
            }

            if (string.IsNullOrWhiteSpace(txtTelefC.Text))
            {
                MessageBox.Show("Error en el campo Telefono.", "Ingrese un Telefono valido", MessageBoxButtons.OK);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtRncC.Text))
            {
                MessageBox.Show("Error en el campo RNC.", "Ingrese un RNC valido", MessageBoxButtons.OK);
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
        }

        private void txtNombreC_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo letras, espacios y teclas de control (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Bloquear la tecla
            }
        }

        private void btnVolverC_Click(object sender, EventArgs e)
        {
          
            this.Dispose();
        }
    }

}
