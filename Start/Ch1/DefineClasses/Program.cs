// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Create some new Rectangle objects with dimensions

var rect = new Rectangle(10,20);
var rect1 = new Rectangle(10);
Console.WriteLine(rect1.GetArea());
Console.WriteLine(rect.GetArea());
// TODO: Change the values of width and height
rect.width = 20;
rect.height = 30;
Console.WriteLine(rect.GetArea());

rect.Width = 5; 
rect.Height = -6; 
rect.BorderSize = 10;

Console.WriteLine(rect.GetArea());
