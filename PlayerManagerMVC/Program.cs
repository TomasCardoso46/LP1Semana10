// Program.cs (View)
using System;
using System.Collections.Generic;
using PlayerManagerMVC.Controllers;
using PlayerManagerMVC.Models;

namespace PlayerManagerMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            var playerController = new PlayerController();

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Inserir jogador");
                Console.WriteLine("2. Listar todos os jogadores");
                Console.WriteLine("3. Listar jogadores com Score maior que um valor indicado");
                Console.WriteLine("4. Listar jogadores por nome (ascendente)");
                Console.WriteLine("5. Listar jogadores por nome (descendente)");
                Console.WriteLine("6. Sair");

                Console.Write("Escolha uma opção: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertPlayer(playerController);
                        break;
                    case "2":
                        ListAllPlayers(playerController);
                        break;
                    case "3":
                        ListPlayersWithScoreGreaterThan(playerController);
                        break;
                    case "4":
                        ListPlayersByName(playerController, ascending: true);
                        break;
                    case "5":
                        ListPlayersByName(playerController, ascending: false);
                        break;
                    case "6":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

            }
        }

        static void InsertPlayer(PlayerController playerController)
        {
            Console.Write("Nome do jogador: ");
            string name = Console.ReadLine();
            Console.Write("Pontuação do jogador: ");
            int score = Convert.ToInt32(Console.ReadLine());
            playerController.InsertPlayer(name, score);
            Console.WriteLine("Jogador adicionado!");
        }

        static void ListAllPlayers(PlayerController playerController)
        {
            var players = playerController.GetAllPlayers();
            Console.WriteLine("\nLista de todos os jogadores:");
            foreach (var player in players)
            {
                Console.WriteLine($"Nome: {player.Name}, Score: {player.Score}");
            }
        }

        static void ListPlayersWithScoreGreaterThan(PlayerController playerController)
        {
            Console.Write("Digite o valor do Score mínimo: ");
            int minScore = Convert.ToInt32(Console.ReadLine());

            var players = playerController.GetPlayersWithScoreGreaterThan(minScore);
            Console.WriteLine($"\nJogadores com Score maior que {minScore}:");
            foreach (var player in players)
            {
                Console.WriteLine($"Nome: {player.Name}, Score: {player.Score}");
            }
        }

        static void ListPlayersByName(PlayerController playerController, bool ascending)
        {
            var players = playerController.GetPlayersSortedByName(ascending);

            string order = ascending ? "ascendente" : "descendente";
            Console.WriteLine($"\nLista de jogadores por nome ({order}):");
            foreach (var player in players)
            {
                Console.WriteLine($"Nome: {player.Name}, Score: {player.Score}");
            }
        }
    }
}
