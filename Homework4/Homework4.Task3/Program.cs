Console.WriteLine("Введите первое число:");
var firstValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
var secondValue = Convert.ToInt32(Console.ReadLine());

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