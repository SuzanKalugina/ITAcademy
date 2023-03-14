using Task2;

var person1 = new Unit1
{
    Name = "Ivan", 
    Number = 1526, 
    Color = ColorType.White
};

person1.Eat();
person1.Move();
person1.Fly();
Console.WriteLine();

var person2 = new Unit2
{
    Name = "Petr", 
    Number = 6500,
    Color = ColorType.Green,
};

person2.Eat();
person2.Move();
person2.Fly();
person2.Swim();
person2.Jump();
