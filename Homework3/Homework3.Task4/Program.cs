const decimal depositDercentage = 1.07m;

Console.WriteLine("Введите сумму вклада:");
var depositSum = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Введите кол-во месяцев:");
var depositMonthes = Convert.ToInt32(Console.ReadLine());

if (depositMonthes < 0 || depositSum <= 0)
{
    Console.WriteLine("Не верные значения");

    return;
}

for (var i = 1; i <= depositMonthes; i++)
{
    depositSum *= depositDercentage;
}

Console.WriteLine(depositSum);