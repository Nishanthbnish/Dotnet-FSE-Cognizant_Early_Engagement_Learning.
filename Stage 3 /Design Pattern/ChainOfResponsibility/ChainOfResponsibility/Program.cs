using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var leaveRequest = new LeaveRequest() 
            { 
                Employee = "Rupesh",
                LeaveDays = 4
            };

            var supervisor = new Supervisor();
            supervisor.HandleRequest(leaveRequest);
        }
    }
}
