using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        string choice = "";

        while (choice != "7")
        {
            Console.WriteLine("\nEternal Quest");
            manager.DisplayScore();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Display Goals");
            Console.WriteLine("6. Save/Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Select a choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Goal name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                manager.AddGoal(new SimpleGoal(name, description, points));
            }
            else if (choice == "2")
            {
                Console.Write("Goal name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                manager.AddGoal(new EternalGoal(name, description, points));
            }
            else if (choice == "3")
            {
                Console.Write("Goal name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                Console.Write("Target completions: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus));
            }
            else if (choice == "4")
            {
                manager.DisplayGoals();

                Console.Write("Which goal did you complete? ");
                int goalNumber = int.Parse(Console.ReadLine());

                manager.RecordEvent(goalNumber - 1);
            }
            else if (choice == "5")
            {
                manager.DisplayGoals();
            }
            else if (choice == "6")
            {
                Console.WriteLine("1. Save goals");
                Console.WriteLine("2. Load goals");
                Console.Write("Select a choice: ");
                string subChoice = Console.ReadLine();

                Console.Write("Filename: ");
                string filename = Console.ReadLine();

                if (subChoice == "1")
                {
                    manager.SaveGoals(filename);
                }
                else if (subChoice == "2")
                {
                    manager.LoadGoals(filename);
                }
            }
        }

        /*
        ENHANCEMENT (beyond core requirements):
        Added a Rank/Level system in GoalManager (see GetRank()) that
        gives the user a title based on accumulated score -- Novice,
        Apprentice, Journeyman, Master, Grandmaster. This is separate
        from and in addition to the required goal types, points,
        and save/load functionality; it adds a progression/gamification
        layer that the spec does not ask for.
        */

        Console.WriteLine("Goodbye!");
    }
}