namespace Task2;

public class Worker
{
    public string Name { get; set; }
    public string Lastname { get; set; }

    private int age;
    public int Age
    {
        get => age;
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Возраст приема на работу от 18 лет");

                return;
            }

            age = value;
        }
    }

    private int salary;
    public int Salary
    {
        get => salary;
        set
        {

            if (value < 0)
            {
                Console.WriteLine("Неверно указана зарплата");
                return;
            }

            salary = value;
        }
    }
    public string Position { get; set; }
}