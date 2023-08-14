// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Access modifiers

// create the classes
MyClass class1 = new MyClass();
DerivedClass class2 = new DerivedClass();

// Access the methods
Console.WriteLine($"Class1 Data value is {class1.Data}");
class1.Func1();
class1.Func1();
Console.WriteLine($"Class1 Data value is {class1.Data}");

// class2.Func2(); // can't access this function outside the class
Console.WriteLine($"Class2 Data value is {class2.Data}");
class2.Func1();
class2.Func3();
Console.WriteLine($"Class2 Data value is {class2.Data}");
