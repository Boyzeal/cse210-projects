
using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // This program includes a Level System that goes beyond the
        // assignment requirements. As users earn points from completing
        // goals, they advance through levels and receive special titles.
        // This provides additional gamification and motivation for users
        // to continue working toward their goals.

        GoalManager manager = new GoalManager();

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("=== Eternal Quest ===");
            Console.WriteLine($"Current Score: {manager.GetScore()}");
            Console.WriteLine($"Current Title: {GetLevelTitle(manager.GetScore())}");
            Console.WriteLine();

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");

            Console.Write("\nSelect an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateGoal(manager);
                    break;

                case "2":
                    Console.Clear();
                    manager.DisplayGoals();
                    Pause();
                    break;

                case "3":
                    Console.Clear();

                    manager.DisplayGoals();

                    Console.Write("\nWhich goal did you accomplish? ");
                    int goalNumber = int.Parse(Console.ReadLine());

                    manager.RecordGoal(goalNumber - 1);

                    Console.WriteLine(
                        $"Current Title: {GetLevelTitle(manager.GetScore())}");

                    Pause();
                    break;

                case "4":
                    Console.Write("Filename: ");
                    string saveFile = Console.ReadLine();

                    manager.SaveGoals(saveFile);

                    Console.WriteLine("Goals saved successfully.");
                    Pause();
                    break;

                case "5":
                    Console.Write("Filename: ");
                    string loadFile = Console.ReadLine();

                    manager.LoadGoals(loadFile);

                    Console.WriteLine("Goals loaded successfully.");
                    Pause();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    Pause();
                    break;
            }
        }
    }

    static void CreateGoal(GoalManager manager)
    {
        Console.Clear();

        Console.WriteLine("Goal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("\nSelect a goal type: ");
        string choice = Console.ReadLine();

        Console.Write("Goal Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                manager.AddGoal(
                    new SimpleGoal(name, description, points));
                break;

            case "2":
                manager.AddGoal(
                    new EternalGoal(name, description, points));
                break;

            case "3":
                Console.Write("Target Count: ");
                int targetCount = int.Parse(Console.ReadLine());

                Console.Write("Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        targetCount,
                        bonus));
                break;

            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }

        Console.WriteLine("Goal created successfully!");
        Pause();
    }

    static string GetLevelTitle(int score)
    {
        if (score >= 10000)
            return "🏆 Eternal Champion";

        if (score >= 5000)
            return "⭐ Master Disciple";

        if (score >= 2500)
            return "⚔️ Faithful Adventurer";

        if (score >= 1000)
            return "🌟 Rising Saint";

        return "🌱 Beginner";
    }

    static void Pause()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}

