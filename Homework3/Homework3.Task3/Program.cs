Console.WriteLine("Введите число a:");
var a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b:");
var b = Convert.ToInt32(Console.ReadLine());

if (a <= 0 || b <= 0)
{
    Console.WriteLine("Числа не должны быть <= 0");

    return;
}

for (var i = 1; i <= a; i++)
{
    for (var j = 1; j <= b; j++)
    {
        Console.Write($"{i} * {j} = {i * j}");
        Console.Write("\t");
    }

    Console.WriteLine();
}