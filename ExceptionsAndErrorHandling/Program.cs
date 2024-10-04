using ExceptionsAndErrorHandling;
Console.WriteLine("Enter a number");

#region SandBox1

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

#endregion

#region Sandbox2
var firstNumber = GetFirstElement(new int[0]);

#endregion

#region Sandbox3

var person = new Person("", -100);

#endregion

Console.ReadKey();

int ParseStringToInt(string input)
{
        return int.Parse(input);
}

int GetFirstElement(IEnumerable<int> numbers)
{
    // return numbers.First();
    foreach (var number in numbers)
    {
        return number;
    }

    throw new Exception("The Collection cannot be empty.");
}