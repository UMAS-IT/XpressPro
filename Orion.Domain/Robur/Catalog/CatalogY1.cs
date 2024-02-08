using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Robur.Catalog
{
    public class CatalogY1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Robur"; }
        [NotMapped]
        public override string Product { get => "Robur Component"; }
        [NotMapped]
        public override string Index { get => "Y1"; }

        public CatalogY1() : base()
        {
        }
    }
}
