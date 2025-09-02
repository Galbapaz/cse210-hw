using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Introduce your age: "); 
        string entrance = Console.ReadLine();
        int age = int.Parse(entrance);

        Console.WriteLine("your age is: " + age); 
    }
}