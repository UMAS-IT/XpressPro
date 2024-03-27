using Orion.Binding.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using static Orion.Helper.Misc.GV;

namespace Orion.Domain.Entity
{
    public interface IItem : IEntity, IPrice, ICloneable
    {
        Quote Quote { get; set; }
        int QuoteId { get; set; }
        string Tag { get; set; }
        bool IsExcluded { get; set; }
        int DesignIndex { get; set; }
        int Quantity { get; set; }
        [NotMapped]
        ICatalog Catalog { get; }
        [NotMapped]
        int? CatalogId { get; }
        IList<Title> Titles { get; set; }
        bool OverridePrice { get; set; }
        [NotMapped]
        double TotalPrice { get; set; }
        [NotMapped]
        bool HasTitles { get; set; }
        double Freight { get; set; }
        [NotMapped]
        double TotalEachPrice { get; set; }
        [NotMapped]
        ItemType ItemType { get; set; }
    }
}

