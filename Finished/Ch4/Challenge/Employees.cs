// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public abstract class Employee {
    private static int _empCount = 0;
    protected static int IDStart;
    
    static Employee() {
        IDStart = 1000;
    }

    public Employee() {
        Employee._empCount++;
        ID = Employee.IDStart++;
    }

    public static int EmployeeCount { get => _empCount; }

    public int ID {get; init;}
    public required string Department {get; set;}
    public required string FullName {get; set;}

    public abstract void AdjustPay(decimal percentage);

    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

public sealed class HourlyEmployee : Employee {
    public HourlyEmployee() {}

    public decimal PayRate {get; set;}

    public override void AdjustPay(decimal percentage)
    {
        PayRate += (PayRate * percentage);
    }
}

public sealed class SalariedEmployee : Employee {
    public SalariedEmployee() {}

    public decimal Salary {get; set;}

    public override void AdjustPay(decimal percentage) {
        Salary += (Salary * percentage);
    }
}
