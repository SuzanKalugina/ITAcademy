var step = 20;
var value = -20;
var lastValue = -100;

do
{
    Console.WriteLine(value);
    value -= step;
}
while (value >= lastValue);