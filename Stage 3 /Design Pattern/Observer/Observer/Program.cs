using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new MessageSubscriberOne();
            var s2 = new MessageSubscriberTwo();
            var s3 = new MessageSubscriberThree();

            var p = new MessagePublisher();
            p.Attach(s1);
            p.Attach(s2);

            p.NotifyUpdate(new Message("Fist Message"));

            p.Detach(s1);
            p.Attach(s3);

            p.NotifyUpdate(new Message("Second Message"));
        }
    }
}
