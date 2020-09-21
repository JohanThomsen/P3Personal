using System;

public class Manager : Employee
{
	public Manager(string name, string jobTitle, decimal salary, decimal seniority, decimal bonus) :
		base(name, jobTitle, salary, seniority)
	{
		Bonus = bonus;
	}

	public decimal Bonus { get; set; }

    public override decimal CalculateYearlySalary()
    {
		return (Salary * 12) * (1 + (decimal)0.1 * Seniority) + Bonus;
    }
}
