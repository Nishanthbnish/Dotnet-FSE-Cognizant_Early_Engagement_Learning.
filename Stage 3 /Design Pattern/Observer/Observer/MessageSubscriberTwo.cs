using System;

namespace Observer
{
    public class MessageSubscriberTwo : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberTwo : " + m.GetMessageContent());
        }
    }
}
