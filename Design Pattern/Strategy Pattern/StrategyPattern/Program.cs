using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Have Base Reference and Create Object of Class
            BaseAlgorithm bubbleSort = new BubbleSort();
            bubbleSort.AlgorithmImplementation();

            BaseAlgorithm quickSort = new QuickSort();
            quickSort.AlgorithmImplementation();

            //The other way of having this is by creating a Dictionary and in it's values initilize object of each class
            //Have one property as abstract overridden in each sub handlers defined with unique name.
            //In this way we can have a Class Initialzation in dictionary itself and we dont have to create seperate Class as ContextHandlers
            //Please refer my Runtime Polymorphism example for more details.

            Console.ReadKey();
        }
    }
}
