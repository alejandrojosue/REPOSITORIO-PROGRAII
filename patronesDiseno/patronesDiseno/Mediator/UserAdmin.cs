using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Mediator
{
    public class UserAdmin:IColleague
    {
        public UserAdmin(IMediator mediator) : base(mediator)
        {

        }
        public override void receive(string message)
        {
            Console.WriteLine($"Un administrador recibe: {message}");
        }
    }
}
