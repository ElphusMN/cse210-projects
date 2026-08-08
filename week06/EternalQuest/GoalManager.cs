using System;
using System.Collections.Generic;

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
    }
}