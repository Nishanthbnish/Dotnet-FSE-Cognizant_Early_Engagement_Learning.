using System;

namespace Mediator
{
    public interface IUser
    {
        void RecieveMessage(string msg);

        void SendMessage(string msg);
    }
}
