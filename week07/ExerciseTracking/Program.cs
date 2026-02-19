using System;
using System.Collections.Generic;

namespace ExerciseTracking;

class Program
{
    static void Main()
    {
        List<Activity> activities = new();

        activities.Add(new Running(new DateTime(2022, 11, 3), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2022, 11, 3), 30, 15.0));
        activities.Add(new Swimming(new DateTime(2022, 11, 3), 30, 40));

        foreach (Activity activity in activities)
            Console.WriteLine(activity.GetSummary());
    }
}
