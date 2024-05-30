using System;

public class Program
{
    const double CENTIMETERS_PER_INCH = 2.54;

    static void Main()
    {
        Console.WriteLine("Enter the number of inches:");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double inches))
        {
            double centimeters = inches * CENTIMETERS_PER_INCH;
            Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
        }
        else
        {
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
