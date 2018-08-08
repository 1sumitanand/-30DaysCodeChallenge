using System;

namespace TemplatePattern
{
    class EEEDept : HiringProcess
    {
        public override void FirstRound()
        {
            Console.WriteLine("First Round conducted in EEE dept");
        }

        public override void TechnicalInterview()
        {
            Console.WriteLine("Technical Interview conducted in EEE dept");
        }

    }
}
