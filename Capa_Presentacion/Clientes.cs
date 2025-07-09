using capa_negocios;
using Capa_negocios;
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
            if (idClienteEditando == null)
            {
                // Registrar nuevo cliente
                CNCliente cliente = new CNCliente(
                    txtNombreC.Text.Trim(),
                    txtTelefC.Text.Trim(),
                    txtRncC.Text.Trim()
                )
                {
                    Correo = txtCorreoC.Text.Trim()
                };
                
                CNClienteDal datos = new CNClienteDal();
                int resultado = datos.InsertarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente registrado correctamente.");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al registrar el cliente.");
                }
                LimpiarCampos();
            }
            else
            {
                // Editar cliente existente
                CNCliente cliente = new CNCliente(
                    txtNombreC.Text.Trim(),
                    txtTelefC.Text.Trim(),
                    txtRncC.Text.Trim()
                )
                {
                    IdCliente = idClienteEditando.Value,
                    Correo = txtCorreoC.Text.Trim()
                };

                CNClienteDal datos = new CNClienteDal();
                int resultado = datos.InsertarCliente(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Cliente actualizado correctamente.");
                    idClienteEditando = null;
                    btnGuardarC.Text = "Registrar";
                    btnGuardarC.BackColor = Color.MediumSeaGreen;
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el cliente.");
                }
                LimpiarCampos();
            }

           
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
        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un Cliente para editar.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas editar los datos del Cliente seleccionado?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
            {
                return; // Si el usuario cancela, no hace nada, el return hace que se salga del metodo
                //si el usuario presiona No, no se ejecuta el resto del código, si presiona Si, se continua con el resto del código
            }

            DataGridViewRow fila = dgvClientes.SelectedRows[0]; //esto obtiene la fila seleccionada en el DataGridView

            idClienteEditando = Convert.ToInt32(fila.Cells["IdCliente"].Value);

            txtNombreC.Text = fila.Cells["Nombre"].Value.ToString();
            txtTelefC.Text = fila.Cells["Telefono"].Value.ToString();
            txtRncC.Text = fila.Cells["RNC"].Value.ToString();
  
            txtCorreoC.Text = fila.Cells["Correo"].Value?.ToString();




            /*
           btnEditar.Width = 253;
            btnEditar.Text = "Guardar cambios"; // Cambia el texto del botón
            btnEditar.BackColor = Color.SkyBlue;
        
            if (dgvClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un cliente para editar.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas editar este cliente?",
                "Confirmar Edición",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.No)
                return;

            // Obtener la fila seleccionada
            DataGridViewRow fila = dgvClientes.SelectedRows[0];

            // Extraer el ID del cliente
            int idCliente = Convert.ToInt32(fila.Cells["IdCliente"].Value);

            // Buscar el cliente por ID desde base de datos
            CNClienteDal C = new CNClienteDal();
            CNCliente cliente = C.BuscarClientePorId(idCliente);

            if (cliente == null)
            {
                MessageBox.Show("El cliente no fue encontrado en la base de datos.");
                return;
            }

            // Abrir el mismo formulario de clientes en modo edición
            Clientes frmEditar = new Clientes(cliente);

            if (frmEditar.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cliente actualizado correctamente.");
                CargarClientes(); // Refrescar DataGridView
            }
        
         /* try
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
          }*/
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //metodo para eliminar empleado
            /*public void EliminarEmpleado(int idEmpleado)
              {
              using (SqlConnection conn = conexion.ObtenerConexion())
              {
                  conn.Open();
                  string query = "DELETE FROM Empleados WHERE ID = @ID";
                  using (SqlCommand cmd = new SqlCommand(query, conn))
                  {
                      cmd.Parameters.AddWithValue("@ID", idEmpleado);
                      cmd.ExecuteNonQuery();
                  }
                }
            public void EditarEmpleado(Empleado empleado)
          {
              using (SqlConnection conn = conexion.ObtenerConexion())
              {
                  conn.Open();
                  string query = "UPDATE Empleados SET Nombre = @Nombre, Cedula = @Cedula, Cargo = @Cargo, Sueldo = @Sueldo, " +
                      "Fecha_Ingreso = @Fecha_Ingreso WHERE ID = @ID";

                  using (SqlCommand cmd = new SqlCommand(query, conn))
                  {
                      cmd.Parameters.AddWithValue("@ID", empleado.ID);
                      cmd.Parameters.AddWithValue("@Nombre", empleado.Nombre);
                      cmd.Parameters.AddWithValue("@Cedula", empleado.Cedula);
                      cmd.Parameters.AddWithValue("@Cargo", empleado.Cargo);
                      cmd.Parameters.AddWithValue("@Sueldo", empleado.Sueldo);
                      cmd.Parameters.AddWithValue("@Fecha_Ingreso", empleado.Fecha_Ingreso);
                      cmd.ExecuteNonQuery();
                  }
              }
          }*/
        }
    }
    

}
