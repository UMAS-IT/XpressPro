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
    public class ItemH3 : Item
    {
        private int? _catalogH3Id;
        public int? CatalogH3Id
        {
            get => _catalogH3Id;
            set => SetProperty(ref _catalogH3Id, value);
        }

        private CatalogH3 _catalogH3;
        public CatalogH3 CatalogH3
        {
            get => _catalogH3;
            set => SetProperty(ref _catalogH3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogH3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogH3Id; } }

        public ItemH3() : base()
        {
        }
    }
}
