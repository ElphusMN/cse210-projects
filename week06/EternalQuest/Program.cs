using System;

class Program
{
    static void Main(string[] args)
    {
        /*
        CREATIVITY:
        Added multiple goal types that use polymorphism,
        allowing the same RecordEvent() method to behave
        differently depending on the goal type. Also added
        score tracking so users can see their progress as
        they complete goals.
        */

        GoalManager manager = new GoalManager();

        string choice = "";

        while (choice != "5")
        {
            Console.WriteLine("\nEternal Quest");
            manager.DisplayScore();

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create Simple Goal");
            Console.WriteLine("2. Create Eternal Goal");
            Console.WriteLine("3. Create Checklist Goal");
            Console.WriteLine("4. Record Event");
            Console.WriteLine("5. Quit");

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

                manager.AddGoal(
                    new SimpleGoal(name, description, points));
            }
            else if (choice == "2")
            {
                Console.Write("Goal name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string description = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

            