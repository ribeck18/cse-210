using System;

class Program
{
    //To Do List: 
    //Things Done since last commit: Way to choose file to save to and way to choose file to load from.
    static void Main(string[] args)
    {
        //Create the prompt list
        Prompts promptList = new Prompts();
        promptList._questions = [];
        promptList.AddPrompt("Who was the most interesting person I interacted with today?");
        promptList.AddPrompt("What was the best part of my day?");
        promptList.AddPrompt("How did I see the hand of the Lord in my life today?");
        promptList.AddPrompt("What was the strongest emotion I felt today?");
        promptList.AddPrompt("If had one thing I could do over today, what would it be?");

        string menuSelect = "";
        Journal myJournal = new Journal();
        while (menuSelect != "q")
        {
            //Menu
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Write\n2. Display\n3. Load\n4. Save\n5.Quit");
            Console.Write(">");
            menuSelect = Console.ReadLine();

            if (menuSelect == "1")
            {
                //Get a new prompt
                string journalPrompt = promptList.GetPrompt();

                //Create an entry and add it to the journal
                Entry newEntry = new Entry();
                newEntry.NewEntry(journalPrompt);
                myJournal.AddEntry(newEntry);

            }
            else if (menuSelect == "2")
            {
               //Display the entire journal
               myJournal.DisplayJournal();
            }
            else if (menuSelect == "3")
            {
                //Load the journal from the txt file
                myJournal.Load();

            }
            else if (menuSelect == "4")
            {
                //Save the current journal object to the txt file.
                myJournal.Save();
            }
            else
            {
                break;
            }
        }

    }
}