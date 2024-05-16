using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayerManagerMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
            {
                new Player("Player1", 100),
                new Player("Player2", 200)
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir jogador");
                Console.WriteLine("2. Listar todos os jogadores");
                Console.WriteLine("3. Listar jogadores com Score maior que um valor indicado");
                Console.WriteLine("4. Sair");

                Console.Write("Escolha uma opçao: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertPlayer(players);
                        break;
                    case "2":
                        ListAllPlayers(players);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan(players);
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            }
        }
        static void InsertPlayer(List<Player> players)
        {
            Console.Write("Nome do jogador: ");
            string name = Console.ReadLine();
            Console.Write("Pontuaçao do jogador: ");
            int score = Convert.ToInt32(Console.ReadLine());

            players.Add(new Player(name, score));
            Console.WriteLine("Jogador adicionado!");
        }        
        static void ListAllPlayers(List<Player> players)
        {
            players.Sort();

            Console.WriteLine("\nLista de todos os jogadores:");
            foreach (var player in players)
            {
                string playerName = player.Name;
                int playerScore = player.Score;
                Console.WriteLine($"Nome: {playerName}, Score: {playerScore}");
            }
        }
        static void ListPlayersWithScoreGreaterThan(List<Player> players)
        {
            Console.Write("Digite o valor do Score mínimo: ");
            int minScore = Convert.ToInt32(Console.ReadLine());

            List<Player> playersWithScoreGreaterThan = GetPlayersWithScoreGreaterThan(players, minScore);
            playersWithScoreGreaterThan.Sort();

            Console.WriteLine($"\nJogadores com Score maior que {minScore}:");
            foreach (var player in playersWithScoreGreaterThan)
            {
                string playerName = player.Name;
                int playerScore = player.Score;
                Console.WriteLine($"Nome: {playerName}, Score: {playerScore}");
            }
        }
        static void ListPlayersByNameAscending(List<Player> players)
        {
            players.Sort(new CompareByName(true));

            Console.WriteLine("\nLista de jogadores por nome (ascendente):");
            foreach (var player in players)
            {
                string playerName = player.Name;
                int playerScore = player.Score;
                Console.WriteLine($"Nome: {playerName}, Score: {playerScore}");
            }
        }
        static void ListPlayersByNameDescending(List<Player> players)
        {
            players.Sort(new CompareByName(false));

            Console.WriteLine("\nLista de jogadores por nome (descendente):");
            foreach (var player in players)
            {
                string playerName = player.Name;
                int playerScore = player.Score;
                Console.WriteLine($"Nome: {playerName}, Score: {playerScore}");
            }
        }
        static List<Player> GetPlayersWithScoreGreaterThan(List<Player> players, int minScore)
        {
            List<Player> filteredPlayers = new List<Player>();
            foreach (var player in players)
            {
                if (player.Score > minScore)
                {
                    filteredPlayers.Add(player);
                }
            }
            return filteredPlayers;
        }





    }
}
