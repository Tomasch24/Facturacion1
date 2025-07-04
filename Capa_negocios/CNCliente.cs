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
        public decimal Descuento { get; set; }

        public string Correo { get; set; }

        public CNCliente(string nombre, string telefono, string rnc, decimal descuento)
            : base(nombre, telefono, rnc)
        {
            Descuento = descuento;
        }

        public override string ObtenerIdentificacion()
        {
            return $"Cliente RNC: {RNC}";
        }
    }
}
