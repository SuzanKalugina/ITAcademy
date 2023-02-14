var step = 5;
var min2DigitNumber = 10;
var min3DigitNumber = 100;

for (var i = min2DigitNumber; i < min3DigitNumber; i += step)
{
    Console.Write($"{i} \t");
}

Console.WriteLine();

for (var i = min2DigitNumber; i < min3DigitNumber; i += step)
{
    if (i % 5 == 0)
    {
        Console.Write($"{i} \t");
    }
}