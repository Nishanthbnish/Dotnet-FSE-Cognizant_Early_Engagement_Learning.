using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StudentManagement      //DO NOT Change the namespace name
{
    public class CollegeContext: DbContext      //DO NOT Change the class name
    {
        //DO NOT Change the Context name 'StudentConnectionString'
        public CollegeContext() : base("name=StudentConnectionString"){}
        
        //Declare 'Students' Property of type Dbset with neccessary declaration code.
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
       

    }
}
