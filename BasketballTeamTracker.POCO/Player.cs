using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTeamTracker.POCO
{

    public class Player
    {
        public Player()
        {
        } // Empty Constructor
        public Player(string firstName, string lastName, PlayerPositionType playerPosition)
        {
            FirstName = firstName;
            LastName = lastName;
            PlayerPosition = playerPosition;
        } // 3/4 Constructor

        public int Id { get; set; } // Gives us a way to uniquely identify the players
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerPositionType PlayerPosition { get; set; }


    }
}
