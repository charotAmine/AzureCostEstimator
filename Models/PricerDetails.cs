using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace costEstimator.Models
{
    public class PricerDetails
    {
        public string Operation { get; set; }
        public string Price { get; set; }
        public string PerOperation { get; set; }

        public PricerDetails(string operation, string price, string perOperation)
        {
            Operation = operation;
            Price = price;
            PerOperation = perOperation;
        }
    }
}
