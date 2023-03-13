using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogBACClosedCircuits;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemBACClosedCircuits
{
    public class ItemH4 : Item
    {
        private int? _catalogH4Id;
        public int? CatalogH4Id
        {
            get => _catalogH4Id;
            set => SetProperty(ref _catalogH4Id, value);
        }

        private CatalogH4 _catalogH4;
        public CatalogH4 CatalogH4
        {
            get => _catalogH4;
            set => SetProperty(ref _catalogH4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogH4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogH4Id; } }

        public ItemH4() : base()
        {
        }
    }
}
