using capa_negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    public class FacturaCredito : Factura
    {
        public FacturaCredito(CNCliente cliente) : base(cliente) { }

        public override string ObtenerTipoFactura() => "Crédito";
    }
}
