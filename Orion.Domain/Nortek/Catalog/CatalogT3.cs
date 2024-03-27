using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Nortek.Catalog
{
    public class CatalogT3 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Nortek"; }
        [NotMapped]
        public override string Product { get => "Temtrol Huntair Fan Wall"; }
        [NotMapped]
        public override string Index { get => "T3"; }

        public CatalogT3() : base()
        {
        }
    }
}
