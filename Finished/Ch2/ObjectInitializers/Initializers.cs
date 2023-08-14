// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object initializers

// Example: class that defines a Pet with a name and age
public class Pet {
    public string Name { get; set; } = "";
    public int Age { get; set; } = 0;

    public Pet() {}
}

public class Dog : Pet {
    public bool IsTrained { get; set; } = false;

    public Dog () {}
}

public class Cat : Pet {
    public bool IsDeclawed { get; set; } = false;

    public Cat () {}
}

// Define a class that implements an internal collection
public class PetOwner {
    public string Name { get; set; } = "";

    public List<Pet>? Pets { get; set; }
}
