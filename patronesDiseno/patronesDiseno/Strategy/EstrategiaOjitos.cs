using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Strategy
{
    internal class EstrategiaOjitos:IBorracho
    {
        public void conquistar()
        {
            Console.WriteLine("Le hago ojitos a la muchacha");
        }
    }
}
