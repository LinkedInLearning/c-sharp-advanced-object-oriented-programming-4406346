// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// init-only modifier

// create two objects using Initializers and a Constructor
Employee emp1 = new Employee() {FirstName="John", LastName="Doe", ID=1, Department="Sales"};
Employee emp2 = new Employee("Jane", "Deaux", 2, "Sales");


Console.WriteLine(emp1);
emp1.Department = "Tech Support";
emp1.ID = 5; 
Console.WriteLine(emp1);

Console.WriteLine(emp2);
emp2.LastName = "Dough";
emp2.ID = 3; 
Console.WriteLine(emp2);
