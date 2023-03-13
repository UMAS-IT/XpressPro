using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
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
    public class ItemH1 : Item
    {
        private int? _catalogH1Id;
        public int? CatalogH1Id
        {
            get => _catalogH1Id;
            set => SetProperty(ref _catalogH1Id, value);
        }

        private CatalogH1 _catalogH1;
        public CatalogH1 CatalogH1
        {
            get => _catalogH1;
            set => SetProperty(ref _catalogH1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogH1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogH1Id; } }

        public ItemH1() : base()
        {
        }
    }
}
