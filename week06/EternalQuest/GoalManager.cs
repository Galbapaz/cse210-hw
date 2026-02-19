using System;
using System.Collections.Generic;
using System.IO;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    private int _level = 1;
    private int _streak = 0;

    public void Start()
    {
        while (true)
        {
            Console.WriteLine("\n=== Eternal Quest ===");
            Console.WriteLine($"Score: {_score} | Level: {_level} | Streak: {_streak}");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Load");
            Console.WriteLine("6. Exit");
            Console.Write("> ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1": CreateGoal(); break;
                case "2": ListGoalDetails(); break;
                case "3": RecordEvent(); break;
                case "4": SaveGoals(); break;
                case "5": LoadGoals(); break;
                case "6": return;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("1.Simple 2.Eternal 3.Checklist 4.Negative");
        string type = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string desc = Console.ReadLine();

        Console.Write("Points: ");
        int pts = int.Parse(Console.ReadLine());

        if (type == "1")
            _goals.Add(new SimpleGoal(name, desc, pts));
        else if (type == "2")
            _goals.Add(new EternalGoal(name, desc, pts));
        else if (type == "3")
        {
            Console.Write("Target count: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, pts, target, bonus));
        }
        else if (type == "4")
            _goals.Add(new NegativeGoal(name, desc, pts));
    }

    private void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Select goal: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        int earned = _goals[index].RecordEvent();

        if (earned > 0)
            _streak++;
        else
            _streak = 0;

        if (_streak >= 3)
        {
            int bonus = (int)(earned * 0.2);
            earned += bonus;
            Console.WriteLine($"🔥 Streak bonus! +{bonus} points");
        }

        earned = (int)(earned * (1 + (_level - 1) * 0.1));

        _score += earned;

        if (_score >= _level * 1000)
        {
            _level++;
            Console.WriteLine("⭐ LEVEL UP!");
        }

        Console.WriteLine($"You earned {earned} points!");
    }

    private void SaveGoals()
    {
        using (StreamWriter sw = new StreamWriter("goals.txt"))
        {
            sw.WriteLine($"{_score}|{_level}|{_streak}");
            foreach (var g in _goals)
                sw.WriteLine(g.GetStringRepresentation());
        }
    }

    private void LoadGoals()
    {
        if (!File.Exists("goals.txt")) return;

        _goals.Clear();
        string[] lines = File.ReadAllLines("goals.txt");

        string[] meta = lines[0].Split('|');
        _score = int.Parse(meta[0]);
        _level = int.Parse(meta[1]);
        _streak = int.Parse(meta[2]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(':');
            string[] data = parts[1].Split(',');

            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2])));

            if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2])));

            if (parts[0] == "ChecklistGoal")
                _goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4])));

            if (parts[0] == "NegativeGoal")
                _goals.Add(new NegativeGoal(data[0], data[1], int.Parse(data[2])));
        }
    }
}
