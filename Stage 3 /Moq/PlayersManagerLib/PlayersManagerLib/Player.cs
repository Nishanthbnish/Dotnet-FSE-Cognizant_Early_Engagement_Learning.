using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersManagerLib
{
    public class Player
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Country { get; private set; }
        public int NoOfMatches { get; private set; }

        public Player(string name, int age, string country, int noOfMatches)
        {
            Name = name;
            Age = age;
            Country = country;
            NoOfMatches = noOfMatches;
        }

        public static Player RegisterNewPlayer(string name, IPlayerMapper playerMapper = null)
        {
            // If a PlayerMapper was not passed in, use a real one.
            // This allows us to pass in a "mock" PlayerMapper (for testing),
            // but use a real PlayerMapper, when running the program.
            if (playerMapper == null)
            {
                playerMapper = new PlayerMapper();
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Player name can’t be empty.");
            }

            // Throw an exception if there is already a player with this name in the database.
            if (playerMapper.IsPlayerNameExistsInDb(name))
            {
                throw new ArgumentException("Player name already exists.");
            }

            // Add the player to the database.
            playerMapper.AddNewPlayerIntoDb(name);

            return new Player(name, 23, "India", 30);

        }
    }
}
