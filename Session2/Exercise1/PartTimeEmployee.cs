namespace Session2;

public class PartTimeEmployee: Employee
{
    private int hoursPerMonth;
    private double hourlyWage;

    public PartTimeEmployee(int hours, double wage,string name) : base(name)
    {
        hourlyWage = wage;
        hoursPerMonth = hours;
    }

    public override double GetMonthlySalary(double salary)
    {
        return hoursPerMonth*hourlyWage;
    }
}