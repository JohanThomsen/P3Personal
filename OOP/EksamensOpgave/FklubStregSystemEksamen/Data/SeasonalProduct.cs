using System;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.Data
{
    public class SeasonalProduct : Product
    {
        public SeasonalProduct(int id, string name, int price, int isActive, string deactivateDate, DateTime seasonStartDate, DateTime seasonEndDate) : base(id ,name, price, isActive)
        {
            SeasonStartDate = seasonStartDate;
            SeasonEndDate = seasonEndDate;
        }


        public DateTime SeasonStartDate { get; set; }
        public DateTime SeasonEndDate { get; set; }
    }
}
