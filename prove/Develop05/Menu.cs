using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

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
            Console.WriteLine("The types of goals are:\n1.Simple Goal\n2. Eternal Goal\n3. Checklist Goal\nWhat type of goal would you like to create?");
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
            Console.WriteLine($"What is the bonus value for your goal when it is completed {completions} times?");
            int bonus = GetUserChoice();

            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, pointValue, completions, bonus);
            newGoal = checklistGoal;
        }
        return newGoal; 
    }
}