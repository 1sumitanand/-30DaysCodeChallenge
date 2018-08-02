using LearnOOAD.Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearnOOAD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Should be handled as event trigger, for simplicity handled as event handler
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.AddedItems?.Count > 0)
            {
                IAlgorithm algo = e.AddedItems[0] as IAlgorithm;
                algo?.Execute();
            }
        }
    }
}
