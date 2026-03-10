namespace RoundShapes;

class Program
{
    static void Main(string[] args)
    {


        // Circle steve = new Circle(4);
        // Cylinder mike = new Cylinder(10, 2);
        // Sphere sully = new Sphere(500);


        List<RoundShape> rollingStones = new List<RoundShape>();
        rollingStones.Add(new Circle(2));
        rollingStones.Add(new Cylinder(10,2));
        rollingStones.Add(new Sphere(500));

        foreach (RoundShape shape in rollingStones)
        {
            Console.WriteLine($"{shape.Area()}");
        }

        // Console.WriteLine($"{steve.Area()}\n{mike.Area()}\n{sully.Area()}");
    }
}
