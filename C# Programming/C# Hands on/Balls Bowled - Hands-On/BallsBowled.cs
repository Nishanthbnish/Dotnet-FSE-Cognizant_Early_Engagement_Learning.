
using System;
using System.Collections.Generic;

namespace BallsBowled        //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of overs");
            int overs = int.Parse(Console.ReadLine());
            
            PlayerBO pb = new PlayerBO();
            pb.AddOversDetails(overs); 
        }
   }

    public class PlayerBO      //DO NOT change the class name
    {
       public List<int> PlayerList { get; set; } = new List<int>();
        int balls;
        public void AddOversDetails(int oversBowled)       //DO NOT change the method signature
        {
        
            PlayerList.Add(oversBowled);
            Console.WriteLine(PlayerList);
            foreach(int i in PlayerList)
            {
              balls = i;
            }
            Console.WriteLine("Balls Bowled : " + GetNoOfBallsBowled());
        }

        public int GetNoOfBallsBowled()              //DO NOT change the method signature
        {
            return balls *6 ;
            //Implement code here
        }


    }
}