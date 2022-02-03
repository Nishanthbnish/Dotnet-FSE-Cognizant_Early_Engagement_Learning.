using System;

namespace Mediator
{
    public class BasicUser : IUser
    {
        private ChatMediator chatMediator;
        private string name;

        public BasicUser(ChatMediator chatMediator, string name)
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
