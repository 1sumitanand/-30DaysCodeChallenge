
using LearnOOAD.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOAD
{
    public class Model
    {
        private readonly List<IAlgorithm> _AlgoList;
        public Model()
        {
            _AlgoList = new List<IAlgorithm>();

            _AlgoList.Add(new HelloWorldAlgo());
            _AlgoList.Add(new GuessWhoAlgo());
        }

        public IReadOnlyCollection<IAlgorithm> Algorithms
        {
            get
            {
                return _AlgoList.AsReadOnly();
            }
        }
    }
}