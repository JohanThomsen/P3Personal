using System;

public class Account
{
	public Account(decimal balance, decimal borrowingRate, decimal savingsRate)
	{
		Balance = balance;
		BorrowingRate = borrowingRate;
		SavingsRate = savingsRate;
	}

    public decimal Balance { get; set; }

    public decimal BorrowingRate { get;}

	public decimal SavingsRate { get;}

	public void Deposit(decimal Deposit)
    {
		decimal newBalance = Balance + Deposit;

		if (newBalance > 250000 || newBalance < -100000)
        {
			Balance = newBalance;
        } else
        {
            Console.WriteLine("u cant do that xd");
        }
		
    }

	public void Withdraw(decimal withdrawal)
    {
		decimal newBalance = Balance - withdrawal;

		if (newBalance > 250000 || newBalance < -100000)
		{
			Balance = newBalance;
		}
		else
		{
			Console.WriteLine("u cant do that xd");
		}
	}


}
