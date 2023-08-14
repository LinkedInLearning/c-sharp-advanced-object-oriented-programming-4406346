// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// The "required" modifier

// Construct some objects using Object Initializer syntax
Employee emp1 = new Employee() {FirstName="John", LastName="Doe", ID=1, Department="Sales"};
Employee emp2 = new Employee() {FirstName="Jane", LastName="Deaux", ID=2, Department="R&D"};
Employee emp3 = new Employee() {FirstName="Jim", LastName="Dough", ID=3, Department="Marketing"};

// Construct an object using the constructor
Employee emp4 = new Employee("Joe", "Doh", 4, "Marketing");

Console.WriteLine(emp1);
Console.WriteLine(emp2);
Console.WriteLine(emp3);
Console.WriteLine(emp4);
