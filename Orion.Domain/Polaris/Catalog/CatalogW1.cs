using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Polaris.Catalog
{
    public class CatalogW1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Polaris"; }
        [NotMapped]
        public override string Product { get => "Plate & Frame HX"; }
        [NotMapped]
        public override string Index { get => "W1"; }

        public CatalogW1() : base()
        {
        }
    }
}
