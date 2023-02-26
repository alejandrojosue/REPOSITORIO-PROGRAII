using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.FactoryMethod
{
    internal class cerveza:bebidaEmbriagante

    {
        public override int CuantoEmbriagaPorHora => 5;
    }
}
