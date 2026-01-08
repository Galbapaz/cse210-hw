using System;

class Program
{
    static void Main(string[] args)
    {
        int lastDigit = 0; 
        Console.WriteLine("What is your grade percentage?");
        string gradePercentage = Console.ReadLine();
        double grade = double.Parse(gradePercentage);
        string letterGrade = "";
        if (grade >= 90)
        {
            letterGrade = "A";
            lastDigit = (int)grade % 10; 
            if (lastDigit >= 7 && grade < 100)
            {   
                letterGrade += "+";
            }
            else if (lastDigit < 3)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            lastDigit = (int)grade % 10; 
            if (lastDigit >= 7 && grade < 100)
            {   
                letterGrade += "+";
            }
            else if (lastDigit < 3)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            lastDigit = (int)grade % 10; 
            if (lastDigit >= 7 && grade < 100)
            {   
                letterGrade += "+";
            }
            else if (lastDigit < 3)
            {
                letterGrade += "-";
            }
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            lastDigit = (int)grade % 10; 
            if (lastDigit >= 7 && grade < 100)
            {   
                letterGrade += "+";
            }
            else if (lastDigit < 3)
            {
                letterGrade += "-";
            }

        }
        else
        {
            letterGrade = "F";
            lastDigit = (int)grade % 10; 
            if (lastDigit >= 7 && grade < 100)
            {   
                letterGrade += "+";
            }
            else if (lastDigit < 3)
            {
                letterGrade += "-";
            }
        }
        Console.WriteLine($"Your grade is {letterGrade}.");
        if( letterGrade == "A" || letterGrade == "B" || letterGrade == "C")
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass. Better luck next time!");
        }
    }
}