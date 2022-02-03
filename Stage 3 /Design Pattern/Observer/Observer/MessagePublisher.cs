using System.Collections.Generic;

namespace Observer
{
    public class MessagePublisher : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver o)
        {
            _observers.Add(o);
        }

        public void Detach(IObserver o)
        {
            _observers.Remove(o);
        }

        public void NotifyUpdate(Message m)
        {
            foreach (var observer in _observers)
            {
                observer.Update(m);
            }
        }
    }
}
