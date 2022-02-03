using System;

namespace Mediator
{
    public class PremiumUser : IUser
    {
        private ChatMediator chatMediator;
        private string name;
        
        public PremiumUser(ChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }

        public void RecieveMessage(string msg)
        {
            Console.WriteLine($"Name: {name}; Message: {msg}");
        }

        public void SendMessage(string msg)
        {
            chatMediator.SendMessage(msg);
        }
    }
}
