// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// The "required" modifier
using System.Diagnostics.CodeAnalysis;

public class Employee {
    public Employee() {}

    // The SetsRequiredMembers attribute indicates that the constructor sets the 
    // required members, but the compiler doesn't actually check - it trusts you
    // Use this attribute with caution
    [SetsRequiredMembers]
    public Employee(string fname, string lname, int id, string dept) {
        ID = id;
        FirstName = fname;
        LastName = lname;
        Department = dept;
    }

    // The "required" keyword means that a value must be assigned during construction
    // Members that are required must be at least as visible as the containing type
    public required int ID {
        get; 
        init;
    }
    public string? Department {
        get; set;
    }
    public string? FirstName {
        get; set;
    }
    public required string LastName {
        get; set;
    }

    public override string ToString() => $"{FirstName} {LastName}, ID:{ID} in {Department}";
}
