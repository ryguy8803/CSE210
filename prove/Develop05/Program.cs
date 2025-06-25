class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine($"\nYou have {_score} points.");

            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choiceInput = Console.ReadLine();
            int choice = int.Parse(choiceInput);

            HandleMenuChoice(choice);
            if (choice == 6)
            {
                break;
            }
        }
    }
    static void HandleMenuChoice(int choice)
    {
        if (choice == 1)
        {
            CreateNewGoal();
        }
        else if (choice == 2)
        {
            ListGoals();
        }
        else if (choice == 3)
        {
            SaveGoals();
        }
        else if (choice == 4)
        {
            LoadGoals();
        }
        else if (choice == 5)
        {
            RecordEvent();
        }
        else if (choice == 6)
        {
            Console.WriteLine("Goodbye!");
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid option (1-6).");
        }
    }

    static void CreateNewGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalTypeInput = Console.ReadLine();

        int goalTypeChoice = int.Parse(goalTypeInput);

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        string pointsInput = Console.ReadLine();
        int points = int.Parse(pointsInput);

        if (goalTypeChoice == 1)
        {
            _goals.Add(new SimpleGoal(name, description, points));
            Console.WriteLine("Simple Goal created successfully!");
        }
        else if (goalTypeChoice == 2)
        {
            _goals.Add(new EternalGoal(name, description, points));
            Console.WriteLine("Eternal Goal created successfully!");
        }
        else if (goalTypeChoice == 3)
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string targetInput = Console.ReadLine();
            int targetAmount = int.Parse(targetInput);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusInput = Console.ReadLine();
            int bonusPoints = int.Parse(bonusInput);

            _goals.Add(new ChecklistGoal(name, description, points, targetAmount, bonusPoints));
            Console.WriteLine("Checklist Goal created successfully!");
        }
        else
        {
            Console.WriteLine("Invalid goal type choice. Goal not created.");
        }
    }

    static void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nYou have no goals yet. Create some!");
            return;
        }

        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetStatus()} {goal.GetName()} ({goal.GetDetails()})");
        }
    }

    static void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully!");
    }

    static void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        _goals.Clear();

        using (StreamReader inputFile = new StreamReader(filename))
        {
            _score = int.Parse(inputFile.ReadLine());

            string line;
            while ((line = inputFile.ReadLine()) != null)
            {
                Goal loadedGoal = CreateGoalFromString(line);
                if (loadedGoal != null)
                {
                    _goals.Add(loadedGoal);
                }
            }
        }
        Console.WriteLine("Goals loaded successfully!");
    }

    static Goal CreateGoalFromString(string data)
    {
        string[] parts = data.Split(':', 2);
        string goalType = parts[0];
        string[] details = parts[1].Split(',');

        string name = details[0];
        string description = details[1];
        int points = int.Parse(details[2]);

        if (goalType == "SimpleGoal")
        {
            bool isComplete = bool.Parse(details[3]);
            return new SimpleGoal(name, description, points, isComplete);
        }
        else if (goalType == "EternalGoal")
        {
            return new EternalGoal(name, description, points);
        }
        else if (goalType == "ChecklistGoal")
        {
            int targetAmount = int.Parse(details[3]);
            int bonusPoints = int.Parse(details[4]);
            int amountCompleted = int.Parse(details[5]);
            return new ChecklistGoal(name, description, points, targetAmount, bonusPoints, amountCompleted);
        }
        else
        {
            return null;
        }
    }

    static void RecordEvent()
    {
        // error hendeler
        if (_goals.Count == 0)
        {
            Console.WriteLine("\nYou have no goals to record. Create some first!");
            return;
        }

        Console.WriteLine("\nThe goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {(_goals[i].IsComplete() ? "[X]" : "[ ]")} {_goals[i].GetName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        string goalIndexInput = Console.ReadLine();

        int goalIndex = int.Parse(goalIndexInput);

        Goal selectedGoal = _goals[goalIndex - 1];
        int pointsEarned = selectedGoal.RecordEvent();
        _score += pointsEarned;

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
        Console.WriteLine($"You now have {_score} points.");
    }
}
