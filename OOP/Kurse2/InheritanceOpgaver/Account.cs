using System;

public class Account
{
	public Account(decimal balance, decimal borrowingRate, decimal savingsRate)
	{
		if (balance < 250000 && balance > -100000)
        {
			_Balance = balance;
		} else
        {
            Console.WriteLine("Balance can't be greater than 250.000 or less than -100.000");
        }
			

		if (borrowingRate >= 6)
        {
			BorrowingRate = borrowingRate;
		}
		else
        {
            Console.WriteLine("Borrowing rate too low");
        }

		if (savingsRate <= 2 && savingsRate >= 0)
        {
			SavingsRate = savingsRate;
		}
		else
        {
            Console.WriteLine("Savings rate either negative or too high");
        }
		
	}

	private decimal _Balance;
    public decimal Balance 
	{
        get
        {
			return _Balance;
        } 
	}

    public decimal BorrowingRate { get;}

	public decimal SavingsRate { get;}

	public void Deposit(decimal Deposit)
    {
        if (Deposit > 0)
        {
			decimal newBalance = Balance + Deposit;

			ChangeBalance(newBalance);
		}
		else
        {
            Console.WriteLine("Can't deposit or withdrwa a negative amount of money");
        }
    }

	public void Withdraw(decimal Withdrawal)
    {
        if (Withdrawal > 0)
        {
			decimal newBalance = Balance - Withdrawal;

			ChangeBalance(newBalance);
		}
		else
		{
			Console.WriteLine("Can't deposit or withdrwa a negative amount of money");
		}
	}

	public void AccrueInterest()
    {
		decimal newBalance = Balance * (1 + (SavingsRate / 100));

		ChangeBalance(newBalance);
	}

	public void ChargeInterest()
	{
		decimal newBalance = (Balance * (1 + (BorrowingRate / 100))) - Balance;

		ChangeBalance(newBalance);
	}


	private void ChangeBalance (decimal newBalance)
    {
		if (newBalance < 250000 && newBalance > -100000)
		{
			_Balance = newBalance;
		}
		else
		{
			Console.WriteLine("u cant do that xd");
		}
	}
}
