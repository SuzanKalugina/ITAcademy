namespace Task3;
internal class WashingMachine : Appliances
{
    private const int POWER_WORKING_MODE_1 = 10;
    private const int POWER_WORKING_MODE_2 = 8;

    public int AmountOfLaundry;

    private int powder;
    public int Powder
    {
        get => powder;
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Неверное значение для порошка");
                return;
            }

            powder = value;
        }
    }

    public override void Start(int workingMode)
    {
        switch (workingMode)
        {
            case 1:
                {
                    if (powder >= POWER_WORKING_MODE_1)
                    {
                        powder -= POWER_WORKING_MODE_1;
                        break;
                    }

                    Console.WriteLine("Не хватает порошка");

                    return;
                }
            case 2:
                {
                    if (powder >= POWER_WORKING_MODE_2)
                    {
                        powder -= POWER_WORKING_MODE_2;
                        break;
                    }

                    Console.WriteLine("Не хватает порошка");

                    return;
                }
            default:
                {
                    Console.WriteLine("The machine is off.");

                    return;
                }
        }

        WorkingMode = workingMode;

        switch (AmountOfLaundry)
        {
            case > 0 and < 10:
                Power = 60;
                break;
            case >= 10:
                Power = 100;
                break;
            default:
                Console.WriteLine("Нет белья для стирки");
                return;
        }

        Console.WriteLine("The machine is on.");
    }

    public override void Stop()
    {
        Power = 0;
        AmountOfLaundry = 0;
        WorkingMode = 0;

        Console.WriteLine("The machine is off.");
    }
}