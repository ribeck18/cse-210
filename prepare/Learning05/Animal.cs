abstract class  Animal
{
    protected string _name;

    public Animal(string name)
    {
        _name = name;
    }

    // public virtual void MakeNoise() //Use virtual in the parent class if you want animal to still be callable. 
    // {
    //    Console.WriteLine($"{_name} says: I don't know what I am and make no noise."); 
    // }


    public abstract void MakeNoise(); //If it is abstract, the method must be defined in the child. and the parent class can not be instantiated.
}