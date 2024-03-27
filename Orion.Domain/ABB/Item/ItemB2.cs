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
    public class ItemB2 : Item
    {
        private int? _catalogB2Id;
        public int? CatalogB2Id
        {
            get => _catalogB2Id;
            set => SetProperty(ref _catalogB2Id, value);
        }

        private CatalogB2 _catalogB2;
        public CatalogB2 CatalogB2
        {
            get => _catalogB2;
            set => SetProperty(ref _catalogB2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogB2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogB2Id; } }

        public ItemB2() : base()
        {
        }

    }
}
