using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        bool runMenu = true;

        Console.WriteLine("Welcome to the goal application.");

        //Initalize Objects
        List<Goal> goalList = new List<Goal>();
        BadgeSash sash = new BadgeSash();
        AwardBadge award = new AwardBadge();
        Stats playerStats = new Stats();

        while (runMenu)
        {
            int currentScore = menu.GetTotalScore(goalList);

            Console.WriteLine($"Your current score is {currentScore}");
            int menuChoice = menu.MainMenu();
            if (menuChoice == 1)
            {
                Goal newGoal = menu.CreateGoal();
                goalList.Add(newGoal);
            }
            else if (menuChoice == 2)
            {
                foreach (Goal goal in goalList)
                {
                    Console.WriteLine(goal.GetGoalString());
                }

                continue;
            }
            else if (menuChoice == 3)
            {
                Console.WriteLine("Please enter the file name.");
                Console.Write(">");
                string fileName = Console.ReadLine();
                menu.SaveGoals(goalList, fileName, sash);

                continue;
            }
            else if (menuChoice == 4)
            {
                Console.WriteLine("Please enter a file to load.");
                Console.Write(">");
                string fileName = Console.ReadLine();
                goalList = menu.LoadGoals(fileName, sash);
                playerStats.UpdateScore(menu.GetTotalScore(goalList));
                playerStats.UpdateGoals(goalList.Count);
                foreach (Goal goal in goalList)
                {
                    string type = goal.GetType().ToString();
                    bool isComplete;
                    if (type == "ChecklistGoal")
                    {
                        isComplete = goal.GetCompletion();
                        playerStats.updateChecklist(isComplete);
                        break;
                    }
                }

                continue;
            }
            else if (menuChoice == 5)
            {
                menu.RecordEvent(goalList, playerStats);
            }
            else if (menuChoice == 6)
            {
                sash.DisplaySash();
            }
            //Delete this after debug session.
            else if (menuChoice == 7)
            {
                Console.WriteLine("Thanks for using the program!");
                break;
            }
            else
            {
                Console.WriteLine("Invlaid choice, please select 1, 2, 3, 4, 5, 6, or 7.");
                continue;
            }

            //Badge system
            award.CompleteBadges(playerStats, sash);
        }
    }
}
