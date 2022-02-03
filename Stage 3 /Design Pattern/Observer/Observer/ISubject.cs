namespace Observer
{
    public interface ISubject
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void NotifyUpdate(Message m);
    }
}
