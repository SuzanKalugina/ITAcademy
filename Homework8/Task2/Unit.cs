namespace Task2;

public abstract class Unit
{
    public string Name { get; set; }
    public int Number { get; set; }
    public ColorType Color { get; set; }

    public virtual void Move()
    {
        Console.WriteLine($"{Name} движется");
    }

    public abstract void Eat();
}