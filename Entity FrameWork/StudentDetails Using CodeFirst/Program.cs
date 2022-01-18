using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement               //DO NOT Change the namespace name
{
    public class Program              //DO NOT Change the class name
    {
        public static void Main(string[] args)
        {
            var stud = new CollegeContext();

            //Implement the code here
            Program Pro = new Program();
            Student std = new Student();
            Console.WriteLine("Enter Student Id");
            std.StudentId = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Enter Student Name");
            std.StudentName = Console.ReadLine();

            Console.WriteLine("Enter Department");
            std.Department= Console.ReadLine();
            
            Console.WriteLine("Enter Enrollment Date");
            std.EnrolledDate = Convert.ToDateTime(DateTime.Now);

            Console.WriteLine("Enter PhoneNumber");
            std.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                       
            
            Pro.AddStudent(std);
            Console.WriteLine();
            Console.WriteLine();


            
            
        }
        
        public void AddStudent(Student std)
        {
            var stud = new CollegeContext();
            stud.Students.Add(std);
            stud.SaveChanges(); // Writing the changed to DB
            Console.WriteLine("Details Added successfully");          

        }
    }
}
