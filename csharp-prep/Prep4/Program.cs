using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        //Initalize variables
       List<int> numbers = new List<int>();
       int sum = 0;
       int count = 0;
       int average = 0;

       Console.Write("Please enter a number (enter 0 to stop): ");
       string userNumber = Console.ReadLine();
       int newNum = int.Parse(userNumber);
       numbers.Add(newNum);

       int highNum = numbers[0];

        //Add numbers to the list until 0 is entered
       while (newNum != 0)
        {
            Console.Write("Please enter another number: ");
            userNumber = Console.ReadLine();
            newNum = int.Parse(userNumber);

            if (newNum != 0)
            {
               numbers.Add(newNum); 
            }
            
        }

        //find the sum
        foreach (int number in numbers)
        {
            sum = number + sum;
            count = ++count;

            //Find Highest Number
            if (highNum < number)
            {
                highNum = number;
            }
        }

        //find average 
        average = sum / count;

        //Print Answers
        Console.WriteLine($"The sum is {sum}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The highest number is {highNum}");
    }
}