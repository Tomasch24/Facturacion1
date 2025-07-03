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
        public string Telefono { get; set; }
        public string RNC { get; set; }
        public string Descuento { get; set; }

        public CNCliente(string nombre, string telefono, string rnc, string descuento)
            : base(nombre)
        {
            Telefono = telefono;
            RNC = rnc;
            Descuento = descuento;
        }
    }
}
