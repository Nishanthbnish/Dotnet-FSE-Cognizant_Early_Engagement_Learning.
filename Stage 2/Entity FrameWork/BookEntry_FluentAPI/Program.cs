using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1   //DO NOT change the namespace name
{
    public class Program   //DO NOT change the class name
    {
        static void Main(string[] args)      //DO NOT change the 'Main' method signature
        {
             Book b=new Book();
            BookUtil bu=new BookUtil();
            Console.WriteLine("Enter BookId");
            b.BookId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Name");
            b.BookName=Console.ReadLine();
            Console.WriteLine("Enter Book Author");
            b.BookAuthor=Console.ReadLine();
            Console.WriteLine("Enter Book Genre");
            b.BookGenre=Console.ReadLine();
            Console.WriteLine("Enter Book Price");
            b.BookPrice=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Details By Genre");
            string g=Console.ReadLine();
            List<Book> sh=new List<Book>();
            sh=bu.GetBookByGenre(g);
            Console.WriteLine("Enter Book Id");
            int id=Convert.ToInt32(Console.ReadLine());
            Book qw=bu.DeleteBook(id);
        }
    }
}
