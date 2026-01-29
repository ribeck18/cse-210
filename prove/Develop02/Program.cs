using System;

class Program
{
    //To Do List: Finish journal class, finish entry class, 
    static void Main(string[] args)
    {
        //test the prompt class



        Prompts promptList = new Prompts();
        promptList._questions = [];
        promptList.AddPrompt("Who was the most interesting person I interacted with today?");
        promptList.AddPrompt("What was the best part of my day?");
        promptList.AddPrompt("How did I see the hand of the Lord in my life today?");
        promptList.AddPrompt("What was the strongest emotion I felt today?");
        promptList.AddPrompt("If had one thing I could do over today, what would it be?");

        string myPrompt = promptList.GetPrompt();
        


        //Test the Entry class

        Entry newEntry = new Entry();
        newEntry.NewEntry(myPrompt);
        Console.WriteLine(newEntry.DisplayEntry());



        //Test Program
        Journal myJournal = new Journal();
        myJournal.AddEntry(newEntry);
        myJournal.Save();

        //Test save to txt
        myJournal.Save();

    }
}