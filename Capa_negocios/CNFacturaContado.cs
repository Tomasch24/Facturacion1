using capa_negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    public class FacturaContado : Factura
    {
        public FacturaContado(Factura factura)
        {

        }
        //TODO Se utiliza el "override" para sobrescribir el tipo
        public override string Tipo => "Contado";
    }
}
