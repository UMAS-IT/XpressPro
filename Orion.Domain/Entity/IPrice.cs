using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Entity
{
    public interface IPrice
    {
        double ListPrice { get; set; }
        double CostMultiplier { get; set; }
        [NotMapped]
        double Cost { get; set; }
        double SellMargin { get; set; }
        [NotMapped]
        double SellPrice { get; set; }

    }
}
