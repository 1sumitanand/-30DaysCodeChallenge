using FactoryPattern.ConcreteCreator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            Console.Write("\n :: Create pages(object of classes) based on User Choice from menu ::");

            //2nd Approach
            Document documentfactory = null;
            Console.Write("\n  Enter the page type you would like to visit in 1 or 2: ");
            string doctype = Console.ReadLine();

            switch (doctype.ToLower())
            {
                //From factory method will take up the list of classes added in a list 
                case "1":
                    documentfactory = new Resume();
                    break;
                case "2": 
                    documentfactory = new Report();
                    break;
                default:
                    break;
            }

            var PagesType = documentfactory.Pages;
            foreach (var pageitem in PagesType)
            {
                Console.WriteLine(pageitem.GetType().Name);
                pageitem.PageType();
            }
            Console.ReadKey();


        }
    }
}
