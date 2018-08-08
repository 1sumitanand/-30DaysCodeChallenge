using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    // This is the actual Item that will be used by the concretehandlers
    // to determine whther they can act upon this request or not
    public class Leave
    {
        public Leave(int leaveid, int days)
        {
            leaveID = leaveid;
            numberOfDays = days;
        }

        int leaveID;
        public int LeaveID
        {
            get { return leaveID; }
            set { leaveID = value; }
        }

        int numberOfDays;
        public int NumberOfDays
        {
            get { return numberOfDays; }
            set { numberOfDays = value; }
        }
    }
}
