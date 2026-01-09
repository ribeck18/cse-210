using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        Console.Write("What percent is your grade? ");
        string userInput = Console.ReadLine();
        int percent = int.Parse(userInput);

        string grade = "";

        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else 
        {
            grade = "F";
        }
        Console.WriteLine($"Your grade is a {grade}.");

        if (percent >= 70)
        {
            Console.WriteLine("You have passed the class!");
        }
        else
        {
            Console.WriteLine("You have failed the class!");
        }
    }
}