public class Lion : Animal
{
    public Lion(string name, int age) : base(name, age) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} is running.");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} sleeps in the forest.");
    }

    public override string Speak()
    {
        return $"{Name} roars.";
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} eats meat.");
    }
}

// Parrot class
public class Parrot : Animal
{
    public Parrot(string name, int age) : base(name, age) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} flutters from branch to branch.");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} sleeps in the branches of a tree.");
    }

    public override string Speak()
    {
        return $"{Name} squawks.";
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} eats seeds and fruits.");
    }
}

// Turtle class
public class Turtle : Animal
{
    public Turtle(string name, int age) : base(name, age) { }

    public override void Move()
    {
        Console.WriteLine($"{Name} crawls slowly along the ground or swims in water.");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} sleeps in its shell or deep under the water.");
    }

    public override string Speak()
    {
        return $"{Name} makes a quiet sound.";
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} eats plants and small fish.");
    }
}