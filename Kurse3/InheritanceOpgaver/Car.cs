using System;

public class Car : IComparable<Car>, ITaxable
{
	public Car (string make, string model, double price)
    {
		Make = make;
		Model = model;
		Price = price;
    }

	public string Make { get; set; }
	public string Model { get; set; }
	public double Price { get; set; }


	public int CompareTo(Car other)
    {
		return this.Price.CompareTo(other.Price);
    }

    decimal ITaxable.TaxValue()
    {
		return ((decimal)Price) * 2;
    }
}
