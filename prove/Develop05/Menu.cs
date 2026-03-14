using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;

class Menu
{
    /// <summary>
    /// Gets a user input from the console and returns it as an int.
    /// </summary>
    /// <returns>User entered data as int</returns>
    private int GetUserChoice()
    {
        Console.Write(">");
        string choice = Console.ReadLine();

        return int.Parse(choice);
    }

    public int GetTotalScore(List<Goal> goalList)
    {
        int score = 0;
        foreach (Goal goal in goalList)
        {
            score = score + goal.GetTotalPoints();
        }

        return score;
    }

    /// <summary>
    /// Asks a user for information to create a goal and creates the goal according to user input. Checks that user does not attempet to make a goal that doesnt exist.
    /// </summary>
    /// <returns>Goal object</returns>
    public Goal CreateGoal()
    {
        Goal newGoal;
        int choice = 0;

        while (choice != 1 && choice != 2 && choice != 3)
        {
            Console.WriteLine(
                "The types of goals are:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhat type of goal would you like to create?"
            );
            choice = GetUserChoice();
        }
        Console.WriteLine("Please enter a name for your goal.");
        Console.Write(">");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter a description for your goal.");
        Console.Write(">");
        string description = Console.ReadLine();
        Console.WriteLine("Please enter a point value for your goal.");
        int pointValue = GetUserChoice();

        if (choice == 1)
        {
            SimpleGoal simpleGoal = new SimpleGoal(name, description, pointValue);
            newGoal = simpleGoal;
        }
        else if (choice == 2)
        {
            EternalGoal eternalGoal = new EternalGoal(name, description, pointValue);
            newGoal = eternalGoal;
        }
        else
        {
            Console.WriteLine("How many times should the goal be completed?");
            int completions = GetUserChoice();
            Console.WriteLine(
                $"What is the bonus value for your goal when it is completed {completions} times?"
            );
            int bonus = GetUserChoice();

            ChecklistGoal checklistGoal = new ChecklistGoal(
                name,
                description,
                pointValue,
                completions,
                bonus
            );
            newGoal = checklistGoal;
        }
        return newGoal;
    }

    /// <summary>
    /// Displays all of the goals in the goalList as strings.
    /// </summary>
    /// <param name="goalList">list of Goal objects</param>
    public void DisplayGoals(List<Goal> goalList)
    {
        int count = 0;
        foreach (Goal goal in goalList)
        {
            count += 1;
            Console.WriteLine($"{count}. {goal.GetGoalString()}");
        }
    }

    /// <summary>
    /// Saves the working goal list to a file
    /// </summary>
    /// <param name="goalList">Working list of goals</param>
    /// <param name="fileName">filename</param>
    public void SaveGoals(List<Goal> goalList, string filePath)
    {
        using (StreamWriter output = new StreamWriter(filePath))
        {
            foreach (Goal goal in goalList)
            {
                output.WriteLine(goal.GetSaveString());
            }
        }
    }

    /// <summary>
    /// Loads all of the goals from the saved goals files as strings. Converts each goal string into the correct goal object.
    /// </summary>
    /// <param name="fileName">path of file to be loaded</param>
    /// <returns>list of goal objects</returns>
    public List<Goal> LoadGoals(string fileName)
    {
        string[] goalStringList = File.ReadAllLines(fileName);
        List<Goal> goalList = [];

        foreach (string goalString in goalStringList)
        {
            string[] parts = goalString.Split("|");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int pointValue = int.Parse(parts[3]);
            int totalPoints = int.Parse(parts[4]);
            bool isComplete = bool.Parse(parts[5]);
            if (type == "ChecklistGoal")
            {
                int completionCount = int.Parse(parts[6]);
                int requiredCompletes = int.Parse(parts[7]);
                int bonusValue = int.Parse(parts[8]);

                ChecklistGoal checklistGoal = new ChecklistGoal(
                    name,
                    description,
                    pointValue,
                    totalPoints,
                    isComplete,
                    requiredCompletes,
                    bonusValue,
                    completionCount
                );
                goalList.Add(checklistGoal);
            }
            else if (type == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal(
                    name,
                    description,
                    pointValue,
                    totalPoints,
                    isComplete
                );
                goalList.Add(simpleGoal);
            }
            else
            {
                EternalGoal eternalGoal = new EternalGoal(
                    name,
                    description,
                    pointValue,
                    totalPoints,
                    isComplete
                );
                goalList.Add(eternalGoal);
            }
        }
        return goalList;
    }

    /// <summary>
    /// Records a completion event for a Goal from goalList that the user selects.
    /// </summary>
    /// <param name="goalList"></param>
    public void RecordEvent(List<Goal> goalList)
    {
        int count = 0;
        Console.WriteLine("which goal did you complete?");
        foreach (Goal goal in goalList)
        {
            count += 1;
            Console.WriteLine($"{count}. {goal.GetGoalString()}");
        }

        int choice = GetUserChoice();

        Goal userGoal = goalList[choice - 1];
        userGoal.CompletionEvent();

        Console.WriteLine($"Great job, you recieved {userGoal.GetPointValue()} points!");

        if (userGoal is ChecklistGoal checklistGoal)
        {
            if (userGoal.GetCompletion() == true)
            {
                Console.WriteLine(
                    $"Congratulations you recieved a bonus of {checklistGoal.GetBonus()} points!"
                );
            }
        }
        Console.WriteLine($"Your total score is {GetTotalScore(goalList)}");
    }

    public int MainMenu()
    {
        Console.WriteLine(
            "What would you like to do?\n\n1. Create a Goal\n2. List Goals\n3. Save Goals\n4. Load Goals\n5. Record Action\n6. Quit"
        );
        Console.Write(">");
        int.TryParse(Console.ReadLine(), out int userChoice);

        return userChoice;
    }
}
