// Example file for Advanced C#: Object Oriented Programming by Joe Marini

public class MyClass {
    public MyClass() {}

    // public members can be accessed from any other class
    public void Func1() {
        Console.WriteLine("This is Func1");
        SomeValue += 1;
    }

    // protected members can be accessed only from this class or derived classes
    protected void Func2() {
        Console.WriteLine("This is Func2");
        SomeValue -= 1;
    }

    // private members can only be accessed by this class
    private int   = 1;

    // Prperties often expose internal data, so they are usually public
    public int Data {
        get => SomeValue;
        set => SomeValue = value;
    }
}

public class DerivedClass : MyClass {
    public DerivedClass() {}

    public void Func3() {
        Console.WriteLine("This is Func3");
        // TODO: Func2 can be accessed because this is a subclass of MyClass
        Func2();
    }
}
