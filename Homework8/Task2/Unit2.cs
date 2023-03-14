namespace Task2
{
    public class Unit2 : Unit, IJump, IFlySkill, ISwimSkill
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} из Unit2 ест");
        }

        public void Fly()
        {
            Console.WriteLine("Unit2 умеет летать");
        }

        public void Swim()
        {
            Console.WriteLine("Unit2 умеет плавать");
        }

        public void Jump()
        {
            Console.WriteLine("Unit2 умеет прыгать");
        }
    }
}
