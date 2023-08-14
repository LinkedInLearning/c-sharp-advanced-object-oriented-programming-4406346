// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using static constructors

// Instaniate the class
MyClass mc = new MyClass();

Console.WriteLine($"CallCounter: {MyClass.CallCounter}");
Console.WriteLine($"LastCaller: {MyClass.LastCaller}");

// Call some methods
mc.MethodA();
MyClass.MethodB();
mc.MethodA();
MyClass.MethodB();

// Output the number of function calls
Console.WriteLine($"CallCounter: {MyClass.CallCounter}");
Console.WriteLine($"LastCaller: {MyClass.LastCaller}");
