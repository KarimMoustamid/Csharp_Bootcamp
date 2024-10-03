using System.Xml;
Console.WriteLine("Enter a number");
string input = Console.ReadLine();

try
{
    int number = ParseStringToInt(input);
    var result = 10 / number;

    Console.ForegroundColor = ConsoleColor.Green;

    Console.WriteLine($"10 / {number} is {result}");
    Console.WriteLine($"String Successfully Converted, the result is {number}");
}
catch (FormatException ex)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Invalid input! Please enter a valid number. Error: {ex.Message}");
}
catch (DivideByZeroException ex)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"An Exception was thrown: Attempted to divide by zero.");
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"An Exception was thrown: {e.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("End of number processing.");
}

Console.ReadKey();

int ParseStringToInt(string input)
{
        return int.Parse(input);
}