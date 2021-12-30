using System;

public class Program      //DO NOT change the class name
{
   public static void Main(string [] args){
       string firstName,LastName;
       Console.WriteLine("Enter first name");
       firstName = Console.ReadLine();
       Console.WriteLine("Enter last name");
       LastName = Console.ReadLine();
       string concat=string.Concat(firstName," ",LastName);
       Console.WriteLine("full name :"+concat);
   }
}
