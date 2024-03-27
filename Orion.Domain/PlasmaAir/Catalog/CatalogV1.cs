using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.PlasmaAir.Catalog
{
    public class CatalogV1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Plasma Air"; }
        [NotMapped]
        public override string Product { get => "Needlepoint"; }
        [NotMapped]
        public override string Index { get => "V1"; }

        public CatalogV1() : base()
        {
        }
    }
}
