using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx1              //DO NOT CHANGE the namespace name
{
    public class Program       //DO NOT CHANGE the class name
    {
        public static void Main(string[] args)    //DO NOT CHANGE the 'Main' method signature
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd-mm-yyyy",null);
            string dt=dob.ToString("dd-mm-yyyy");
            Console.WriteLine(calculateAge(dt));
        }

        public static int calculateAge(string dateOfBirth)
        {
            //Implement code here
            int birthyear=Int32.Parse(dateOfBirth.Substring(6,4));
            int birthmonth=Int32.Parse(dateOfBirth.Substring(3,2));
            int birthdate=Int32.Parse(dateOfBirth.Substring(0,2));
            var t=DateTime.Today;
            if(t.Month>birthmonth||t.Month==birthmonth&&t.Day>=birthdate){
                return (t.Year-birthyear);}
                else
                return t.Year-birthyear-1;
            }
            

        }


    }

