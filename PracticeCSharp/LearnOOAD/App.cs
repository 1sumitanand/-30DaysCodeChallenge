using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LearnOOAD
{
    class App : Application
    {
        [STAThread]
        static void Main(string[] args)
        {
            App aApp = new App();
            MainWindow win = new MainWindow();
            MainViewModel mainVM = new MainViewModel();
            win.DataContext = mainVM;
            aApp.Run(win);
        }
    }
}
