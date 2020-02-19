using Players;
using System;
using System.Collections.Generic;

namespace War
{
    class Game
    {
        public List<Player> Players { get; private set; }

        public Game()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {

            Players = new List<Player>();

       
        }

        private void PlayBlackjack()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("----------WAR----------");
            Console.WriteLine("-----------------------------");
            InitializeGame();
            PlayerSelectMenu();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("----------------- GAME OVER -----------------");
            Console.WriteLine("---------------------------------------------");
        }

        private void PlayerSelectMenu()
        {
            Console.WriteLine("Please enter the number of player(s): ");
            int numPlayers = int.Parse(Console.ReadLine());

            {
                Console.WriteLine($"Please enter the names of the two player: ");
                string name = Console.ReadLine();
                Players.Add(new Player(name));
            }
        }

        public void MainMenu()
        {
            int option = 0;
            while (option != -1)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("----------Main Menu----------");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("   1) Play War");
                Console.WriteLine("  -1) Exit");
                Console.WriteLine("Please select an option from the list above: ");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {

                    case -1:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option selected...");
                        break;
                }
            }
        }
    }
}
