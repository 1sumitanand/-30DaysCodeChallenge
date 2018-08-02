using LearnOOAD.Algorithm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnOOAD
{
    public class MainViewModel
    {
        private readonly Model _AppModel;
        private readonly ObservableCollection<IAlgorithm> _Algorithms;
        public MainViewModel()
        {
            _AppModel = new Model();

            _Algorithms = new ObservableCollection<IAlgorithm>(_AppModel.Algorithms);
        }

        public ObservableCollection<IAlgorithm> Algorithms
        {
            get
            {
                return _Algorithms;
            }
        }
    }
}