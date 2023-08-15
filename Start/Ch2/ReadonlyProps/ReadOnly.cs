// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using the readonly modifier for class members

public class Book {
    // Declare some private fields
    private readonly string _ISBN = "";
    private string _title = "";
    private string _author = "";

    public Book(string ISBN, string Title, string Author) {
        _ISBN = ISBN;
        _title = Title;
        _author = Author;
    }

    public void Update(string ISBN, string Title, string Author) {
        // _ISBN = ISBN; // causes a compile error
        _title = Title;
        _author = Author;
    }

    public override string ToString() {
        return $"{_ISBN}: {_title} by {_author}";
    }
}
