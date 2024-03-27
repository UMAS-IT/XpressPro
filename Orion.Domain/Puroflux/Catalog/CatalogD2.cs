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

namespace Orion.Domain.EntityCatalogPuroflux
{
    // Puroflux - Sand Filters
    public class CatalogD2 : Catalog
    {
        [NotMapped]
        public override string Company { get => "Puroflux"; }
        [NotMapped]
        public override string Product { get => "Sand Filters"; }
        [NotMapped]
        public override string Index { get => "D2"; }

        public CatalogD2() : base()
        {
        }
    }
}
