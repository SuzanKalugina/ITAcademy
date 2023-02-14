var myArray = new int[6];
for (var i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива:");
    var input = Console.ReadLine();
    var result = int.TryParse(input, out myArray[i]);

    if (result == false)
    {
        Console.WriteLine("Вы ввели не число");

        return;
    }
}

Array.Sort(myArray);
Array.Reverse(myArray);

Console.WriteLine("Отсортированный по убыванию 1 способ:");

for (var i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

Console.WriteLine();

Console.WriteLine("Отсортированный по убыванию 2 способ:");

foreach (int value in myArray)
{
    Console.Write(value + " ");
}

Console.WriteLine();

Console.WriteLine("Последние 3 элемента:");

for (var i = myArray.Length - 3; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " " );
}

Console.WriteLine();

Console.WriteLine("Четные элементы > 5");

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] % 2 == 0 && myArray[i] > 5)
    {
        Console.Write(myArray[i] + " ");
    }
}
