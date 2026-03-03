using System;

class Program
{
    static void Main(string[] args)
    {
        // Animal myAnimal = new Animal("Jerry");
        // myAnimal.MakeNoise();
        // Pig myPig = new Pig("Bacon");
        // myPig.MakeNoise();
        // Dog myDog = new Dog("Oliver");


        List<Animal> myAnimals = new List<Animal>();

        myAnimals.Add(new Pig("Porky"));
        myAnimals.Add(new Dog("Doggy"));
        myAnimals.Add(new Fox("Yelvis"));
        myAnimals.Add(new Fox("Bro. Gibbions"));

        foreach (Animal critter in myAnimals)
        {
            critter.MakeNoise();
        }
    }
}