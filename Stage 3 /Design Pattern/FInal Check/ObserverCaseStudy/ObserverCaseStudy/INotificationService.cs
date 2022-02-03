using System;

namespace ObserverCaseStudy
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);

        void RemoveSubsriber(INotificationObserver observer);

        void NotifySubscriber();
    }
}
