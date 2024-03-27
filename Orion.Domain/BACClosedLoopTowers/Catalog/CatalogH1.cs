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

namespace Orion.Domain.EntityCatalogBACClosedLoopTowers
{
    // BAC Closed Circuits - FXV/FXV3
    public class CatalogH1 : Catalog
    {

        [NotMapped]
        public override string Company { get => "BAC - Closed Loop Towers"; }
        [NotMapped]
        public override string Product { get => "Closed Loop Towers"; }
        [NotMapped]
        public override string Index { get => "h1"; }

        public CatalogH1() : base()
        {
        }
    }
}
