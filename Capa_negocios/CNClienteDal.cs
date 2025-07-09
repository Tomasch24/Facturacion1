using capa_negocios;
using ConexionDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    //TODO Clase CNClienteDal de gestionar los metodos relacionado a los datos de los clientes en la base de datos
    public class CNClienteDal 
    {
        //TODO metodo para insertar clientes a la base de datos
        public int InsertarCliente(CNCliente cliente)
        {
            int retorna = 0;
            FacturaDatos data = new FacturaDatos();
            //Se abre la conexion
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                // se abre la base de datos
                conn.Open();

                // TODO comando sql para que se guarden los datos del cliente en la base de datos
                string query = "INSERT INTO Cliente (Nombre, Telefono, RNC, Correo) VALUES (@Nombre, @Telefono, @RNC, @Correo)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@RNC", cliente.RNC);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo);

                retorna = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return retorna;
        }

        //TODO metodo para buscar los clientes por id   
        public static CNCliente BuscarPorId(int idCliente)
        {
            FacturaDatos data = new FacturaDatos();

            //Se abre la conexion
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                //abre la conexion a la base de datos
                conn.Open();

                //TODO Comando SQL para buscar los clientes por id
                string query = "SELECT * From Cliente Where IdCliente = @IdCliente";


                SqlCommand cmd = new SqlCommand(query, conn);
                // Parametro de busqueda
                cmd.Parameters.AddWithValue("@IdCliente", idCliente); 

                //Ejecuta la consulta
                SqlDataReader reader = cmd.ExecuteReader();

                //Verifica si hay resultados
                if (reader.Read())
                {


                    CNCliente cliente = new CNCliente(
                    reader["Nombre"].ToString(),
                    reader["Telefono"].ToString(),
                   reader["RNC"].ToString());    

                    //Se asignan valores desde la base de datos a los atributos de clase
                    cliente.IdCliente = (int)reader["IdCliente"];
                    cliente.Nombre = reader["Nombre"].ToString();
                    cliente.Telefono = reader["Telefono"].ToString();
                    cliente.RNC = reader["RNC"].ToString(); ;

                    return cliente; //Devuelve la persona encontrada
                }

                return null; //Si no encuentra nada, no devuelve nada
            }
        }

        //TODO Lista para mostrar clientes en el datagridview
        public List<CNCliente> MostrarClientes()
        {
            List<CNCliente> lista = new();

            FacturaDatos data = new FacturaDatos();

            SqlConnection conn = new SqlConnection(data.conexion);
            
            string query = "SELECT * FROM Cliente";

            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CNCliente cliente = new CNCliente(
                    reader["Nombre"].ToString(),
                    reader["Telefono"].ToString(),
                    reader["RNC"].ToString()
                )
                {
                    IdCliente = Convert.ToInt32(reader["IdCliente"]),
                    Correo = reader["Correo"].ToString()
                };

                lista.Add(cliente);
            }

            return lista;
        }

        //TODO Metodo para editar clientes en la base de datos
        public int EditarCliente(CNCliente cliente)
        {
            FacturaDatos data = new FacturaDatos();
            int resultado = 0;

            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                conn.Open();
                //TODO Comando SQL para editar los clientes en la base de datos
                string query = @"UPDATE Cliente  SET Nombre = @Nombre, RNC = @RNC, Telefono = @Telefono, Correo = @Correo   WHERE IdCliente = @IdCliente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente);
                    cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                    cmd.Parameters.AddWithValue("@RNC", cliente.RNC);
                    cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                    cmd.Parameters.AddWithValue("@Correo", cliente.Correo);

                    resultado = cmd.ExecuteNonQuery(); 
                }
            }
            return resultado;
        }

        //TODO metdo para eliminar clientes
        public int EliminarCliente(int idCliente)
        {
            int retorna = 0;
            FacturaDatos data = new FacturaDatos();

            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                conn.Open();

                //TODO comando SQL para eliminar clientes en la base de datos
                string query = "DELETE FROM Cliente WHERE IdCliente = @IdCliente";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    retorna = cmd.ExecuteNonQuery();
                }
            }
            return retorna;
        }
    }
}
