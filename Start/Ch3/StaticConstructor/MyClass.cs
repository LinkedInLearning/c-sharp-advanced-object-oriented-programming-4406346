// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using static constructors

// Define a regular class with instance and static methods
public class MyClass {
    // static members that only need one-time initialization
    public static long CallCounter;
    public static string LastCaller;

    // TODO: the static constructor is only called once, has no parameters,
    // is not called directly, and can not be inherited/overloaded


    // Regular constructor
    public MyClass() {
        Console.WriteLine("Regular constructor has been called");
    }

    // Instance Method
    public void MethodA() {
        CallCounter++;
        LastCaller = "MethodA";
    }

    // Static method
    public static void MethodB () {
        CallCounter++;
        LastCaller = "MethodB";
    }
}
