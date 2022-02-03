using System;

namespace ObserverCaseStudy
{
    class SteveObserver : INotificationObserver
    {
        public string Name
        {
            get { return "Steve"; }
        }

        public void OnServerDown()
        {
            Console.WriteLine($"{Name} server down");
        }
    }
}
