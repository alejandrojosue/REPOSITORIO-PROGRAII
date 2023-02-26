using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.FactoryMethod
{
    internal class vinoTinto : bebidaEmbriagante
    {
        public override int CuantoEmbriagaPorHora => 20;
    }
}
