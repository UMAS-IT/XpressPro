using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Entity
{
    public interface IPrice
    {
        double ListPrice { get; set; }
        double CostMultiplier { get; set; }
        double Cost { get; set; }
        double SellMargin { get; set; }
        double SellPrice { get; set; }
    }
}
