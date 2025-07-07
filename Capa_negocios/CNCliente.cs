using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    public class CNCliente : CNPersona
    {
        public int IdCliente { get; set; }
        public decimal Descuento { get; set; } = 5;

        public string Correo { get; set; }

        public CNCliente(string nombre, string telefono, string rnc, decimal descuento = 5)
            : base(nombre, telefono, rnc)
        {
            Descuento = descuento;
        }
    }
}
