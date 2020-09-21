using System;

public class Employee
{
	public Employee(string name, string jobTitle, decimal salary, decimal seniority)
	{
        Name = name;
        Jobtitle = jobTitle;
        Salary = salary;
        Seniority = seniority;
	}

    public string Name { get; set; }

    public string Jobtitle { get; set; }

    public decimal Salary { get; set; }

    private decimal _Seniority;
    public decimal Seniority
    {
        get
        {
            return _Seniority;
        }
        set
        {
            if (value > 10 || value < 0)
            {
                throw new ArgumentOutOfRangeException("Number must be between 0 and 10");
            }
            else
            {
                _Seniority = value;
            }
        }
    }

    public virtual decimal CalculateYearlySalary()
    {
        return (Salary * 12) * (1 + (decimal)0.1 * Seniority);
    }

}
