using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemCatalog
{
    public interface IItemICatalog
    {
        int ItemId { get; set; }
        [NotMapped]
        IItem Item { get; set; }
        int CatalogId { get; set; }
        [NotMapped]
        ICatalog Catalog { get; set; }
        int DesignIndex { get; set; }
        int Quantity { get; set; }
        bool IsActive { get; set; }
        bool IsExcluded { get; set; }
        [NotMapped]
        bool IsDeleted { get; set; }
    }
}
