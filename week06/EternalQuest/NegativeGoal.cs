public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
        return -_points; 
    }

    public override bool IsComplete() => false;

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{_shortName},{_description},{_points}";
    }

    public override string GetDetailsString()
    {
        return $"[!] {_shortName} ({_description}) -- Lose {_points} points";
    }
}
