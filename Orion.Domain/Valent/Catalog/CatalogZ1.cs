using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Valent.Catalog
{
    public class CatalogZ1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Valent"; }
        [NotMapped]
        public override string Product { get => "Make Up Air Unit"; }
        [NotMapped]
        public override string Index { get => "Z1"; }

        public CatalogZ1() : base()
        {
        }
    }
}
