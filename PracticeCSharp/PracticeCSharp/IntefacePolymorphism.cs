using System;
using System.Collections.Generic;
using System.Linq;

namespace PracticeCSharp
{
    //Uncomment for each Class and run seperately

    //class BaseShape
    //{
    //    public List<IShape> _Shapes = new List<IShape>();

    //    BaseShape()
    //    {
    //        Console.WriteLine(":: Initialization through List Population ::");
    //        _Shapes.Add(new Circle("Circle"));
    //        _Shapes.Add(new Rectangle("Rectangle"));
    //    }

    //    public void CheckConditionAndPassMethod()
    //    {
    //        //1st Way -- Either we can call through by making list
    //        var temp = _Shapes.FirstOrDefault(x => x.AbstractShapeType == "Circle");
    //        temp?.ShowShape(temp.AbstractShapeType);

    //    }

    //    static void Main(string[] args)
    //    {
    //        //One way of calling abstract methods when only one class needs to called
    //        //Shape sh = new Circle() ;
    //        //sh.ShowShape("Circle");

    //        //Initialize Base Class for list to load
    //        BaseShape bs = new BaseShape();
    //        bs.CheckConditionAndPassMethod();

    //        //Create a list and check items there
    //        Console.ReadKey();
    //    }
    //}

    //public interface IShape
    //{
    //    String AbstractShapeType { get; set; }
    //    void ShowShape(String Shapetemplate);
    //}

    //public class Circle : IShape
    //{
    //    public string AbstractShapeType { get; set; }

    //    public Circle(String Shapetemplate)
    //    {
    //        AbstractShapeType = Shapetemplate;
    //        Console.WriteLine(AbstractShapeType + " Constructer Initialization");
    //    }

    //    public void ShowShape(String Shapetemplate)
    //    {
    //        Console.WriteLine(Shapetemplate + " Class Method");
    //    }
    //}

    //public class Rectangle : IShape
    //{
    //    public string AbstractShapeType { get; set; }
    //    public Rectangle(String Shapetemplate)
    //    {
    //        AbstractShapeType = Shapetemplate;
    //        Console.WriteLine(AbstractShapeType + " Constructer Initialization");
    //    }

    //    public void ShowShape(String Shapetemplate)
    //    {
    //        Console.WriteLine(Shapetemplate + " Class Method");
    //    }
    //}

}
