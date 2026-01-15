using System;
using System.Reflection.Metadata;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNum = Console.ReadLine();
        int num = int.Parse(userNum);
        return num;
    }

    static void PropmtUserBirthYear(out int userBirthYear)
    {
        Console.Write("What year were you born? ");
        string enteredBirthYear = Console.ReadLine();
        userBirthYear = int.Parse(enteredBirthYear);
    }

    static int SquareNumber(int num)
    {
        int squaredNum = num * num;
        return squaredNum;
    }

    static void DisplayResult(string name, int num, int birth)
    {
      Console.WriteLine($"Your name is {name}, and your number squared is {num}.");

      //Find user age 
      int userAge = 2026 - birth;

      Console.WriteLine($"You will be {userAge} years old this year."); 
    }

    static void Main(string[] args)
    {
        //establish variable
       int userBirthYear;

       DisplayWelcome();

       string name = PromptUserName();

       int number = PromptUserNumber();

       PropmtUserBirthYear(out userBirthYear);

       int squareNum = SquareNumber(number);

       DisplayResult(name, squareNum, userBirthYear);


    }
       
}