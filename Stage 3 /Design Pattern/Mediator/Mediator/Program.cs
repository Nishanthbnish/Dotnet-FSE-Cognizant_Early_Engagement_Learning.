using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ChatMediator();

            var user1 = new BasicUser(mediator, "user1");
            var user2 = new BasicUser(mediator, "user2");
            var user3 = new PremiumUser(mediator, "user3");

            mediator.AddUser(user2);
            mediator.AddUser(user3);

            user1.SendMessage("Hello");
        }
    }
}
