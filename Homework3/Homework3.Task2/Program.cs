while (true)
{
    Console.WriteLine("Введите число a:");
    var a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Введите число b:");
    var b = Convert.ToDouble(Console.ReadLine());

    if (a >= 0 && a <= 10 && b >= 0 && b <= 10)
    {
        var result = a * b;
        Console.WriteLine(result);

        break;
    }

    Console.WriteLine("Введите числа от 0 до 10");
}