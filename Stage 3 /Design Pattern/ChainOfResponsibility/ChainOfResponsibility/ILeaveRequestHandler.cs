using System;

namespace ChainOfResponsibility
{
    interface ILeaveRequestHandler
    {
        ILeaveRequestHandler NextHandler { get; }
        
        void HandleRequest(LeaveRequest leaveRequest);
    }
}
