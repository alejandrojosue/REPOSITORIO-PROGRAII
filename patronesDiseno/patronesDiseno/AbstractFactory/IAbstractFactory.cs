﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patronesDiseno.AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();

        IAbstractProductB CreateProductB();
    }
}
