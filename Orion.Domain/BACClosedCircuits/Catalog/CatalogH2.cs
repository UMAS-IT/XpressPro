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

namespace Orion.Domain.EntityCatalogBACClosedCircuits
{
    // BAC Closed Circuits - PFI
    public class CatalogH2 : Catalog
    {
        [NotMapped]
        public override string Company { get => "BAC - Closed Circuits"; }
        [NotMapped]
        public override string Product { get => "PFi"; }
        [NotMapped]
        public override string Index { get => "h2"; }

        public CatalogH2() : base()
        {
        }
    }
}
