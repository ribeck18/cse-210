using System;

class Program
{
    static void Main(string[] args)
    {
        //testing constructers 
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(5);
        Fraction fraction2 = new Fraction(3,4);

        //testing getters & setters
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetBottom());
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetTop());
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimelValue());
        Console.WriteLine(fraction1.GetDecimelValue());


        //Assignment 
        Fraction myFraction = new Fraction();
        Random myRandom = new Random();

        int count = 0;
        while (count != 20)
        {
            count ++;

            int top = myRandom.Next(1,20);
            int bottom = myRandom.Next(1,20);
            myFraction.SetTop(top);
            myFraction.SetBottom(bottom);
            
            Console.WriteLine($"Fraction {count}: String: {myFraction.GetFractionString()} Number: {myFraction.GetDecimelValue()}");
        }

    }
}