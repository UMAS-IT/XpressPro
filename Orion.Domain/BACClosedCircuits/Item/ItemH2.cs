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
    public class ItemH2 : Item
    {
        private int? _catalogH2Id;
        public int? CatalogH2Id
        {
            get => _catalogH2Id;
            set => SetProperty(ref _catalogH2Id, value);
        }

        private CatalogH2 _catalogH2;
        public CatalogH2 CatalogH2
        {
            get => _catalogH2;
            set => SetProperty(ref _catalogH2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogH2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogH2Id; } }

        public ItemH2() : base()
        {
        }
    }
}
