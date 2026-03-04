using System;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
    //    Square square = new Square("blue", 10);
    //    Console.WriteLine(square.GetColor());
    //    Console.WriteLine(square.GetArea());

       List<Shape> shapes = new List<Shape>();

       Square mySquare = new Square("yellow", 10);
       Rectangle myRectangle = new Rectangle("orange", 30, 14);
       Circle myCircle = new Circle("red", 7);

        shapes.Add(mySquare);
        shapes.Add(myCircle);
        shapes.Add(myRectangle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine();
        }

    }
}