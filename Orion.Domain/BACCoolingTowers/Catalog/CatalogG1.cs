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
    // BAC Cooling Towers - Series 300
    public class CatalogG1 : Catalog
    {
        [NotMapped]
        public override string Company { get => "BAC - Cooling Towers"; }
        [NotMapped]
        public override string Product { get => "Series 300"; }
        [NotMapped]
        public override string Index { get => "g1"; }

        public CatalogG1() : base()
        {
        }
    }
}
