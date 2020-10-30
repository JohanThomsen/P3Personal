using System;

public class ParkingMeterWeekday : ParkingMeter
{
    public ParkingMeterWeekday(decimal payment) : base(payment)
    {
        Payment = payment;
    }

    private decimal Rate = 3m;

    public override decimal CalculateMinutes()
    {
        return Payment * Rate;
    }
}
