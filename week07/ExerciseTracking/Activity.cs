using System;

namespace ExerciseTracking;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    protected int GetMinutes() => _minutes;

    protected string GetDateString() => _date.ToString("dd MMM yyyy");

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract string GetActivityName();

    public string GetSummary()
    {
        return $"{GetDateString()} {GetActivityName()} ({_minutes} min): " +
               $"Distance {GetDistance():0.0} km, " +
               $"Speed {GetSpeed():0.0} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }
}
