using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class HiringProcess
    {
        public void GetFreshers()
        {
            FirstRound();
            GroupDiscussion();
            TechnicalInterview();
            HRRound();
        }

        public abstract void FirstRound();
        public void GroupDiscussion()
        {
            Console.WriteLine("Common Group Discussion");
        }
        public abstract void TechnicalInterview();
        public void HRRound()
        {
            Console.WriteLine("Common HR Discussion");
        }

    }
}
