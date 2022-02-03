using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            var admin = new AdminObserver("rupesh");

            var service = new NoticificationService();

            service.AddSubscriber(admin);

            service.AddTicket(90);
            service.AddTicket(10);
        }
    }
}
