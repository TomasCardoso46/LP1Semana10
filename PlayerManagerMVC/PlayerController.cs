using System;
using System.Collections.Generic;
using PlayerManagerMVC.Models;

namespace PlayerManagerMVC.Controllers
{
    public class PlayerController
    {
        private List<Player> _players;

        public PlayerController()
        {
            _players = new List<Player>
            {
                new Player("Player1", 100),
                new Player("Player2", 200)
            };
        }

        public void InsertPlayer(string name, int score)
        {
            _players.Add(new Player(name, score));
        }

        public List<Player> GetAllPlayers()
        {
            return _players;
        }

        public List<Player> GetPlayersWithScoreGreaterThan(int minScore)
        {
            return _players.FindAll(player => player.Score > minScore);
        }

        public List<Player> GetPlayersSortedByName(bool ascending)
        {
            var comparer = new CompareByName(ascending);
            _players.Sort(comparer);
            return _players;
        }
    }
}