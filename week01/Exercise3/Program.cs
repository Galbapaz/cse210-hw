using System;
using System.Diagnostics;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
    Random randomGenerator = new Random();
    int magicNumber = randomGenerator.Next(1, 11); 

        bool response = true; 

        while (response == true) 
        {
          Console.WriteLine("What is your guess?"); 
          int guessedNumber = int.Parse(Console.ReadLine()); 

            
             if (guessedNumber < magicNumber)
            {
                 Console.WriteLine("Higher");
            }
            else if (guessedNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            if (guessedNumber == magicNumber)
            
            {
                response = false; 
            }

        }
        Console.WriteLine(" You guessed it! " ); 
           
        
    }
}