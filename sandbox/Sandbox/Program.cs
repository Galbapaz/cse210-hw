using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce the first number: ");
        int number_1 = int.Parse(Console.ReadLine()); 

        Console.WriteLine("Introduce the second number: ");
        int number_2 = int.Parse(Console.ReadLine()); 

        int suma = number_1 + number_2;
        Console.WriteLine("The final result is: " + suma); 
        

       
    }
}