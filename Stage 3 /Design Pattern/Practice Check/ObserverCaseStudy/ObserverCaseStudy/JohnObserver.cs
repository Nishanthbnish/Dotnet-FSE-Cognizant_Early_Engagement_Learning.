using System;

namespace ObserverCaseStudy
{
    class JohnObserver : INotificationObserver
    {
        public string Name
        {
            get { return "John"; }
        }

        public void OnServerDown()
        {
            Console.WriteLine($"{Name} server down");
        }
    }
}
