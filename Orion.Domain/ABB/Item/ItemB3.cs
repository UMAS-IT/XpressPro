using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemABB
{
    public class ItemB3: Item
    {
        private int? _catalogB3Id;
        public int? CatalogB3Id
        {
            get => _catalogB3Id;
            set => SetProperty(ref _catalogB3Id, value);
        }

        private CatalogB3 _catalogB3;
        public CatalogB3 CatalogB3
        {
            get => _catalogB3;
            set => SetProperty(ref _catalogB3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogB3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogB3Id; } }

        public ItemB3() : base()
        {

        }
    }
}
