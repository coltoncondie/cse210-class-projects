using System;
// I used Chat Gpt to assist me in structure. My goal was to use a interface to improve the functionality of the Eternal Quest program. This is what I have....
public class Program
{
    public static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager(); // Instantiate the GoalManager

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    ListGoals(goalManager);
                    break;
                case "3":
                    SaveGoals(goalManager);
                    break;
                case "4":
                    LoadGoals(goalManager);
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    Console.WriteLine("GoodBye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }

    private static void CreateNewGoal(GoalManager goalManager)
    {
        Console.Clear();
        Console.WriteLine("The type of goals to choose from are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");

        string goalTypeChoice = Console.ReadLine();
        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();

        Console.WriteLine("What would you like the point value to be?");
        Console.WriteLine("1. 50 points");
        Console.WriteLine("2. 75 points");
        Console.WriteLine("3. 100 points");
        Console.Write("Select an option: ");
        int points = ParsePointChoice();

        Goal newGoal = null;

        switch (goalTypeChoice)
        {
            case "1":
                newGoal = new SimpleGoal(name, description, points);
                break;
            case "2":
                newGoal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.Write("What is the target number for completion? ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for completing the goal?");
                Console.WriteLine("1. 500 points");
                Console.WriteLine("2. 750 points");
                Console.WriteLine("3. 1000 points");
                Console.Write("Select an option: ");
                int bonus = ParseBonusChoice();
                newGoal = new ChecklistGoal(name, description, points, target, bonus);
                break;
            default:
                Console.WriteLine("Invalid goal type. Returning to the main menu.");
                return;
        }
        goalManager.AddGoal(newGoal);
        Console.WriteLine($"Goal '{name}' has been created and added to your list.");
    }
    private static void ListGoals(GoalManager goalManager)
    {
        Console.Clear();
        if (goalManager.Goals.Count == 0)
        {
            Console.WriteLine("You have not recently added any goals. Please Try again or load previous save at menu...");
        }
        else
        {
            Console.WriteLine("Your Goals:");
            foreach (var goal in goalManager.Goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }
    }

    private static void SaveGoals(GoalManager goalManager)
    {
        Console.Clear();
        while (true)
        {
            Console.Write("What would you like the name of your file to be saved as? ");
            string fileName = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(fileName))
            {
                Console.WriteLine("You did not select a filename. Please try again.");
            }
            else
            {
                goalManager.SaveGoals($"{fileName}.txt");
                Console.WriteLine($"Your goals have been saved to {fileName}.txt.");
                break;
            }
        }
    }

    private static void LoadGoals(GoalManager goalManager)
    {
        Console.Clear();
        Console.Write("What file would you like to load? ");
        string fileName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fileName))
        {
            Console.WriteLine("You did not specify a file. Returning to the menu...");
        }
        else if (!goalManager.LoadGoals(fileName))
        {
            Console.WriteLine("The file that you have requested does not exist. Returning to the menu...");
        }
        else
        {
            Console.WriteLine($"Goals from {fileName} have been successfully loaded.");
        }
    }

    private static void RecordEvent(GoalManager goalManager)
    {
        Console.Clear();
        if (goalManager.Goals.Count == 0)
        {
            Console.WriteLine("You have no goals to mark as done. Add or load goals first.");
        }
        else
        {
            Console.WriteLine("Your Goals:");
            for (int i = 0; i < goalManager.Goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goalManager.Goals[i].ShortName}");
            }

            Console.Write("Which goal do you wish to mark done? ");
            if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= goalManager.Goals.Count)
            {
                goalManager.Goals[choice - 1].RecordEvent();
            }
            else
            {
                Console.WriteLine("Invalid selection. Returning to the menu...");
            }
        }
    }

    private static int ParsePointChoice()
    {
        while (true)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": return 50;
                case "2": return 75;
                case "3": return 100;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }

    private static int ParseBonusChoice()
    {
        while (true)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "1": return 500;
                case "2": return 750;
                case "3": return 1000;
                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        }
    }
}