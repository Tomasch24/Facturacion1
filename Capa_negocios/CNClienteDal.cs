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
                string query = "INSERT INTO Cliente (Nombre, Telefono, RNC, Correo, Descuento) VALUES (@Nombre, @Telefono, @RNC, @Correo, @Descuento)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@RNC", cliente.RNC);
                cmd.Parameters.AddWithValue("@Correo", cliente.Correo);
                cmd.Parameters.AddWithValue("@Descuento", cliente.Descuento);

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
    }
}
