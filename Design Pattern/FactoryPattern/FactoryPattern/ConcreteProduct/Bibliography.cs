﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreteProduct
{
    class Bibliography : Page
    {
        public override void PageType()
        {
            Console.WriteLine("This is Bibliography Page");
        }
    }
}
