using System;

class Program
{

    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths");

        int wordsToHide = 2;
        DateTime startTime = DateTime.Now;

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                return;

            scripture.HideRandomWords(wordsToHide);
            wordsToHide += 2; 
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        DateTime endTime = DateTime.Now;
        TimeSpan duration = endTime - startTime;

        Console.WriteLine();
        Console.WriteLine("Now type the scripture from memory:");
        Console.WriteLine();

        string userAttempt = Console.ReadLine();
        string originalText = scripture.GetOriginalText();

        Console.WriteLine();

        if (userAttempt.Trim().ToLower() == originalText.ToLower())
        {
            Console.WriteLine("Amazing! You memorized it correctly! 🎉");
        }
        else
        {
            Console.WriteLine("Good try! Here is the correct scripture:");
            Console.WriteLine();
            Console.WriteLine(originalText);
        }

        Console.WriteLine();
        Console.WriteLine($"Time taken: {duration.TotalSeconds:0} seconds");
    }
}
