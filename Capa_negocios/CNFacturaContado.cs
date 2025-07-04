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
        public FacturaContado(CNCliente cliente) : base(cliente) { }

        public override string ObtenerTipoFactura() => "Contado";
    }

}
