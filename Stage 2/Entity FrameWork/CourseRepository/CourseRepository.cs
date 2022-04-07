using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Exercise1             //DO NOT Change the namespace name
{
   public class CourseRepository      //DO NOT Change the class name
    {
        //DO NOT Change the variable or method signature. Add only the required code inside the method.
        
        private CourseContext context;
        
        public CourseRepository(CourseContext context)
        {
            this.context=context;
            //Implement code here
        }
        
        public IList<Course> GetCourseList()
        {
             DbSet<Course> cours=context.Courses;
             IList<Course> courses=cours.ToList<Course>();
             return courses;
            //Implement code here
        }

        public Course GetCourseByID(int courseId)
        {
           DbSet<Course> cos=context.Courses;
           Course cs=cos.Find(courseId);
           return cs;

             //Implement code here
        }

        public void InsertCourse(Course course)
        {
            
            context.Courses.Add(course);
            Console.WriteLine("Details Added Successfully");
            context.SaveChanges();
             //Implement code here
        }

        public Course UpdateCourseFee(int id, double fee)
        {
           DbSet<Course> anu=context.Courses;
           Course cs=anu.Find(id);
           if(cs!=null)
         {
          cs.CourseFee=fee;
        if(context.SaveChanges()>0)
        {
         Console.WriteLine("updated Successfully");
        }
        }

      return cs;
             //Implement code here
        }
    }
}
