using System.Net.Security;

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        double num1;
        double num2;
        string userName;
        int calculationChoice;

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        Console.WriteLine("Enter your name");
        userName = Console.ReadLine();
        Console.WriteLine($"Hello, {userName}! Let's do some calculations.");

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        Console.WriteLine("Use decimal precision? (yes/no)");
        // Store as boolean (true for yes, false for no)
        string decimalChoice = Console.ReadLine();
        bool useDecimals = (decimalChoice.ToLower() == "yes");

        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        Console.WriteLine("Enter the first number.");
        if (useDecimals)
        {
            num1 = double.Parse(Console.ReadLine());
        }
        else
        {
            num1 = (double)int.Parse(Console.ReadLine());
        }

        // TODO: Prompt user for second number (same type as first)
        Console.WriteLine("Enter the second number.");
        if (useDecimals)
        {
            num2 = double.Parse(Console.ReadLine());
        }
        else
        {
            num2 = (double)int.Parse(Console.ReadLine());
        }

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        double sum = num1 + num2;
        // - difference (subtraction: -)
        double difference = num1 - num2;
        // - product (multiplication: *)
        double product = num1 * num2;
        // - quotient (division: /)
        double quotient = num1 / num2;
        // - remainder (modulus: %)
        double remainder = num1 % num2;
        // - average ((num1 + num2) / 2)
        double average = ((num1 + num2) / 2);

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation
        Console.WriteLine($"Sum: {sum:F2}");
        Console.WriteLine($"Difference: {difference:F2}");
        Console.WriteLine($"Product: {product:F2}");
        Console.WriteLine($"Quotient: {quotient:F2}");
        Console.WriteLine($"Remainder: {remainder:F2}");
        Console.WriteLine($"Average: {average:F2} ");

        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }
        if (num2 == 0)
        {
            Console.WriteLine("show error");
        }
        else
        {
            quotient = num1 / num2;
            remainder = num1 % num2;
        }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        double percentageDifference = ((num1 - num2) / num1) * 100;
        Console.WriteLine($"Percentage Difference: {percentageDifference:F2}%");
        int calculationCount = 6;
        Console.WriteLine($"Performed {calculationCount} counts for {userName}");

        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}
