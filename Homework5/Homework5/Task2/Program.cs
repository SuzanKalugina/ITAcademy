using Task2;

var worker1 = new Worker();
worker1.Name = "Ivan";
worker1.Lastname = "Petrov";
worker1.Age = 30;
worker1.Position = "junior";
worker1.Salary = 200;

var company1 = new Company();
company1.AddWorker(worker1);
Console.WriteLine($"Имя: {worker1.Name}\nФамилия: {worker1.Lastname}\n" +
                  $"Возраст:{worker1.Age}\nДолжность: {worker1.Position}\n" +
                  $"Зарплата: {worker1.Salary}");
company1.ChangeSalary(worker1, 300);
Console.WriteLine($"Новая зарплата: {worker1.Salary}");
Console.WriteLine();
company1.ChangePosition(worker1, "middle");
Console.WriteLine($"Должность: {worker1.Position}");
company1.Fire(worker1);
Console.WriteLine($"\nДолжность:{worker1.Position}\n" +
                  $"Зарплата: {worker1.Salary}");