using System;
using System.Threading.Tasks.Dataflow;
using Resumes;



class Program
{
    static void Main(string[] args)
    {
            Job job1 = new Job();   // Create Object 
            Job job2 = new Job(); 

            job1._jobTitle = "Teacher";
            job1._company = "Thumim";
            job1._startYear = 2025;
            job1._endYear = "Present"; 

            job2._jobTitle = "Teacher";
            job2._company = "Focus your mind";
            job2._startYear = 2024;
            job2._endYear = "December 2024"; 

            

            job1.Display(); 

            job2.Display(); 
             

            Console.ReadLine(); 
    }
}