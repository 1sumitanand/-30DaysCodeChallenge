using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    class ProjectManager : Employee
    {
        const int MAX_LEAVES_CAN_APPROVE = 20;

        // in constructor we will attach the event handler that
        // will check if this employee can process or he need to
        // pass on to next employee
        public ProjectManager()
        {
            this.onLeaveApplied += new OnLeaveApplied(ProjectManager_onLeaveApplied);
        }

        // in this function we will check if this employee can 
        // process or he need to pass on to next employee
        void ProjectManager_onLeaveApplied(Employee e, Leave l)
        {
            // check if we can process this request
            if (l.NumberOfDays < MAX_LEAVES_CAN_APPROVE)
            {
                // process it on our level only
                ApproveLeave(l);
            }
            else
            {
                // if we cant process pass on to the supervisor 
                // so that he can process
                if (Supervisor != null)
                {
                    Supervisor.ApplyLeave(l);
                    //Supervisor.LeaveApplied(this, l);
                }
            }
        }

        // If we can process lets show the output
        public override void ApproveLeave(Leave leave)
        {
            Console.WriteLine("LeaveID: {0} Days: {1} Approver: {2}", leave.LeaveID, leave.NumberOfDays, " Project Manager ");
        }
    }
}