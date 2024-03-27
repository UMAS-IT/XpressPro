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
    // BAC Cooling Towers - PT2
    public class CatalogG3 : Catalog
    {
        [NotMapped]
        public override string Company { get => "BAC - Open Loop Towers"; }
        [NotMapped]
        public override string Product { get => "PT2"; }
        [NotMapped]
        public override string Index { get => "g3"; }

        public CatalogG3() : base()
        {
        }
    }
}
