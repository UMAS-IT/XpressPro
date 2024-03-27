using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.AERCO.Catalog
{
    public class CatalogO2 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "AERCO"; }
        [NotMapped]
        public override string Product { get => "Water Heaters"; }
        [NotMapped]
        public override string Index { get => "O2"; }

        public CatalogO2() : base()
        {
        }
    }
}
