// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using the readonly modifier for class members

var book1 = new Book("9780393096729", "War and Peace", "Leo Tolstoy");
var book2 = new Book("9780552015004", "Catch-22", "Joseph Heller");

Console.WriteLine($"{book1}");
Console.WriteLine($"{book2}");

book1.Update("9780393096729", "War & Peace", "Tolstoy, Leo");
Console.WriteLine($"{book1}");
