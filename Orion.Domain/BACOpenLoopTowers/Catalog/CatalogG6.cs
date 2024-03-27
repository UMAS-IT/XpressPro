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

namespace Orion.Domain.EntityCatalogBACOpenLoopTowers
{
    // BAC Cooling Towers - Low Profile Series V(VTL)
    public class CatalogG6 : Catalog
    {
        [NotMapped]
        public override string Company { get => "BAC - Open Loop Towers"; }
        [NotMapped]
        public override string Product { get => "Low Profile Seires V (VT1)"; }
        [NotMapped]
        public override string Index { get => "g6"; }

        public CatalogG6() : base()
        {
        }
    }
}
