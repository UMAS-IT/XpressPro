using Orion.Binding.Interfaces;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    public interface IItem : IEntity
    {
        [NotMapped]
        string DefaultItemName { get; }
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
        double Price { get; set; }
    }
}

