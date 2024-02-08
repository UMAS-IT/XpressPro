using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Condair.Catalog
{
    public class CatalogQ4 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Condair"; }
        [NotMapped]
        public override string Product { get => "US"; }
        [NotMapped]
        public override string Index { get => "Q4"; }

        public CatalogQ4() : base()
        {
        }
    }
}
