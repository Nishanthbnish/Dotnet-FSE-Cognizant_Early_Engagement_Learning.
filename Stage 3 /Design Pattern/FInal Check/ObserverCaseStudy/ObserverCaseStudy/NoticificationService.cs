using System;
using System.Collections.Generic;

namespace ObserverCaseStudy
{
    public class NoticificationService : INotificationService
    {
        private List<INotificationObserver> _observers = new List<INotificationObserver>();
        private int _ticket = 0;

        public void AddTicket(int num)
        {
            _ticket += num;
            if (_ticket >= 100)
            {
                NotifySubscriber();
            }
        }

        public void AddSubscriber(INotificationObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveSubsriber(INotificationObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifySubscriber()
        {
            foreach (var observer in _observers)
            {
                observer.OnHundredTicketBooked();
            }
        }
    }
}
