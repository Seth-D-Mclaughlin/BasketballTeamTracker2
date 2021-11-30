using BasketballTeamTracker.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTeamTracker.Repository
{
    public class PlayerRepo
    {
        // This is our fake database...
        // list of players that we put in here...
        // Full roster of the NBA
        private readonly List<Player> _players = new List<Player>();
        
        // This will help us auto-icrement the ID of the player
        private int _count = 0;
        

        //C
        public bool CreatePlayer(Player player)
        {
            
            if(player is null)
            {
                return false;
            }
            
            _count++;
            player.Id = _count;
            _players.Add(player);
            return true;
        }
        //R
        public List<Player> GetPlayers() //Get all
        {
            
            return _players;
        }
        public Player GetPlayerById(int id) // Get by ID
        {
            // We need to look inside of _players and find a player w/ a specific ID that matches the id we are recieving as a arg
            foreach(var player in _players)
            {
                if (id == player.Id)
                {
                    return player;
                }
            }
            return null;
        }

        //U
        public bool UpdatePlayer(int id, Player newPlayerData)
        {
            Player oldPlayerData = GetPlayerById(id);
            
            if(oldPlayerData != null)
            {
                oldPlayerData.Id = newPlayerData.Id;
                oldPlayerData.FirstName = newPlayerData.FirstName;
                oldPlayerData.LastName = newPlayerData.LastName;
                oldPlayerData.PlayerPosition = newPlayerData.PlayerPosition;
                return true;
            }
            else
            {
                return false;
            }
        }
        //D
        public bool DeletePlayer(int id)
        {
            Player playerToBeYeeted = GetPlayerById(id);
            if(playerToBeYeeted == null)
            {
                return false;
            }
            else
            {
                _players.Remove(playerToBeYeeted);
                return true;
            }
        }
    }
}
