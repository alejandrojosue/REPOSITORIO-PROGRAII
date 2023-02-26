using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Mediator
{
    public  interface IMediator
    {
         void send(string message, IColleague colleague);
    }
}
