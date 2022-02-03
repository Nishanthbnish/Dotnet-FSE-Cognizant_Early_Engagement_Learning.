namespace Observer
{
    public class Message
    {
        private readonly string _messageContent;

        public Message(string m)
        {
            _messageContent = m;
        }

        public string GetMessageContent()
        {
            return _messageContent;
        }
    }
}
