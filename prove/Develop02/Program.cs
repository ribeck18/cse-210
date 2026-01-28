using System;

class Program
{
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
        Console.WriteLine(myPrompt);


    }
}