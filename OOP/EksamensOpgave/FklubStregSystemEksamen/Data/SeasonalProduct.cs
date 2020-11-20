using System;
using System.Collections.Generic;
using System.Text;

namespace FklubStregSystemEksamen.Data
{
    class SeasonalProduct : Product
    {
        public SeasonalProduct(DateTime seasonStartDate, DateTime seasonEndDate, string name, int price) : base(name, price)
        {
            SeasonStartDate = seasonStartDate;
            SeasonEndDate = seasonEndDate;
        }

        public DateTime SeasonStartDate { get; set; }
        public DateTime SeasonEndDate { get; set; }
    }
}
