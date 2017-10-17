using System;

namespace Rock__paper__scissors
{
    class Program
    {
        static void Main(string[] args) {

            // Define the names of the players
            Console.WriteLine("Player 1's name?");
            string player1Name = Console.ReadLine();

            Console.WriteLine("Player 2's name?");
            string player2Name = Console.ReadLine();

            Console.WriteLine("Lets play");

            // Define null variables to reuse
            string player1Choice = "";
            string player2Choice = "";
            Random randomObject = new Random();

            // Loops the game until the user states not too
            bool play = true;
            while (play) {

                Console.WriteLine("1, 2, 3 ...");

                // Call the choice method to assign the players ether rock, paper or scissors
                player1Choice = choice(randomObject);
                player2Choice = choice(randomObject);

                // Defines which player wins the game
                result(player1Name, player2Name, player1Choice, player2Choice);

                // Defines if the game is replayed
                Console.WriteLine("Do you want to play again? (Yes / No)");
                if (Console.ReadLine() != "Yes") {
                    play = false;
                }
            }

            Console.WriteLine("Thanks for playing.");
            Console.ReadLine();

        }

        // Assins either rock, paper or scissors to the player
        public static string choice(Random randomObject) {

            // Generates a random number from 1 to 9
            int playerChoice = randomObject.Next(1, 9);

            // Assins either rock, paper or scissors depending on the generated number
            if (playerChoice >= 1 && playerChoice <= 3) {
                return "Rock";
            }
            else if (playerChoice >= 4 && playerChoice <= 6) {
                return "Paper";
            }
            else {
                return "Scissors";
            }
        }

        // Compares the players choices 
        public static void result(string player1Name, string player2Name,  string player1Choice, string player2Choice) {
            // Displays the players choice
            Console.WriteLine(player1Name + " chooses " + player1Choice);
            Console.WriteLine(player2Name + " chooses " + player2Choice);

            // Compares the players choices and displays the result
            if (player1Choice == player2Choice) {
                Console.WriteLine("The gaame is a draw");
            }
            else if (player1Choice == "Rock") {
                if (player2Choice == "Scissors") {
                    Console.WriteLine(player1Name + " wins the game.");
                }
                else  {
                    Console.WriteLine(player2Name + " wins the game.");
                }
            }
            else if (player1Choice == "Paper") {
                if (player2Choice == "Rock") {
                    Console.WriteLine(player1Name + " wins the game.");
                }
                else {
                    Console.WriteLine(player2Name + " wins the game.");
                }
            }
            else if (player1Choice == "Scissors") {
                if (player2Choice == "Paper")
                {
                    Console.WriteLine(player1Name + " wins the game.");
                }
                else {
                    Console.WriteLine(player2Name + " wins the game.");
                }
            }
        }
    }
}