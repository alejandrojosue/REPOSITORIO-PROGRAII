using System;
using System.Collections.Generic;
using System.Text;

namespace patronesDiseno
{
    class DisponibleServerState : ServerState
    {
        public override void Respuesta()
        {
            Console.WriteLine("Respuesta 200");
        }
    }
}
