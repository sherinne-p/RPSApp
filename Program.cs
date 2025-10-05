// Updated remotely for pull demonstration

using System;

namespace RockPaperScissorsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choices the game can use
            string[] choices = { "rock", "paper", "scissors" };

            // This is for generating random numbers
            Random random = new Random();

            Console.WriteLine("=== ROCK, PAPER, SCISSORS ===");

            Console.WriteLine("v1.0");

            // Ask the user for their choice
            Console.Write("Enter your choice (rock, paper, or scissors): ");
            string playerChoice = Console.ReadLine().ToLower();

            // Check if the user typed something valid
            if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
            {
                Console.WriteLine("Invalid choice. Please type rock, paper, or scissors.");
                return; // stop the program here
            }

            // Make the computer choose one of the options at random
            string computerChoice = choices[random.Next(choices.Length)];

            Console.WriteLine($"Computer chose: {computerChoice}");
            Console.WriteLine($"You chose: {playerChoice}");

            // Decide who wins
            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                     (playerChoice == "paper" && computerChoice == "rock") ||
                     (playerChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Computer wins!");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
