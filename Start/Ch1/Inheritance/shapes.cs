// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using inheritance to define a class hierarchy

// Define a base class that represents the concept of a 2-dimensional shape
class Shape2D {
    public Shape2D() {}

    // TODO: Methods must be marked as "virtual" to allow overriding


    // TODO: All classes in .NET derive from Object, so we get some methods for free
    // ToString() returns a string representation of the object
    // GetType() returns the type of the object
}

// Derive a Circle class that inherits from the base Shape2D
class Circle : Shape2D {
    public Circle(int r) {
        radius = r;
    }

    // TODO: Override the GetArea() function for the Circle

    int radius;
}

// Derive a Rectangle class that inherits from the base Shape2D
class Rectangle : Shape2D {
    public Rectangle(int w, int h) {
        width = w;
        height = h;
    }

    // TODO: Override the GetArea() function for the Rectangle

    int width;
    int height; 
}

// TODO: Derive a Square class that inherits from the base Rectangle
