using Orion.Binding.Interfaces;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}

