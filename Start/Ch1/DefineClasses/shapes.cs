// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Defining and instantiating classes

// TODO: Define a class using the "class" keyword
public class Rectangle
{

    public Rectangle(int w, int h)
    {
        width = w;
        height = h;
    }
    // TODO: The constructor accepts parameters used to create the object

    public int Width 
    {
        get {return width;}
        set { 
           
            width = value;
        }
    }

       public int Height 
    {
        get {return height;}
        set { 
            if (value < 0)
                 throw new ArgumentOutOfRangeException("height", "must be  >= 0");
            height = value;
        }
    }

    public int BorderSize {get; set;} = 1;
    public Rectangle(int side)
    {
        width = height = side;
    }

    // TODO: For convenience, we can have a constructor that takes one value
    // for squares that have the same side size


    // TODO: Classes can define methods that return values
    public int GetArea()
    {
        return width * height;
    }

    // TODO: member variables hold data
    public int width;
    public int height;
}