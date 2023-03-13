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
    public class ItemH5 : Item
    {
        private int? _catalogH5Id;
        public int? CatalogH5Id
        {
            get => _catalogH5Id;
            set => SetProperty(ref _catalogH5Id, value);
        }

        private CatalogH5 _catalogH5;
        public CatalogH5 CatalogH5
        {
            get => _catalogH5;
            set => SetProperty(ref _catalogH5, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogH5; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogH5Id; } }

        public ItemH5() :base()
        {
        }
    }
}
