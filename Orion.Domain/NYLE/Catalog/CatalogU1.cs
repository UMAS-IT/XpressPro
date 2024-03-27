using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.NYLE.Catalog
{
    public class CatalogU1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "NYLE"; }
        [NotMapped]
        public override string Product { get => "Air Source Heat Pump"; }
        [NotMapped]
        public override string Index { get => "U1"; }

        public CatalogU1() : base()
        {
        }
    }
}
