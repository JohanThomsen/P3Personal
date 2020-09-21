using System;

public class ParkingMeterWeekend : ParkingMeter
{
    public ParkingMeterWeekend(decimal payment) : base(payment)
    {
        Payment = payment;
    }

    private decimal Rate = 5m;

    public override decimal CalculateMinutes()
    {
        return Payment * Rate;
    }
}
