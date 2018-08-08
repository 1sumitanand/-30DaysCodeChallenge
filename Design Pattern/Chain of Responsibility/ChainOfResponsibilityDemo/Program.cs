using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            // lets create employees 
            TeamLead Sumit = new TeamLead();
            ProjectManager Kannan = new ProjectManager();
            HR Megha = new HR();

            // Now lets set the hierarchy of employees
            Sumit.Supervisor = Kannan;
            Kannan.Supervisor = Megha;

            // Now lets apply 05 day leave with ID 0010 and get approved by TeamLead
            Sumit.ApplyLeave(new Leave(00100, 5));

            // Now lets apply 15 day leave with ID 0020 and get approved by Project Manager
            Sumit.ApplyLeave(new Leave(00200, 15));

            // Now lets apply 25 day leave with ID 0030 and get approved by HR
            Sumit.ApplyLeave(new Leave(00300, 25));

            // Now lets apply 35 day leave with ID 0040 and it will not get approved
            Sumit.ApplyLeave(new Leave(00400, 35));

            Console.ReadLine();

        }
    }
}
