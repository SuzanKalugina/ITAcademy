int[,] myArray = new int[3, 3] { { 5, 70, 17 }, { 11, 3, 7 }, { 8, 2, 32 } };

var rows = myArray.GetUpperBound(0) + 1;
var colums = myArray.Length / rows;

for (int i = 0; i < rows; i++)
{
    var maxValue = myArray[i, 0];
    for (int j = 1; j < colums; j++)
    {
        var value = myArray[i, j];

        if (maxValue < value)
        {
            maxValue = value;
        }
    }

    Console.WriteLine(maxValue);
}

