using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Nortek.Catalog
{
    public class CatalogT1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Nortek"; }
        [NotMapped]
        public override string Product { get => "Temtrol Coils"; }
        [NotMapped]
        public override string Index { get => "T1"; }

        public CatalogT1() : base()
        {
        }
    }
}
