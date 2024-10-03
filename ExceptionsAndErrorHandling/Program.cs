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
    Console.WriteLine($"An Exception was thrown: {e.Message}");
}
finally
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("End of number processing.");
}

Console.ReadKey();

int ParseStringToInt(string input)
{
        return int.Parse(input);
}