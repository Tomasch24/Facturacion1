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
    public class CNClienteDal 
    {
        

        public int InsertarCliente(CNCliente cliente)
        {
            int retorna = 0;
            FacturaDatos data = new FacturaDatos();
            //TODO Se abre la conexion
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                //TODO se abre la base de datos
                conn.Open();

                // TODO comando sql para que se guarden los datos que inserte el usuario en la base de datos
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
            /*using var conn = new SqlConnection(conexion);
            using var cmd = new SqlCommand("INSERT INTO Cliente (Nombre, Telefono, RNC, Correo, Descuento) VALUES (@Nombre, @Telefono, @RNC, @Correo, @Descuento)", conn);

            cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
            cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
            cmd.Parameters.AddWithValue("@RNC", cliente.RNC);
            cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
            cmd.Parameters.AddWithValue("@Descuento", cliente.Descuento);

            conn.Open();
            return cmd.ExecuteNonQuery();*/
        }
        public static CNCliente BuscarPorId(int idCliente)
        {
            
            FacturaDatos data = new FacturaDatos();

            //Se abre la conexion
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                conn.Open();//abre la conexion a la base de datos

                string query = "SELECT * From Persona Where IdCliente = @IdCliente";

                //Comando SQL

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCliente", idCliente); // Agrega el parametro de busqueda

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
    }
}
