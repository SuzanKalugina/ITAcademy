namespace Task3;
public class Dishwasher : Appliances
{
    private int amountOfWater;
    public int AmountOfWater
    {
        get => amountOfWater;
        set
        {
            if (value < 5)
            {
                Console.WriteLine("Мало воды");

                return;
            }

            amountOfWater = value;
        }
    }

    public override void Start(int workingMode)
    {
        if (amountOfWater < 5)
        {
            Console.WriteLine("Подайте воду");

            return;
        }

        WorkingMode = workingMode;

        switch (workingMode)
        {
            case 1:
            {
                Power = 10;
                break;
            }
            case 2:
            {
                Power = 20;
                break;
            }

            default:
            {
                Console.WriteLine("The machine is off.");

                return;
            }
        }

        Console.WriteLine("The machine is on.");
    }

    public override void Stop()
    {
        amountOfWater = 0;
        WorkingMode = 0;
        Power = 0;

        Console.WriteLine("The machine is off.");
    }
}