
Console.WriteLine("Введите первое число:");
var a = Console.ReadLine();

if (!int.TryParse(a, out var firstValue))
{
    Console.WriteLine("Вы ввели не число");

    return;
}

Console.WriteLine("Введите второе число:");
var b = Console.ReadLine();

if (!int.TryParse(b, out var secondValue))
{
    Console.WriteLine("Вы ввели не число");

    return;
}

if (firstValue > secondValue)
{
    (firstValue, secondValue) = (secondValue, firstValue);
}

var sum = 0;

for (var i = firstValue; i <= secondValue; i++)
{
    sum += i;
}

var arithmeticMean = (double)sum / (secondValue - firstValue + 1);

Console.WriteLine(sum);
Console.WriteLine(arithmeticMean);