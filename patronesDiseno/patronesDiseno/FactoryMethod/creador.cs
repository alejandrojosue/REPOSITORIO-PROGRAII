using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.FactoryMethod
{
    internal class creador
    {
        public const int vinoTinto = 1;
        public const int cerveza = 2;

        public static bebidaEmbriagante creadorBebida(int tipo)
        {
            switch (tipo)
            {
                case vinoTinto:
                    return new vinoTinto();
                case cerveza:
                    return new cerveza();
                default:
                    return null;
            }

        }

    }
}
