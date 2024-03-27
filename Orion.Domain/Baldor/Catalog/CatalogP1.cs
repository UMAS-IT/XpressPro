using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Baldor.Catalog
{
    public class CatalogP1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Baldor"; }
        [NotMapped]
        public override string Product { get => "Motors"; }
        [NotMapped]
        public override string Index { get => "P1"; }

        public CatalogP1() : base()
        {
        }
    }
}
