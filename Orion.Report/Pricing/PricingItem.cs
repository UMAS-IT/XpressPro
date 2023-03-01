using Orion.Binding.Binding;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Report.Pricing
{
    public class PricingItem : ValidatableBindableBase
    {
        public int ItemNumber { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Tags { get; set; }
        public int Quantity { get; set; }
        public bool IsTitle { get; set; }
        public bool IsSpec { get; set; }
        public string Company { get; set; }

        public PricingItem(int itemNumber, string description, double price, string tags, int quantity, string company, bool isTitle = false, bool isSpec = false)
        {
            this.ItemNumber = itemNumber;
            this.Description = description;
            this.Price = price;
            this.Tags = tags;
            this.Quantity = quantity;
            this.IsTitle = isTitle;
            IsSpec = isSpec;
            this.Company = company;
        }

        public PricingItem(int itemNumber, string description, double price, string tags, int quantity, bool isTitle = false, bool isSpec = false)
        {
            this.ItemNumber = itemNumber;
            this.Description = description;
            this.Price = price;
            this.Tags = tags;
            this.Quantity = quantity;
            this.IsTitle = isTitle;
            IsSpec = isSpec;
            this.Company = "";
        }
    }
}
