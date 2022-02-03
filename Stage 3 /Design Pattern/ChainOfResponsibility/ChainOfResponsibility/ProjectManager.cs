using System;

namespace ChainOfResponsibility
{
    class ProjectManager : ILeaveRequestHandler
    {
        public ILeaveRequestHandler NextHandler 
        { 
            get { return new HR(); } 
        }

        public void HandleRequest(LeaveRequest leaveRequest)
        {
            if (leaveRequest.LeaveDays <= 5)
            {
                Console.WriteLine("Project Manger: Leave Approved");
            }
            else
            {
                NextHandler.HandleRequest(leaveRequest);
            }
        }
    }
}
