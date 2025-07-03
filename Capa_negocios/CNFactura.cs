using System;
using System.Data;
using System.Runtime.CompilerServices;
using Capa_negocios;
using ConexionDatos;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace capa_negocios
{
    public class Factura
    {
        public CNCliente Cliente { get; set; }
        public int? IdCliente => Cliente?.IdCliente;
        public DateTime Fecha { get; set; } = DateTime.Now;
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal => Precio * Cantidad;
        public decimal Descuento { get; private set; }
        public decimal Total { get; private set; }
        public virtual string Tipo { get; set; }

        public Factura(CNCliente cliente)
        {
            Cliente = cliente ?? throw new ArgumentNullException(nameof(cliente));
        }

        public void CalcularTotal()
        {
            if (decimal.TryParse(Cliente.Descuento, out decimal porcentaje))
                Descuento = SubTotal * (porcentaje / 100);
            else
                Descuento = 0;

            Total = SubTotal - Descuento;
        }
    }
}


