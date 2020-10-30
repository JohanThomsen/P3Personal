using System;

public abstract class ParkingMeter
{
	public ParkingMeter(decimal payment)
	{
		Payment = payment;
	}

    public decimal Payment { get; set; }

	public abstract decimal CalculateMinutes();

}
