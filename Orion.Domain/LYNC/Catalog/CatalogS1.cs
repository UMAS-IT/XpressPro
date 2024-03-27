using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.LYNC.Catalog
{
    public class CatalogS1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "LYNC"; }
        [NotMapped]
        public override string Product { get => "Aegis"; }
        [NotMapped]
        public override string Index { get => "S1"; }

        public CatalogS1() : base()
        {
        }
    }
}
