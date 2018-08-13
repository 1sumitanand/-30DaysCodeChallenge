using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.ConcreteProduct
{
    class Experience : Page
    {
        public override void PageType()
        {
            Console.WriteLine("This is Experience Page");
        }
    }
}
