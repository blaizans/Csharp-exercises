namespace Session2;

public class Company
{
    private List<Employee> employees;

    public void HireNewEmployee(Employee emp)
    {
        employees.Add(emp);
    }

    public void DisplayMostExpensiveEmployee()
    {
        Employee mostExpensive;
        
        for (int i = 0; i <= employees.Count; i++)
        {
            int next = employees[i+1];
            if(i + 1 < employees.Count)
                next = employees[i+1];
        }
    }

    public double GetMonthlySalaryTotal()
    {
        double totalSalary = 0;
        foreach (Employee employee in employees)
        {
            totalSalary += employee.GetMonthlySalary();
        }

        return totalSalary;
    }
}