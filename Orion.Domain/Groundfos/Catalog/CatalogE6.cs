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

namespace Orion.Domain.EntityCatalogGroundfos
{
    // Groundfos - VLS
    public class CatalogE6 : Catalog
    {
        [NotMapped]
        public override string Company { get => "Grundfos"; }
        [NotMapped]
        public override string Product { get => "VLS"; }
        [NotMapped]
        public override string Index { get => "e6"; }

        public CatalogE6() : base()
        {
        }
    }
}