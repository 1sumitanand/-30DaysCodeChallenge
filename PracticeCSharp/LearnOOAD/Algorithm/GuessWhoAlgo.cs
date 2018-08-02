
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOAD.Algorithm
{
    class GuessWhoAlgo : IAlgorithm
    {
        public string Name
        {
            get
            {
                return "Guess who !!";
            }
        }

        public void Execute()
        {
            System.Windows.MessageBox.Show("I am Guess who algo");
        }
    }
}