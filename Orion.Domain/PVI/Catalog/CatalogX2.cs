using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.PVI.Catalog
{
    public class CatalogX2 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "PVI"; }
        [NotMapped]
        public override string Product { get => "Ez Plate Storage Water Heater"; }
        [NotMapped]
        public override string Index { get => "X2"; }

        public CatalogX2() : base()
        {
        }
    }
}
