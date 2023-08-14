// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining abstract classes

// Declare an abstract base class to prevent direct instantiation
public abstract class Vehicle
{
    public Vehicle() {}

    public required string Model {
        get;
        init;
    }

    public required string Make {
        get;
        init;
    }

    public virtual void SoundHorn() {
        Console.WriteLine("Add horn sound here");
    }

    public override string ToString() {
        return $"{GetType()}: {Make} {Model}";
    }
}

// Declare sublasses that inherit from the abstract class
public class Car : Vehicle
{
    public Car() {
    }
    public override void SoundHorn()
    {
        Console.WriteLine("Beep Beep");
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle() {
    }

    public override void SoundHorn()
    {
        Console.WriteLine("Honk Honk");
    }
}
