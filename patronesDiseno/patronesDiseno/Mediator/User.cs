﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.Mediator
{
    internal class User : IColleague
    {
        public User(IMediator mediator):base(mediator)
        {

        }
        public override void receive(string message)
        {
            Console.WriteLine($"Un usuario recibe: {message}");

        }
    }
}
