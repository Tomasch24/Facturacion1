using System;
using System.Data;
using System.Runtime.CompilerServices;
using Capa_negocios;
using ConexionDatos;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace capa_negocios
{
    public abstract class Factura
    {
        public CNCliente Cliente { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; } // = DateTime.Now;

        public decimal SubTotal => Precio * Cantidad;
        public decimal Descuento { get; protected set; }
        public decimal Total { get; protected set; }

        protected Factura(CNCliente cliente)
        {
            Cliente = cliente;
        }

        public virtual void CalcularTotales()
        {
            Descuento = SubTotal * (Cliente.Descuento / 100);
            Total = SubTotal - Descuento;
        }

        public abstract string ObtenerTipoFactura(); // Método abstracto
    }
}


