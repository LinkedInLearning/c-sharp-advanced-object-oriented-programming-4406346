// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Challenge: create a class hierarchy to represent employees

// Test code for the programming challenge
var Emp1 = new HourlyEmployee() {FullName="John Doe", Department="Sales", ID=1, PayRate=35.0m};
var Emp2 = new SalariedEmployee() {FullName="Jane Deaux", Department="Marketing", ID=2, Salary=75000.0m};

Console.WriteLine($"{Emp1} -- {Emp1.PayRate:C2}");
Emp1.Department = "Legal";
Emp1.AdjustPay(0.10m);
Console.WriteLine($"{Emp1} -- {Emp1.PayRate:C2}");

Console.WriteLine("-------------------");

Console.WriteLine($"{Emp2} -- {Emp2.Salary:C2}");
Emp2.Department = "Solution Architecture";
Emp2.AdjustPay(0.07m);
Console.WriteLine($"{Emp2} -- {Emp2.Salary:C2}");
