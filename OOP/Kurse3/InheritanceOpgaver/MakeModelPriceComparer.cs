using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class MakeModelPriceComparer : IComparer<Car>
{
    public int Compare(Car ob1, Car ob2)
    {
        if(ob1.Make.CompareTo(ob2.Make) == 1)
        {
            return 1;
        }
        else if (ob1.Make.CompareTo(ob2.Make) == 0)
        {
            if (ob1.Model.CompareTo(ob2.Model) == 1)
            {
                return 1;
            }
            else if (ob1.Model.CompareTo(ob2.Model) == 0)
            {
                if (ob1.Price > ob2.Price)
                {
                    return 1;
                }
                else if (ob1.Price == ob2.Price)
                {
                    return 0;
                } 
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        } 
        else
        {
            return -1;
        }
    }
}
