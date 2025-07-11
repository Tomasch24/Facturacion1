using capa_negocios;
using Capa_negocios;
using capa_presentacion;
using ConexionDatos;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Presentacion
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            lblIdC.Hide();
            txtIdClienteC.Hide();
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            dgvClientes.ColumnHeadersDefaultCellStyle.BackColor = Color.Aqua;
            this.WindowState = FormWindowState.Maximized;
            Mclientes();
            txtCorreoC.MaxLength = 50;
            txtNombreC.MaxLength = 50;
        }

        //TODO evento boton guardar cliente

        private void btnGuardarC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreC.Text))
            {
                MessageBox.Show("Error en el campo Nombre.", "Ingrese un Nombre valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!txtTelefC.MaskCompleted)
            {
                MessageBox.Show("El campo Teléfono está incompleto.", "Favor completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!txtRncC.MaskCompleted)
            {
                MessageBox.Show("El campo RNC está incompleto.", "Favor completar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                 

                if (string.IsNullOrWhiteSpace(txtCorreoC.Text))
                    throw new Exception("El campo de correo está vacío.");

                if (!txtCorreoC.Text.Contains("@") || !txtCorreoC.Text.Contains("."))
                    throw new Exception("Formato de correo inválido." + "\nFavor usar una direccion de correo valida: usuario@ejemplo.com");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en el correo electrónico", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            CNCliente cliente = new CNCliente(txtNombreC.Text.Trim(), txtTelefC.Text.Trim(), txtRncC.Text.Trim(), txtCorreoC.Text.Trim());

            cliente.Correo = txtCorreoC.Text.Trim();
            

            CNClienteDal datos = new CNClienteDal();
            int resultado;

            if (idClienteEditando != null)
            {
                //TODO Modo edición
                cliente.IdCliente = idClienteEditando.Value;
                resultado = datos.EditarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }

                // Restaurar modo normal del botón
                idClienteEditando = null;
                btnGuardarC.Text = "Registrar";
                btnGuardarC.BackColor = Color.Gainsboro;

            }
            else
            {
                // Modo creación
                resultado = datos.InsertarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente registrado correctamente.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el cliente.");
                }
            }

            // Refrescar, limpiar y reiniciar
            Mclientes();
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
        private int? idClienteEditando = null;
        //TODO Evento para editar clientes
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para editar.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "¿Estás seguro de que deseas editar los datos del cliente seleccionado?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            DataGridViewRow fila = dgvClientes.SelectedRows[0];
            idClienteEditando = Convert.ToInt32(fila.Cells["IdCliente"].Value); // Guardar ID del cliente para saber que se está editando

            // Llenar los campos del formulario con los datos seleccionados
            txtNombreC.Text = fila.Cells["Nombre"].Value.ToString();
            txtTelefC.Text = fila.Cells["Telefono"].Value.ToString();
            txtRncC.Text = fila.Cells["RNC"].Value.ToString();
            txtCorreoC.Text = fila.Cells["Correo"].Value?.ToString();

            // Cambiar el texto y estilo del botón Guardar para indicar "modo edición"
            btnGuardarC.Text = "Guardar Cambios";
            btnGuardarC.BackColor = Color.SkyBlue;
            btnGuardarC.ForeColor = Color.Black;



            // LimpiarCampos();
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
            MenuPrincipal MP = new MenuPrincipal();
            MP.BringToFront();
            this.Dispose();
        }
        //TODO Evento boton Eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No) return;

            // Obtener el ID del cliente seleccionado en el DataGridView
            int idClienteSelec = Convert.ToInt32(dgvClientes.SelectedRows[0].Cells["IdCliente"].Value);

            // Llamar a la lógica de datos para eliminar el cliente
            CNClienteDal datos = new CNClienteDal();
            int eliminado = datos.EliminarCliente(idClienteSelec);

            if (eliminado > 0)
            {
                MessageBox.Show("Cliente eliminado correctamente.");
                Mclientes(); // Refrescar el listado
                LimpiarCampos(); // Limpiar los campos si alguno estaba cargado
            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Facturacion F = new Facturacion();
            F.Show();
            this.Dispose();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        //TODO Evento boton para buscar clientes por id
        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIdClienteC.Text, out int id))
            {
                MessageBox.Show("Por favor ingrese un Id de factura válido.");
                return;
            }

            CNCliente cliente = CNClienteDal.BuscarPorId(id);

            if (cliente != null)
            {
                dgvClientes.DataSource = new[]
                {
                    new
                    {

                        cliente.IdCliente,
                        cliente.Nombre,
                        cliente.Telefono,
                        cliente.RNC,
                        cliente.Correo
                    }
                };



            }
            else
            {
                MessageBox.Show("No se encontró ninguna factura con ese Id.");
            }
            btnBuscarC2.Show();
            lblIdC.Hide();
            txtIdClienteC.Hide();
            pbAtras.Show();
        }

        private void btnBuscarC2_Click(object sender, EventArgs e)
        {
            btnBuscarC2.Hide();
            lblIdC.Show();
            txtIdClienteC.Show();
            txtIdClienteC.Text = "";
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            Mclientes();
            pbAtras.Hide();
        }
    }


}
