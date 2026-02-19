using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        STRETCH CHALLENGES

        To exceed the basic requirements, I added an improved breathing animation.
        Instead of only showing a countdown, the breathing activity now displays
        a visual animation that grows during inhale and shrinks during exhale.
        This creates a smoother and more realistic mindfulness experience.
        */


        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program\n");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect a choice: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                new BreathingActivity().Run();
            }
            else if (choice == "2")
            {
                new ReflectingActivity().Run();
            }
            else if (choice == "3")
            {
                new ListingActivity().Run();
            }
        }
    }
}
