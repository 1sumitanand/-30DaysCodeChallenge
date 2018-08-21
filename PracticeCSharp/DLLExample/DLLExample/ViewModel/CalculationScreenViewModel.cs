using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenerateDLL;
using System.Windows.Input;
using System.ComponentModel;

namespace DLLExample.ViewModel
{
    internal class CalculationScreenViewModel : INotifyPropertyChanged
    {
        private Calculation cs;
        public CalculationScreenViewModel()
        {
            cs = new Calculation();
        }

        #region Input Numbers

        private double _input1;
        public double Input1
        {
            get { return _input1; }
            set { _input1 = value; NotifyPropertyChanged("Input1"); }
        }

        private double _input2;
        public double Input2
        {
            get { return _input2; }
            set { _input2 = value; NotifyPropertyChanged("Input2"); }
        }

        #endregion

        #region Addition
        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new CommandHandler(() => PerformAdd(), true);
                }
                return _addCommand;
            }
        }

        public void PerformAdd()
        {
            //Add
            Result = cs.Add(Input1, Input2);
        }
        #endregion

        #region Subtraction
        private ICommand _subCommand;
        public ICommand SubCommand
        {
            get
            {
                if (_subCommand == null)
                {
                    _subCommand = new CommandHandler(() => PerformSub(), true);
                }
                return _subCommand;
            }
        }

        public void PerformSub()
        {
            //Add
            Result = cs.Subtract(Input1, Input2);
        }
        #endregion

        private double _result;
        public double Result
        {
            get { return _result; }
            set { _result = value; NotifyPropertyChanged("Result"); }
        }

        #region Notify Change
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion

    }
}
