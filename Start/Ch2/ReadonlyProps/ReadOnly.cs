// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using the readonly modifier for class members

public class Wine {
    // Declare some private fields
    private int _year = 0;
    private string _style = "";
    private string _producer = "";

    public Wine(int year, string producer, string style) {
        _year = year;
        _producer = producer;
        _style = style;
    }

    public void Update(int year, string producer, string style) {
        _year = year; // causes a compile error
        _producer = producer;
        _style = style;
    }

    public override string ToString() {
        return $"{_year} {_producer} {_style}";
    }
}
