//Measuring weather tempreture
DisplayTempreture(-12);  // Output: Measured value is -4; Freezing.
DisplayTempreture(7);  // Output: Measured value is 5; Cold
DisplayTempreture(90);  // Output: Measured value is 30; too high.
DisplayTempreture(double.NAN);  // Output: Failed measurement.


void DisplayMeasurement(double measurement)
{
    Console.writeline("Whats the Tempreture in your Area")
    int choice = console.readlLine();

    switch (measurement)
    {
        case < 0.0:
            Console.WriteLine($"Measured value is {measurement}; Freezing.");
            break;

        case > 0.0:
            Console.WriteLine($"Measured value is {measurement}; Cold.");
            break;

        case NaN:
            Console.WriteLine("Failed measurement.");
            break;

        default:
            Console.WriteLine($"Measured value is {measurement}.");
            break;
    }
}
