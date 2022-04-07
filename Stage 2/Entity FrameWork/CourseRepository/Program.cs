using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1       //DO NOT Change the namespace name
{
    public class Program         //DO NOT Change the class name
    {
        static void Main(string[] args)
        {
            Course c=new Course();
            CourseContext x=new CourseContext();
            
            CourseRepository cr=new CourseRepository(x);
            CourseRepository cr1=new CourseRepository(x);
            Console.WriteLine("Enter Course Id");
            c.CourseId=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Name");
            c.CourseName=Console.ReadLine();
            Console.WriteLine("Enter Duration");
            c.Duration=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Course Fee");
            c.CourseFee=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Instructor Name");
            c.InstructorName=Console.ReadLine();
            cr.InsertCourse(c);
            IList<Course> ck=cr.GetCourseList();
            foreach(Course cu in ck)
            {
              Console.WriteLine(cu);
            }
            Console.WriteLine(ck);
            Console.WriteLine("Get Course Details By id");
            int id=Convert.ToInt32(Console.ReadLine());
            Course c1=cr1.GetCourseByID(id);
            if(c1!=null)
        {
          Console.WriteLine(c1);
        }
            Console.WriteLine("Update Course Fee");
            int id1=Convert.ToInt32(Console.ReadLine());
            double fee=Convert.ToDouble(Console.ReadLine());
            Course an=cr1.UpdateCourseFee(id1,fee);
        }
    }
}
