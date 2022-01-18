using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1              //DO NOT change the namespace name
{
    public class BookUtil         //DO NOT change the class name 
    {
         
        public Book AddBook(Book book)    //DO NOT change the method Name and Signature
        {
           Book b1=null;
            //Implement code to insert the book entity to database
            using (var context = new LibraryContext()) 
            {
                b1=context.Books.Add(book); 
                context.SaveChanges();
             }
             return b1;
        }


        public List<Book> GetBookByGenre(String Genre)   //DO NOT change the method Name and Signature
        {
            List<Book> ak=null;
            using (var context = new LibraryContext()) 
            {
            var st=(from s in context.Books where s.BookGenre==Genre select s).ToList<Book>();
            ak=st;
                
            }
            return ak;
            //Implement code to get the book entity from database based on Genre
        }
        public List<Book> GetBooksList() //DO NOT change the method Name and Signature
        {
             //Implement code to get the book list from database
            List<Book> ak=null;
            using (var context = new LibraryContext()) 
            {
            var st=(from s in context.Books  select s).ToList<Book>();
            ak=st;
                
            }
            return ak;
        }
        public Book UpdateBookPrice(int NewPrice,int Bookid)   //DO NOT change the method Name and Signature
        {
             //Implement code to update the book entity 
            Book damu=null;
             //Implement code to update the book entity 
             using (var context = new LibraryContext()) 
             {
               var bo = (from d in context.Books where d.BookId == Bookid select d).Single();
               bo.BookPrice = NewPrice;
               damu=bo;
               context.SaveChanges();
             }
             return damu;
        }

        public Book DeleteBook(int BookId)  //DO NOT change the method Name and Signature
        {
            //Implement code to delete the book entity by Id
            Book w=null;
            //Implement code to delete the book entity by Id
            using (var context = new LibraryContext()) 
            {
               var bay=context.Books.Find(BookId);
               Console.WriteLine(bay.BookId);
               w=context.Books.Remove(bay);
                context.SaveChanges();
            }
            return w;
        }

    }
}
