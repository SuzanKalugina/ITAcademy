// See https://aka.ms/new-console-template for more information

const int minRiceCount = 60;
const int minCheeseCount = 70;
const int minFishCount = 100;
const int minCucumberCount = 80;
const int minNoriCount = 2;
int bestTemperatureOfRice = 30;
const string message = "not enough of product";

Console.WriteLine("Sushi recipe:");
Console.WriteLine($"minimum amount of rice: {minRiceCount}");
Console.WriteLine("How much rice do you have?");

int riceCount = Convert.ToInt32(Console.ReadLine());

if (riceCount < minRiceCount)
{
    Console.WriteLine(message);

    return;
}

Console.WriteLine($"Boil {minRiceCount}g of rice");
Console.WriteLine("Cool rice");

int temperatureOfrise = 100;

while (temperatureOfrise > bestTemperatureOfRice)
{
    Console.WriteLine("wait");

    temperatureOfrise -= 8;
}

Console.WriteLine($"Now the temperature of rice: {temperatureOfrise}");
Console.WriteLine($"minimum amount of nori: {minNoriCount}");
Console.WriteLine("How many nori do you have?");

int noriCount = Convert.ToInt32(Console.ReadLine());

if (noriCount < minNoriCount)
{
    Console.WriteLine(message);

    return;
}

Console.WriteLine($"Take {minNoriCount} nori");
Console.WriteLine($"Add {minRiceCount} of rice");
Console.WriteLine($"minimum amount of fish: {minFishCount}");
Console.WriteLine("How much fish do you have?");

int fishCount = Convert.ToInt32(Console.ReadLine());

if (fishCount < minFishCount)
{
    Console.WriteLine(message);

    return;
}

Console.WriteLine($"Cut {minFishCount} of fish");
Console.WriteLine("Add fish to nori");
Console.WriteLine($"minimum amount of cucumber: {minCucumberCount}");
Console.WriteLine("How much cucumber do you have?");

int cucumberCount = Convert.ToInt32(Console.ReadLine());

if (cucumberCount < minCucumberCount)
{
    Console.WriteLine(message);

    return;
}

Console.WriteLine($"Cut {minCucumberCount} of cucumber");
Console.WriteLine($"Add {minCucumberCount} cucumber");
Console.WriteLine($"minimum amount of cheese: {minCheeseCount}");
Console.WriteLine("How many cheese do you have?");

int cheeseCount = Convert.ToInt32(Console.ReadLine());

if (cheeseCount < minCheeseCount)
{
    Console.WriteLine(message);

    return;
}

Console.WriteLine($"Add {minCheeseCount} of cheese");
Console.WriteLine("Roll up");
Console.WriteLine("Cut roll");

int rollLenght = 21;
int numberOfpiecesOfRolls = 1;

for (int i = 2; i < rollLenght; i += 2)
{
    numberOfpiecesOfRolls++;
}

Console.WriteLine($"You made {numberOfpiecesOfRolls} pieces of sushi");