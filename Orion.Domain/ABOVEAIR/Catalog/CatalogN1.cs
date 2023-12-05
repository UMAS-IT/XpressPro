using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.ABOVEAIR.Catalog
{
    public class CatalogN1 : Entity.Catalog
    {

        [NotMapped]
        public override string Company { get => "ABOVE AIR"; }
        [NotMapped]
        public override string Product { get => "Mission Critical"; }
        [NotMapped]
        public override string Index { get => "N1"; }

        public CatalogN1() : base()
        {
        }
    }
}
