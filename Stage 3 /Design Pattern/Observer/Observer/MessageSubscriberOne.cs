using System;

namespace Observer
{
    public class MessageSubscriberOne : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberOne : " + m.GetMessageContent());
        }
    }
}
