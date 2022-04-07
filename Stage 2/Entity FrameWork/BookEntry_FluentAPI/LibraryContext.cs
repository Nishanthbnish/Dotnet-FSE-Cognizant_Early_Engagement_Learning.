using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Exercise1                      //DO NOT change the namespace name
{
    class LibraryContext:DbContext        //DO NOT change the class name
    {

        //DO NOT change the context name
        public LibraryContext() : base("name=BookStore")
        {


        }
       public virtual DbSet<Book> Books
            {
                get;
                set;
            }
       
       
        //Implement Books of type DbSet
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Implement code to make 'Book_id' required in entity 'Book' and table name as mentioned in description 
           //throw new UnintentionalCodeFirstException();
        }
    }
}
