// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using the readonly modifier for class members

var wine1 = new Wine(2005, "Michel Redde", "Sancerre");
var wine2 = new Wine(2018, "Hyde Estate", "Pinot Noir");

Console.WriteLine($"{wine1}");
Console.WriteLine($"{wine2}");

wine1.Update(2006, "Silver Oak", "Cabernet Sauvignon");
Console.WriteLine($"{wine1}");
