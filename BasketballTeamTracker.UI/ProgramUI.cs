using BasketballTeamTracker.POCO;
using BasketballTeamTracker.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketballTeamTracker.UI
{
    public class ProgramUI
    {
        private readonly PlayerRepo _playerRepo = new PlayerRepo();
        public void Run()
        {
            // Seed();
            RunApplication();
        }

        public void Menu()
        {
            Console.WriteLine("Welcome to the Basketball Team Tracker\n" + "1. Create Player\n" + "2. View All Players\n" + "3. View a single player\n" + "4. Update an Existing Player\n" + "5. Delete a Player\n" +
                "99. Close Application");
        }

        private void RunApplication()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.Clear();
                Menu();
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        CreatePlayer();
                        break;
                    case "2":
                        ViewAllPlayers();
                        break;
                    case "3":
                        ViewSinglePlayer();
                        break;
                    case "4":
                        UpdatePlayer();
                        break;
                    case "5":
                        DeletePlayer();
                        break;
                    case "99":
                        isRunning = false;
                        break;
                    default:
                        break;
                }
            }
        }

        private void DeletePlayer()
        {
            throw new NotImplementedException();
        }

        private void UpdatePlayer()
        {
            throw new NotImplementedException();
        }

        private void ViewSinglePlayer()
        {
            throw new NotImplementedException();
        }

        private void ViewAllPlayers()
        {
            Console.Clear();
            List<Player> listOfAllPlayers = _playerRepo.GetPlayers();

            foreach (var player in listOfAllPlayers)
            {
                DisplayPlayerInfo(player);
            }
            Console.ReadKey();
            
        }

        private void DisplayPlayerInfo(Player player) // helper method
        {
            Console.WriteLine($"{player.Id}\n" +
                $"{player.FirstName}\n" +
                $"{player.LastName}\n" +
                $"{player.PlayerPosition}\n");
            Console.WriteLine("***************************");
        }

        private void CreatePlayer()
        {
            Console.Clear();

            // Get first name
            Console.WriteLine("Please input the player's first name: ");
            string userInputFirstName = Console.ReadLine();

            // Get last name
            Console.WriteLine("Please input the player's last name: ");
            string userInputLastName = Console.ReadLine();

            // Get position
            Console.WriteLine("Please input a player position:\n" + "1. Point Guard\n" + "2. Shooting Guard\n" + "3. Small Forward\n" + "4. Power " + "\n" +
                "5. center");

            int userInputPlayerPosition = int.Parse(Console.ReadLine());

            // Now, we need to make a conversion from int to PlayerPositionType
            PlayerPositionType playerPositionType = (PlayerPositionType)userInputPlayerPosition;

            Player playerToBeAddedToDataBase = new Player(userInputFirstName, userInputLastName, playerPositionType);

           bool isSuccessful = _playerRepo.CreatePlayer(playerToBeAddedToDataBase);
            if (isSuccessful)
            {
                Console.WriteLine($"{userInputFirstName} was successfully added to the database");
            }
            else
            {
                Console.WriteLine($"{userInputFirstName} was not added to the database");

            }
        }
    }
}
