// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using static methods

// Declare some temperature values to use
Temperature[] temps = {
    new Temperature(19.1), new Temperature(22.5), new Temperature(15.8), new Temperature(20.2),
    new Temperature(21.3), new Temperature(18.6), new Temperature(23.0), new Temperature(17.4)
    };

// Static methods are accessed using the class name and the method name
Console.WriteLine($"{Temperature.FtoC(72.0):F2}");
Console.WriteLine($"{Temperature.CtoF(22.0):F2}");

// How many temperatures are room temp?
var roomtemps = 0;
foreach (Temperature t in temps) {
    if (t.IsRoomTemp())
        roomtemps++;
}
// Constants are accessed the same as static members
Console.WriteLine($"Room temp is between {Temperature.ROOM_TEMP_LOWER_C}C and {Temperature.ROOM_TEMP_UPPER_C}C");
Console.WriteLine($"{roomtemps} measurements are room temperature");

// Check to see if a given temperature value is room temp
Console.WriteLine($"{Temperature.IsRoomTemp(22.0)}");
Console.WriteLine($"{Temperature.IsRoomTemp(17.0)}");
