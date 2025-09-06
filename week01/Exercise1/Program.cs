using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your first name? ");
        String name = Console.ReadLine();

        Console.WriteLine("What is your last name? ");
        String Last_name = Console.ReadLine();

        name = char.ToUpper(name[0]) + name.Substring(1).ToLower();
        Last_name = char.ToUpper(Last_name[0]) + Last_name.Substring(1).ToLower();
        
        
        Console.WriteLine($"Your name is {Last_name}, {name} {Last_name}."); 



    }
}