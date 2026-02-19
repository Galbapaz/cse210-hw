using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone.",
        "Think of a time you did something really difficult.",
        "Think of a time you helped someone in need.",
        "Think of a time you did something selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful?",
        "How did you feel when it was complete?",
        "What did you learn about yourself?",
        "What made this time different?",
        "How can you apply this in the future?"
    };

    public ReflectingActivity()
        : base("Reflecting",
        "This activity will help you reflect on moments of strength and resilience.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        Console.WriteLine($"\n{_prompts[random.Next(_prompts.Count)]}");
        Console.WriteLine("\nReflect on the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine($"\n> {_questions[random.Next(_questions.Count)]}");
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
}
