using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"\nYou have {_score} points.");
        Console.WriteLine($"Rank: {GetRank()}");
    }

    public void RecordEvent(int goalNumber)
    {
        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            int earned = _goals[goalNumber].RecordEvent();

            _score += earned;

            Console.WriteLine(
                $"Congratulations! You earned {earned} points.");

            Console.WriteLine(
                $"You now have {_score} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    // ENHANCEMENT (beyond core requirements):
    // A rank/title system tied to accumulated score. This is not
    // required by the assignment spec at all -- it's a motivational
    // layer on top of the point system, giving the user a sense of
    // progression beyond raw numbers.
    public string GetRank()
    {
        if (_score >= 10000) return "Grandmaster";
        if (_score >= 5000) return "Master";
        if (_score >= 2000) return "Journeyman";
        if (_score >= 500) return "Apprentice";
        return "Novice";
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Saved to {filename}.");
    }

    public void LoadGoals(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            string type = parts[0];

            if (type == "SimpleGoal")
            {
                Goal goal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4]))
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[4]));

                int amountCompleted = int.Parse(parts[6]);
                for (int j = 0; j < amountCompleted; j++)
                {
                    goal.RecordEvent();
                }

                _goals.Add(goal);
            }
        }

        Console.WriteLine($"Loaded from {filename}.");
    }
}