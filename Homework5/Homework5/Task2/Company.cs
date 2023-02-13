namespace Task2;

public class Company
{
    private List<Worker> employees = new List<Worker>();

    public void AddWorker(Worker worker)
    {
        if (!employees.Contains(worker))
        {
            employees.Add(worker);
        }
    }

    public void ChangeSalary(Worker worker, int salary)
    {
        if (employees.Contains(worker))
        {
            worker.Salary = salary;
        }
    }

    public void ChangePosition(Worker worker, string position)
    {
        if (employees.Contains(worker))
        {
            worker.Position = position;
        }
    }

    public void Fire(Worker worker)
    {
        if (employees.Contains(worker))
        {
            worker.Position = "fired";
            worker.Salary = 0;
        }
    }
}