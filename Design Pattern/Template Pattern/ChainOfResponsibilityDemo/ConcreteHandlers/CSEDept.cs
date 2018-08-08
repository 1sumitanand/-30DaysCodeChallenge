using System;

namespace TemplatePattern
{
    class CSEDept : HiringProcess
    {
        public override void FirstRound()
        {
            Console.WriteLine("First Round conducted in CSE dept");
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Technical Interview conducted in CSE dept");
        }
    }
}
