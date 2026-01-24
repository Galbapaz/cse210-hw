using System;
using Resumes;



class Program
{
    static void Main(string[] args)
    {
            Job job1 = new Job();   // Create Object 

            job1._jobTitle = "Teacher";
            job1._company = "Thumim";
            job1._startYear = 2025;
            job1._endYear = "Present"; 

            job1.Display(); 
             

            Console.ReadLine(); 
    }
}