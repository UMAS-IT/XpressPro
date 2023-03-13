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
    // BAC Closed Circuits - VF1/VFL Low Profile
    public class CatalogH3 : Catalog
    {
        [NotMapped]
        public override string Company { get => "BAC - Closed Circuits"; }
        [NotMapped]
        public override string Product { get => "VF1 and VFL Low Profile"; }
        [NotMapped]
        public override string Index { get => "h3"; }

        public CatalogH3() : base()
        {
        }
    }
}
