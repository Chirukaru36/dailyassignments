using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhaseEndProject
{
    public class Player
    {
        public int PlayerId {  get; set; }

        public string PlayerName { get; set; }

        public int PlayerAge {  get; set; }
    }

    public interface ITeam
    {
        void Add(Player player);

        void Remove(int playerId);

        Player GetPlayerById(int playerId);

        Player GetPlayerByName(string playername);

        List<Player> GetAllPlayers();
    }

    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam= new List<Player>();
        public int capacity = 11;

        public void Add(Player player)
        {
            if (oneDayTeam.Count < capacity)
            {
                oneDayTeam.Add(player);
            }
            else
            {
                Console.WriteLine("the team is already at full capacity(11 players)");
            }
        }

        public void Remove(int playerId) 
        {
            Player playerToRemove = oneDayTeam.Find(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
            }
            else
            {
                Console.WriteLine("Player with id " + playerId + "not found in the team");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(p => p.PlayerId==playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(p =>p.PlayerName==playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
