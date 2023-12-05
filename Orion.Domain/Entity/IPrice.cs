using System.ComponentModel.DataAnnotations.Schema;

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
