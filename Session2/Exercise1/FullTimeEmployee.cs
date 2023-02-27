namespace Session2;

public class FullTimeEmployee: Employee
{
    private double monthlySalary;

    public FullTimeEmployee(double monthlySalary, string name) : base(name)
    {
        this.monthlySalary = monthlySalary;
    }

    public override double GetMonthlySalary(double salary)
    {
        return monthlySalary;
    }
}