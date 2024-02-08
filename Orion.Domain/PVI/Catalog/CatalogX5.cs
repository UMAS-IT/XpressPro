using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.PVI.Catalog
{
    public class CatalogX5 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "PVI"; }
        [NotMapped]
        public override string Product { get => "Water Heater - Gas"; }
        [NotMapped]
        public override string Index { get => "X5"; }

        public CatalogX5() : base()
        {
        }
    }
}
