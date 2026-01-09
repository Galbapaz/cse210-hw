using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        int sumTotal = 0;
        double average = 0;
        int maxNumber = 0;
        int smallestPositive = int.MaxValue;

        int userNumber = -1;

        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

       
        foreach (var number in numbers)
        {
            sumTotal += number;
        }

        Console.WriteLine($"The sum is: {sumTotal}");

        if (numbers.Count > 0)
        {
            
            average = (double)sumTotal / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            
            maxNumber = numbers[0];
            foreach (var number in numbers)
            {
                if (number > maxNumber)
                {
                    maxNumber = number;
                }
            }
            Console.WriteLine($"The largest number is: {maxNumber}");

           
            foreach (var number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

            Console.WriteLine($"The smallest positive number is: {smallestPositive}");

            
            numbers.Sort();

            Console.WriteLine("The sorted list is:");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}

    

