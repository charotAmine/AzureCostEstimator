using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace costEstimator.Models
{
    public class PricerModel
    {
        public PricerModel(string serviceType, List<PricerDetails> serviceDetails)
        {
            this.serviceType = serviceType;
            this.serviceDetails = serviceDetails;
        }

        public string serviceType { get; set; }
        public List<PricerDetails> serviceDetails { get; set; }

    }
}
