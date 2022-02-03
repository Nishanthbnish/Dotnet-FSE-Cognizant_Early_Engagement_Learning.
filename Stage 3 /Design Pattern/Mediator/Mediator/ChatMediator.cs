using System;
using System.Collections.Generic;

namespace Mediator
{
    public class ChatMediator : IChatMediator
    {
        private List<IUser> users;

        public ChatMediator()
        {
            users = new List<IUser>();
        }

        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public void SendMessage(string msg)
        {
            foreach (var user in users)
            {
                user.RecieveMessage(msg);
            }
        }
    }
}
