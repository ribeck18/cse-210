using System;

class Program
{
    //To Do List: Extra credit option - use .JSON instead of .txt
    
    static void Main(string[] args)
    {
        //Create the prompt list
        Prompts promptList = new Prompts();
        promptList._questions = [];
        promptList.AddPrompt("In what way(s) did I grow today?");
        promptList.AddPrompt("What am I most grateful for today?");
        promptList.AddPrompt("How did I see the hand of the Lord in my life today?");
        promptList.AddPrompt("What was the strongest emotion I felt today?");
        promptList.AddPrompt("What challenged me today, and how did I respond to it?");

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