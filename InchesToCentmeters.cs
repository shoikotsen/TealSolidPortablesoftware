using System;

public class Program
{
    // Constant to convert inches to centimeters
    const double CENTIMETERS_PER_INCH = 2.54;

    static void Main()
    {
        // Prompt the user to enter the number of inches
        Console.WriteLine("Enter the number of inches:");
        // Read the input from the user
        string input = Console.ReadLine();
        // Try to parse the input as a double
        if (double.TryParse(input, out double inches))
        {
            // Convert inches to centimeters
            double centimeters = inches * CENTIMETERS_PER_INCH;
            // Display the result
            Console.WriteLine($"{inches} inches is {centimeters} centimeters.");
        }
        else
        {
            // Handle invalid input
            Console.WriteLine("Please enter a valid number.");
        }
    }
}
 // 2024/05/30 SenShoikot Exercise 2.1