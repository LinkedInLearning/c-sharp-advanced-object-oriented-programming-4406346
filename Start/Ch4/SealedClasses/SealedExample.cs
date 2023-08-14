// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Sealed classes and members

// Example 1: Sealing a class
public class A {
    public A() {
        Console.WriteLine("A");
    }

    protected virtual void Func1() {
        Console.WriteLine($"Func1 in class A");
    }
}

public class B : A {
    public B() {
        Console.WriteLine("B");
    }

    protected override sealed void Func1() {
        Console.WriteLine("Func1 in class B");
    }
}

// Example 2: Sealing an individual member
public class C {
    public C() {}

    protected virtual void Func2() {}
}

public class D : C {
    public D() {}

    protected override void Func2() {}
}

public class E : D {
    public E() {}

    protected override void Func2() {}
}
