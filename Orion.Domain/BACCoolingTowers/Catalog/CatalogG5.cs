using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogBACCoolingTowers
{
    // BAC Cooling Towers - Series V (VT0/VT1)
    public class CatalogG5 : Catalog
    {
        [NotMapped]
        public override string Company { get => "BAC - Cooling Towers"; }
        [NotMapped]
        public override string Product { get => "Series V (VT0 / VT1)"; }
        [NotMapped]
        public override string Index { get => "g5"; }

        public CatalogG5() : base()
        {
        }
    }
}
