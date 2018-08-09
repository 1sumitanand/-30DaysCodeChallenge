using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ContextHandler
    {
        BaseAlgorithm baseAlgorithm;

        ContextHandler(BaseAlgorithm bsAlgo)
        {
            this.baseAlgorithm = bsAlgo;
        }

        public void SetClassContext()
        {
            baseAlgorithm.AlgorithmImplementation();
        }
    }
}
