using System;

public class Person
{
	public Person(string firstName, string lastName, int age, Person mom, Person dad)
    {
		FirstName = firstName;
		LastName = lastName;
		Age = age;
		Mom = mom;
		Dad = dad;
    }

	public Person(string firstName, string lastName, int age)
	{
		FirstName = firstName;
		LastName = lastName;
		Age = age;
	}
	private string _FirstName;
	public string FirstName
    {
		get
        {
			return _FirstName;
        }
		set
        {
			if (value == null)
            {
				throw new ArgumentNullException("value");
			} 
			else
            {
				value = value.Trim();
				if (value == "" || value.Length > 15)
                {
					throw new ArgumentException("First name cannot be blank or greater than 15 characters", nameof(value));
                } 
				else
				{
					_FirstName = value;
                }

            }
		}
    }

	private string _LastName;
	public string LastName
	{
		get
		{
			return _LastName;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			else
			{
				value = value.Trim();
				if (value == "" || value.Length > 15)
				{
					throw new ArgumentException("Last name cannot be blank or greater than 15 characters", nameof(value));
				}
				else
				{
					_LastName = value;
				}

			}
		}
	}

	private int _Age;
	public int Age
    {
		get
        {
			return _Age;
        }
		set
        {
			if (!(value is int))
            {
				throw new ArgumentException("Age must be a number");
            } 
			else if (!(value > 0 || value < 130))
			{
				throw new ArgumentOutOfRangeException("Age must be between 0 and 130");

			} else
            {
				_Age = value;
            }
        }
    }

	Person Mom;
	Person Dad;



	public void PrintCheck()
	{
        Console.WriteLine($"First name : {_FirstName}");
		Console.WriteLine($"Last name : {_LastName}");
		Console.WriteLine($"Age : {_Age}");
        Console.WriteLine($"Mom : {Mom.FirstName} {Mom.LastName} {Mom.Age}");
		Console.WriteLine($"Dad : {Dad.FirstName} {Dad.LastName} {Dad.Age}");

	}
}
