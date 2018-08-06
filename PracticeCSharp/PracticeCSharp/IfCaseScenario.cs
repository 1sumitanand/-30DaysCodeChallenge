using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    /// <summary>
    /// In this Code we will learn about resolving different if-case sceanario in case of one line statement for if condition
    /// For all if take any one dictionary and initialize map the Key Value  
    /// </summary>
    class WageraWagera
    {
        WageraWagera(Baseclass bcObj)
        {
            //Old Way
            Obj = bcObj;
            ListAddition(Obj);

            //New Way
            ListAddition2();
        }

        #region Old Code -- To be Refacor
        public List<Baseclass> _Names = new List<Baseclass>();
        private static Baseclass Obj;
        //We have to refactor this method
        public void ListAddition(Baseclass bcObj)
        {
            //In Each if else Sceanario we are adding new object of each class in a list.
            if (bcObj is A)
                _Names.Add(new A());
            if (bcObj is B)
                _Names.Add(new B());
            //Can be n munber of if case Sceanario

        }
        #endregion

        #region New Code -- way to Refacor
        public List<Baseclass> _ClassNames = new List<Baseclass>();
        private Dictionary<object, Baseclass> _VMMapper;
        //We have to refactor this method
        public void ListAddition2()
        {
            //Just to hold any refernce to check against any type Class.
            Baseclass CviewModel = new A();
            //Initialize dictionary but make sure it get initialize only once.
            IntializeDictionary();
            //Instead of multiple if reduce it to one line by linq expression and check against typeclass(CviewModel)
            var matchedvalue = _VMMapper.FirstOrDefault(x => x.Key.Equals(CviewModel.GetType())).Value;
            //Finally which key get match take the value and add it to list.
            _ClassNames.Add(matchedvalue);

        }
        private void IntializeDictionary()
        {
            _VMMapper = new Dictionary<object, Baseclass>();
            _VMMapper.Add(typeof(A), (new A()));
            _VMMapper.Add(typeof(B), (new B()));
        }
        #endregion

        static void Main()
        {
            //Just for Object Initialization
            var AObj = new A();
            var BObj = new B();

            var bs = new WageraWagera(AObj);
            bs.ListAddition(Obj);

            //Refactored method
            bs.ListAddition2();

            //Create a list and check items there
            Console.ReadKey();
        }
    }

    public class Baseclass
    {
        public void Method1()
        {
            Console.WriteLine("This is Base Class");
        }
    }

    public class A : Baseclass
    {
        public A()
        { Method1(); }
    }

    public class B : Baseclass
    {
        public B()
        { Method1(); }
    }

}
