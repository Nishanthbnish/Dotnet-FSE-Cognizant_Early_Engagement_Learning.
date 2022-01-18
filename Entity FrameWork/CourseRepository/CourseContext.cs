using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace Exercise1          //DO NOT Change the namespace name
{
  public  class CourseContext:DbContext        //DO NOT Change the class name
    {
        //DO NOT Change the Context name 'CourseConnectionString'
        public CourseContext() : base("name=CourseConnectionString"){}
        
        
        //Declare 'Courses' of type Dbset and add neccessary declaration code.
        public virtual DbSet< Course > Courses
        {
            get;
            set;
        }
    }
}