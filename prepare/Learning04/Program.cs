using System;

class Program
{
    static void Main(string[] args)
    {
        //Test assignment
        Assignment testAssignment = new Assignment("Joe", "School stuff!");
        Console.WriteLine(testAssignment.GetSummary());

        //Test math assignment
        MathAssignment testMath = new MathAssignment("Jerry", "Math", "6-7", "10-20");
        Console.WriteLine(testMath.GetSummary());
        Console.WriteLine(testMath.GetHomeworkList());

        //Test english assignment
        WritingAssignment testWrite = new WritingAssignment("Sally", "English", "Hugger McHuggerson's Special Apperance.");
        Console.WriteLine(testWrite.GetSummary());
        Console.WriteLine(testWrite.getWritingInformation());
    }
}