using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    //Concrete Creator Base class
    abstract class Document
    {
   
        // Constructor calls abstract Factory method
        public Document()
        {
            this.CreatePages();
        }

        //List of Concrete Product classes
        private List<Page> _pages = new List<Page>();
        public List<Page> Pages
        {
            get { return _pages; }
        }

        // Factory Method
        public abstract void CreatePages();
    }
}
