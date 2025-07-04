using capa_negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    public static class CNMemoriaTemporal
    {
        public static List<Factura> FacturasGeneradas { get; } = new List<Factura>();
    }
}
