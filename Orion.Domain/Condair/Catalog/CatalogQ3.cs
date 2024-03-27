using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Condair.Catalog
{
    public class CatalogQ3 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Condair"; }
        [NotMapped]
        public override string Product { get => "RO-(US)"; }
        [NotMapped]
        public override string Index { get => "Q3"; }

        public CatalogQ3() : base()
        {
        }
    }
}
