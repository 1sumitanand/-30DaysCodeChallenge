
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOAD.Algorithm
{
    class HelloWorldAlgo : IAlgorithm
    {
        public string Name
        {
            get
            {
                return "Hello World";
            }
        }

        public void Execute()
        {
            System.Windows.MessageBox.Show("I am Hello world algo");
        }
    }
}
