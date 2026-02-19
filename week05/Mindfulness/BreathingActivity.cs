using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity will help you relax by guiding you through slow breathing. Clear your mind and focus on your breathing."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < futureTime)
        {
            Console.WriteLine();
            Console.WriteLine("Inhale...");
            AnimateBreathing(true, 4);

            Console.WriteLine();
            Console.WriteLine("Exhale...");
            AnimateBreathing(false, 4);
        }

        DisplayEndingMessage();
    }

    private void AnimateBreathing(bool inhale, int seconds)
    {
        int steps = seconds * 4; 
        int maxSize = 20;

        for (int i = 0; i < steps; i++)
        {
            double progress = (double)i / steps;

            int size;

            if (inhale)
            {
                size = (int)(progress * maxSize);
            }
            else
            {
                size = (int)((1 - progress) * maxSize);
            }

            string animation = new string('O', size);

            Console.Write("\r" + animation);
            Thread.Sleep(250);
        }

        Console.Write("\r" + new string(' ', maxSize) + "\r");
        
            
        }
}
