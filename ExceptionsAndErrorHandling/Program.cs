using System.Xml;
Console.WriteLine("Enter a number");
string input = Console.ReadLine();

try
{
    int number = ParseStringToInt(input);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"String Successfully Converted, the result is {number}");
}
catch (Exception e)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("An Exception was thrown");
}
finally
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("End of number processing.");
}

Console.ReadKey();

int ParseStringToInt(string input)
{
    try
    {
        return int.Parse(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Parsing error: in the {nameof(ParseStringToInt)} method");
    }

    return 0;
}