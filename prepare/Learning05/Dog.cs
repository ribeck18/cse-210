class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        
    }

    public override void MakeNoise()
    {
        Console.WriteLine($"{_name} says: woof!");
    }
}