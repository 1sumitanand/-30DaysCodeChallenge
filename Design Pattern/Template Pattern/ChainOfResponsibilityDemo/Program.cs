using System;


namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // lets create employees 
            CSEDept cse = new CSEDept();
            EEEDept eee = new EEEDept();

            //It will call process from Hiring Process
            Console.WriteLine(":::: Hiring Process for CSE Dept ::::");
            cse.GetFreshers();

            // It will call only selecetd process from EEE Dept
            Console.WriteLine(":::: Hiring Process for EEE Dept  ::::");
            eee.FirstRound();
            eee.HRRound();

            Console.ReadLine();

        }
    }
}
