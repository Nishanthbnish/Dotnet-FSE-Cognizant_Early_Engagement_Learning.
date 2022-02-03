using System;
using System.Collections.Generic;

namespace ObserverCaseStudy
{
    public class NotificationService : INotificationService
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("observers: ");
            foreach (var ob in _observers)
            {
                Console.WriteLine(ob.Name);
            }
        }

        public void RemoveSubsriber(INotificationObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("observers: ");
            foreach (var ob in _observers)
            {
                Console.WriteLine(ob.Name);
            }
        }

        public void NotifySubscriber()
        {
            foreach (var ob in _observers)
            {
                ob.OnServerDown();
            }
        }
    }
}
