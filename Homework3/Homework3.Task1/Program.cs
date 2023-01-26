Console.WriteLine("Введите число a:");
var a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите число b:");
var b = Convert.ToDouble(Console.ReadLine());

if (a <= 0 || b <= 0)
{
    Console.WriteLine("Числа не должны быть <= 0");

    return;
}

var result = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

Console.WriteLine(result);