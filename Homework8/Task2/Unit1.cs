namespace Task2;

public class Unit1 : Unit, IFlySkill
{
    public override void Move()
    {
        Console.WriteLine($"{Name} из Unit1 движется");
    }

    public override void Eat()
    {
        Console.WriteLine("Unit1 ест");
    }
     
    public void Fly()
    {
        Console.WriteLine("Unit1 умеет летать");
    }
}