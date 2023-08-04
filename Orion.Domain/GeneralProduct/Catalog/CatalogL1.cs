using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogGeneralProduct
{
    public class CatalogL1 : Catalog
    {
        [NotMapped]
        public override string Company { get => "General Product"; }
        [NotMapped]
        public override string Product { get => "Custom"; }
        [NotMapped]
        public override string Index { get => "l1"; }

        public CatalogL1() : base()
        {
        }
    }
}
