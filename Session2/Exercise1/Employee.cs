namespace Session2;

public class Employee
{
    public string Name { get; }

    public Employee(string name)
    {
        Name = name;
    }

    public virtual double GetMonthlySalary(double salary)
    {
        
        return salary;
    }
}