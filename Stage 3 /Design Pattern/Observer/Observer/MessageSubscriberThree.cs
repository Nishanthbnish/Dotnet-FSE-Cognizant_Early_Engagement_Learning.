using System;

namespace Observer
{
    public class MessageSubscriberThree : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberThree : " + m.GetMessageContent());
        }
    }
}
