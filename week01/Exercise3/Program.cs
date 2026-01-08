using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 11);

            int attempts = 0;
            bool guessing = true;

            Console.WriteLine("I have chosen a magic number between 1 and 10. Can you guess it?");

            
            while (guessing)
            {
                Console.Write("Enter your guess: ");

                
                int guessedNumber;
                while (!int.TryParse(Console.ReadLine(), out guessedNumber))
                {
                    Console.Write("Please enter a valid number: ");
                }

                attempts++;

                if (guessedNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessedNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"The number of attempts was: {attempts}");
                    guessing = false;
                }
            }

            
            string answer;
            while (true)
            {
                Console.Write("Do you want to play again? (yes/no): ");
                answer = Console.ReadLine().ToLower().Trim();

                if (answer == "yes" || answer == "no")
                    break;
                else
                    Console.WriteLine("Please type 'yes' or 'no'.");
            }

            playAgain = (answer == "yes");
        }

        Console.WriteLine("Thanks for playing!");
    }
}

