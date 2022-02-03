using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = DBConn.GetInstance();
            Console.WriteLine(db.ToString());
        }
    }
}
