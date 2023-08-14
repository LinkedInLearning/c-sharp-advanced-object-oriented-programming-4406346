// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using static classes

// Access the static constant
Console.WriteLine($"There are {Converter.INCH_CM_CONVERT} cm per inch");

// Use the static class methods
double result = Converter.InToCm(5.0);
Console.WriteLine($"{result}");

result = Converter.CmToIn(5.0);
Console.WriteLine($"{result}");

// static classes cannot be instantiated
// Converter conv = new Converter(); // this will cause a compiler error
