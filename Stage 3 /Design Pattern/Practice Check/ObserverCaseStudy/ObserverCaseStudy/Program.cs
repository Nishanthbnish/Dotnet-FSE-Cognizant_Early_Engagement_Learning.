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
            var steve = new SteveObserver();
            var john = new JohnObserver();

            var noticificationService = new NotificationService();
            noticificationService.AddSubscriber(steve);
            noticificationService.AddSubscriber(john);

            noticificationService.NotifySubscriber();

            noticificationService.RemoveSubsriber(steve);
        }
    }
}
