// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// Define a class using the "class" keyword
class Rectangle {
    // The constructor accepts parameters used to create the object
    public Rectangle(int w, int h) {
        width = w;
        height = h;
    }

    // For convenience, we can have a constructor that takes one value
    // for squares that have the same side size
    public Rectangle(int side) {
        width = height = side;
    }

    // Classes can define methods that return values
    public int GetArea() {
        return width * height;
    }

    // TODO: Define Properties that allow access to the private data
    // These are called "backing field" properties


    // TODO: Auto-implmeneted properties don't have a backing field

    
    // Properties and member variables hold data
    int width;
    int height; 
}
