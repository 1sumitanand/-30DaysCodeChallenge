using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCSharp
{
    //Uncomment for each Class and run seperately

    //class WageraWagera
    //{
    //    public List<Shape> _Shapes = new List<Shape>();

    //    WageraWagera()
    //    {
    //        Console.WriteLine(":: Initialization through List Population ::");
    //        _Shapes.Add(new Circle("Circle"));
    //        _Shapes.Add(new Rectangle("Rectangle"));
    //    }

    //    public void CheckConditionAndPassMethod()
    //    {
    //        var temp = _Shapes.FirstOrDefault(x => x.AbstarctShapeType == "Circle");
    //        temp?.ShowShape(temp.AbstarctShapeType);
    //    }

    //    static void Main(string[] args)
    //    {
    //        //One way of calling abstract methods when only one class needs to called
    //        //Shape sh = new Circle() ;
    //        //sh.ShowShape("Circle");

    //        //Initialize Base Class for list to load
    //        WageraWagera bs = new WageraWagera();
    //        bs.CheckConditionAndPassMethod();

    //        //Create a list and check items there
    //        Console.ReadKey();
    //    }
    //}

    //public abstract class Shape
    //{
    //    public String AbstarctShapeType;
    //    public abstract void ShowShape(String Shapetemplate);
    //}

    //public class Circle : Shape
    //{
    //    public Circle(String Shapetemplate)
    //    {
    //        AbstarctShapeType = Shapetemplate;
    //        Console.WriteLine(AbstarctShapeType + " Constructer Initialization");
    //    }

    //    public override void ShowShape(String Shapetemplate)
    //    {
    //        Console.WriteLine(Shapetemplate + " Class Method");
    //    }
    //}

    //public class Rectangle : Shape
    //{
    //    public Rectangle(String Shapetemplate)
    //    {
    //        AbstarctShapeType = Shapetemplate;
    //        Console.WriteLine(AbstarctShapeType + " Constructer Initialization");
    //    }

    //    public override void ShowShape(String Shapetemplate)
    //    {
    //        Console.WriteLine(Shapetemplate + " Class Method");
    //    }
    //}


}
