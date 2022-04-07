using System;

public class Program      //DO NOT change the class name
{
    public static void Main(String [] args){
    
            bool  result;
            Console.WriteLine("Enter the value for x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for y");
            int y = Convert.ToInt32(Console.ReadLine());
            result= x < y;
           Console.WriteLine("x is less than y is true");
    }
}
