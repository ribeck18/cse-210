class Pig : Animal
{
    public Pig(string name) : base(name)
    {
        
    }

    public override void MakeNoise() //use override in the child class
    {
        Console.WriteLine($"{_name} says: oink!");
    }
}