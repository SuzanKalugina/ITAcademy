using Task3;

Console.WriteLine("Посудомоечная машина 1:");
var dishwasher1 = new Dishwasher();
dishwasher1.Id = Guid.NewGuid();
dishwasher1.Price = 100;
dishwasher1.Color = "White";
dishwasher1.Weight = 10;
dishwasher1.AmountOfWater = 10;
dishwasher1.Start(1);
Console.WriteLine($"Номер: {dishwasher1.Id}\nЦена: {dishwasher1.Price}\n" +
                  $"Цвет: {dishwasher1.Color}\nВес: {dishwasher1.Weight}\n" +
                  $"Мощность: {dishwasher1.Power}\nРежим: {dishwasher1.WorkingMode}\n" +
                  $"Количество воды: {dishwasher1.AmountOfWater}");
dishwasher1.Stop();

Console.WriteLine();

Console.WriteLine("Посудомоечная машина 2:");
var dishwasher2 = new Dishwasher();
dishwasher2.Id = Guid.NewGuid(); ;
dishwasher2.Price = 120;
dishwasher2.Color = "Blue";
dishwasher2.Weight = 10;
dishwasher2.AmountOfWater = 4;
dishwasher2.Start(2);
Console.WriteLine($"Номер: {dishwasher2.Id}\nЦена: {dishwasher2.Price}\n" +
                  $"Цвет: {dishwasher2.Color}\nВес: {dishwasher2.Weight}\n" +
                  $"Мощность: {dishwasher2.Power}\nРежим: {dishwasher2.WorkingMode}\n" +
                  $"Количество воды: {dishwasher2.AmountOfWater}");
dishwasher2.Stop();

Console.WriteLine();

Console.WriteLine("Стиральная машина 1:");
var washingmachine1 = new WashingMachine();
washingmachine1.Id = Guid.NewGuid();
washingmachine1.Price = 130;
washingmachine1.Color = "Black";
washingmachine1.Weight = 15;
washingmachine1.AmountOfLaundry = 5;
washingmachine1.Powder = 30;
washingmachine1.Start(1);
Console.WriteLine($"Номер: {washingmachine1.Id}\nЦена: {washingmachine1.Price}\n" +
                  $"Цвет: {washingmachine1.Color}\nВес: {washingmachine1.Weight}\n" +
                  $"Количество белья: {washingmachine1.AmountOfLaundry}\n" +
                  $"Мощность: {washingmachine1.Power}\nРежим: {washingmachine1.WorkingMode}\n" +
                  $"Осталось порошка: {washingmachine1.Powder}");
washingmachine1.Stop();

Console.WriteLine();

Console.WriteLine("Стиральная машина 2:");
var washingmachine2 = new WashingMachine();
washingmachine2.Id = Guid.NewGuid();
washingmachine2.Price = 90;
washingmachine2.Color = "Red";
washingmachine2.Weight = 15;
washingmachine2.AmountOfLaundry = 11;
washingmachine2.Powder = 7;
washingmachine2.Start(2);
Console.WriteLine($"Номер: {washingmachine2.Id}\nЦена: {washingmachine2.Price}\n" +
                  $"Цвет: {washingmachine2.Color}\nВес: {washingmachine2.Weight}\n" +
                  $"Количество белья: {washingmachine2.AmountOfLaundry}\n" +
                  $"Мощность: {washingmachine2.Power}\nРежим: {washingmachine2.WorkingMode}\n" +
                  $"Осталось порошка: {washingmachine2.Powder}");
washingmachine2.Stop();