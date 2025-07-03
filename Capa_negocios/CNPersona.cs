using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_negocios
{
    public abstract class CNPersona
    {
        public string Nombre { get; set; }
        public CNPersona(string nombre)
        {
            Nombre = nombre;
        }



    }
}
