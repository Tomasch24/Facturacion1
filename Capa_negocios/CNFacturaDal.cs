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
                string query = "INSERT INTO Factura (IdCliente, Nombre, Telefono, RNC, Fecha, Descripcion, Precio, Cantidad, Tipo)" +
                                 "VALUES (@IdCliente, @Nombre, @Telefono, @RNC, @Fecha, @Descripcion, @Precio, @Cantidad, @Tipo)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@IdCliente", factura.Cliente?.IdCliente > 0 ? factura.Cliente.IdCliente : (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Nombre", factura.Cliente.Nombre);
                cmd.Parameters.AddWithValue("@Telefono", factura.Cliente.Telefono);
                cmd.Parameters.AddWithValue("@RNC", factura.Cliente.RNC);
                cmd.Parameters.AddWithValue("@Fecha", factura.Fecha);
                cmd.Parameters.AddWithValue("@Descripcion", factura.Descripcion);
                cmd.Parameters.AddWithValue("@Precio", factura.Precio);
                cmd.Parameters.AddWithValue("@Cantidad", factura.Cantidad);
                cmd.Parameters.AddWithValue("@Tipo", factura.TipoFactura());

                retorna = cmd.ExecuteNonQuery();

                conn.Close();
            }
            return retorna;
        }
        public static Factura BuscarFacturaPorId(int idFactura)
        {
            FacturaDatos data = new FacturaDatos();

            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                conn.Open();
                string query = "SELECT * FROM Factura WHERE IdFactura = @IdFactura";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdFactura", idFactura);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Buscar cliente si aplica
                    CNCliente cliente = null;
                    if (reader["IdCliente"] != DBNull.Value)
                    {
                        int idCliente = Convert.ToInt32(reader["IdCliente"]);
                        cliente = CNClienteDal.BuscarPorId(idCliente);
                    }

                    // Determinar tipo de factura
                    string tipo = reader["Tipo"].ToString();
                    Factura factura = tipo == "Contado"
                        ? new FacturaContado(cliente)
                        : new FacturaCredito(cliente);

                    factura.IdFactura = idFactura;
                    factura.NombreFactura = reader["Nombre"].ToString(); // ← directamente desde la tabla Factura
                    factura.Descripcion = reader["Descripcion"].ToString();
                    factura.Precio = Convert.ToDecimal(reader["Precio"]);
                    factura.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                    factura.Fecha = Convert.ToDateTime(reader["Fecha"]);

                    factura.AplicarDescuentoSiCorresponde();
                    factura.CalcularTotales();

                    return factura;
                }
            }

            return null; // Si no se encuentra
        }
        //TODO Lista para mostrar clientes en el datagridview
        public static List<Factura> GenerarFacturas()
        {
            List<Factura> lista = new();
            FacturaDatos data = new FacturaDatos();

            using (SqlConnection conn = new SqlConnection(data.conexion))
            {
                string query = "SELECT * FROM Factura";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    CNCliente cliente;

                    if (reader["IdCliente"] != DBNull.Value)
                    {
                        int idCliente = Convert.ToInt32(reader["IdCliente"]);
                        cliente = CNClienteDal.BuscarPorId(idCliente);
                    }
                    else
                    {
                        cliente = new CNCliente(
                            reader["Nombre"].ToString(),
                            reader["Telefono"].ToString(),
                            reader["RNC"].ToString()
                        );
                    }

                    Factura factura = reader["Tipo"].ToString() == "Contado"
                        ? new FacturaContado(cliente)
                        : new FacturaCredito(cliente);

                    factura.IdFactura = Convert.ToInt32(reader["IdFactura"]);
                    factura.Descripcion = reader["Descripcion"].ToString();
                    factura.Precio = Convert.ToDecimal(reader["Precio"]);
                    factura.Cantidad = Convert.ToInt32(reader["Cantidad"]);
                    factura.Fecha = Convert.ToDateTime(reader["Fecha"]);
                    factura.AplicarDescuentoSiCorresponde();
                    factura.CalcularTotales();

                    lista.Add(factura);
                }
            }

            return lista;
        }

    }
}
