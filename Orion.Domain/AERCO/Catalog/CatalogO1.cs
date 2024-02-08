using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.AERCO.Catalog
{
    public class CatalogO1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "AERCO"; }
        [NotMapped]
        public override string Product { get => "Condensing Boilers"; }
        [NotMapped]
        public override string Index { get => "O1"; }

        public CatalogO1() : base()
        {
        }
    }
}
