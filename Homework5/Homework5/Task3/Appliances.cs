namespace Task3;

public abstract class Appliances
{
    public Guid Id;
    public int Price { get; set; }
    public int WorkingMode { get; protected set; }
    public string Color { get; set; }
    public int Power { get; protected set; }

    private int weight;
    public int Weight
    {
        get => weight;
        set
        {
            if (value > 0)
            {
                weight = value;
            }
        }
    }

    public abstract void Start(int workingMode);
    public abstract void Stop();
}