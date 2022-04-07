using System;

public class Program      //DO NOT change the class name
{
    public static void Main(string [] args){
        sbyte num=125;
        Console.WriteLine("Value of number:"+num);
        
        num=sbyte.MaxValue;
        Console.WriteLine("Largest value stored in a signed byte:"+num);
    }
}
