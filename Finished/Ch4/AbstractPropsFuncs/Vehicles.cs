// Example file for Advanced C#: Object Oriented Programming by Joe Marini

// Declare an abstract base class to prevent direct instantiation
public abstract class Vehicle
{
    public Vehicle() {
    }

    public required string Model {
        get;
        init;
    }

    public required string Make {
        get;
        init;
    }

    // By declaring a member to be abstract, we can require subclasses to implement it
    public abstract void SoundHorn();

    public abstract int WheelCount { get; }

    public override string ToString() {
        return $"{GetType()}: {Make} {Model}, Wheels: {WheelCount}";
    }
}

// Declare sublasses that inherit from the abstract class
public class Car : Vehicle
{
    public Car() {}

    public override int WheelCount => 4;

    public override void SoundHorn()
    {
        Console.WriteLine("Beep Beep");
    }
}

public class Motorcycle : Vehicle
{
    public Motorcycle() {}

    public override int WheelCount => 2;

    public override void SoundHorn()
    {
        Console.WriteLine("Honk Honk");
    }
}
