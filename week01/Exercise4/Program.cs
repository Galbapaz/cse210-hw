using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    { 

      var numbers = new List<int>{}; 

      int sumTotal = 0; 
      double average = 0; 
      int maxNumber = 0; 

        int userNumber = -1;

        while (userNumber != 0 )

        {    Console.WriteLine("Enter a list of numbers,type 0 when finished: "); 
             userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)
            {
              numbers.Add(userNumber);
            }
            
        }

        foreach ( var number in numbers )
        {
            
            sumTotal += number; 
        }
        
        Console.WriteLine($"The sum of the numbers from the list is: {sumTotal}");  


        if (numbers.Count > 0)
        {
          average = (double)sumTotal / numbers.Count;
          Console.WriteLine($"The average is: {average}");
        

          for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }

            Console.WriteLine($"The largest number is: {maxNumber}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
        
    

    }
}