using System;

namespace ChainOfResponsibility
{
    class Supervisor : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler 
        { 
            get { return new ProjectManager(); } 
        }

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays <= 3)
            {
                Console.WriteLine("Supervisor: Leave Approved");
            }
            else
            {
                NextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}
