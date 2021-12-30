using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals1             //DO NOT CHANGE the name of namespace
{
    public class Program                //DO NOT CHANGE the name of class 'Program'
    { 
        public static void Main(string[] args)        //DO NOT CHANGE 'Main' Signature
        {
            Console.WriteLine("Enter your name");
           string s= Console.ReadLine();
           Console.WriteLine("Enter your age");
           string s1= Console.ReadLine();
           Console.WriteLine("Enter your country");
           string s2= Console.ReadLine();
           Console.WriteLine("Welcome "+s+"Your age is " +s1+"and you are from "+s2);
           
        }
    }
}
