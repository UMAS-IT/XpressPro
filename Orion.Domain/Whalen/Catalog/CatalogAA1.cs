using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Whalen.Catalog
{
    public class CatalogAA1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Whalen"; }
        [NotMapped]
        public override string Product { get => "WSHP"; }
        [NotMapped]
        public override string Index { get => "AA1"; }

        public CatalogAA1() : base()
        {
        }
    }
}
