string greeting = "Hello World!";
var number = ParseStringToInt(greeting);

Console.ReadKey();

int ParseStringToInt(string input)
{
    return int.Parse(input);
}