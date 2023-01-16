using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingItem
    {
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public PricingItem(int itemNumber, string description, double price)
        {
            this.ItemNumber = itemNumber;
            this.Description = description;
            this.Price = price;
        }
    }
}
