using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.PVI.Catalog
{
    public class CatalogX4 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "PVI"; }
        [NotMapped]
        public override string Product { get => "Water Heater - Electric"; }
        [NotMapped]
        public override string Index { get => "X4"; }

        public CatalogX4() : base()
        {
        }
    }
}
