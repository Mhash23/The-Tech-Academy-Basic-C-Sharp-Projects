using System; // Enables console input and output.

class Program
{
    static void Main()
    {
        // Display the welcome message.
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Get the package weight.
        Console.WriteLine("Please enter the package weight:");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Stop if the weight exceeds 50.
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Get the package width.
        Console.WriteLine("Please enter the package width:");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        // Get the package height.
        Console.WriteLine("Please enter the package height:");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        // Get the package length.
        Console.WriteLine("Please enter the package length:");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Stop if the combined dimensions exceed 50.
        if (width + height + length > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the shipping quote.
        decimal quote = (width * height * length * weight) / 100m;

        // Display the quote as a dollar amount with two decimal places.
        Console.WriteLine("Your estimated total for shipping this package is: $" +
            quote.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));

        // Thank the user.
        Console.WriteLine("Thank you!");
    }
}
