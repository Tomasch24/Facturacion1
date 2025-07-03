using capa_negocios;
using ConexionDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    public class FacturaDal
    {
        //TODO Metodo para ingresar los datos de la factura
        public static int IngresarDatos(Factura factura)
        {
            int retorna = 0;
            FacturaDatos data = new FacturaDatos();
            //TODO Se abre la conexion
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                //TODO se abre la base de datos
                conn.Open();

                // TODO comando sql para que se guarden los datos que inserte el usuario en la base de datos
                string query = "INSERT INTO Factura (IdCliente, Nombre, Telefono, RNC, Fecha, Descripcion, Precio, Cantidad, SubTotal, Descuento, Tipo)" +
                                 "VALUES (@IdCliente, @Nombre, @Telefono, @RNC, @Fecha, @Descripcion, @Precio, @Cantidad, @SubTotal, @Descuento, @Tipo)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdCliente", (object?)factura.IdCliente ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Cliente", factura.Persona.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", factura.Cliente.Telefono);
                cmd.Parameters.AddWithValue("@RNC", factura.Cliente.RNC);
                cmd.Parameters.AddWithValue("@Fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@Descripcion", factura.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", factura.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                cmd.Parameters.AddWithValue("@Tipo", factura.Tipo);

                retorna = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return retorna;
        }

        public void GenerarFactura()
        {
            DataTable dt = new DataTable();

            FacturaDatos data = new FacturaDatos();
            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                SqlDataAdapter adapt;
                conn.Open();
                adapt = new SqlDataAdapter("SELECT * FROM Factura", conn);

                adapt.Fill(dt);

                conn.Close();
            }
        }
    }
}
