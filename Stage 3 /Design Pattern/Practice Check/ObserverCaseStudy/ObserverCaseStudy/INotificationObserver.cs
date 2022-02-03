using System;

namespace ObserverCaseStudy
{
    public interface INotificationObserver
    {
        string Name { get; }

        void OnServerDown();
    }
}
