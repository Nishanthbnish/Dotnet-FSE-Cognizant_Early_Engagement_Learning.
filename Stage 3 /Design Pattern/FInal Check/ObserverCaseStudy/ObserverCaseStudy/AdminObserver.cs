using System;

namespace ObserverCaseStudy
{
    public class AdminObserver : INotificationObserver
    {
        private string _name;

        public AdminObserver(string name)
        {
            _name = name;
        }

        public void OnHundredTicketBooked()
        {
            Console.WriteLine($"{_name} -  100 tickets are booked");
        }
    }
}
