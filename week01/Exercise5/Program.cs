using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {  
         
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);
      
    }

    static void DisplayWelcome()
    {
      Console.WriteLine("Welcome to the program!"); 
    }

    static string PromptUserName()
    {
        
       Console.WriteLine("Please enter your name: "); 
       string userName = Console.ReadLine(); 


      return userName; 
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: "); 
        int favoriteNumber = int.Parse(Console.ReadLine()); 

        return favoriteNumber; 
    }

    static int SquareNumber(int number)
    {
        return number * number; 

    }

    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }


}