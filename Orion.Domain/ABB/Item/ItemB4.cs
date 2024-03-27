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
    public class ItemB4 : Item
    {
        private int? _catalogB4Id;
        public int? CatalogB4Id
        {
            get => _catalogB4Id;
            set => SetProperty(ref _catalogB4Id, value);
        }

        private CatalogB4 _catalogB4;
        public CatalogB4 CatalogB4
        {
            get => _catalogB4;
            set => SetProperty(ref _catalogB4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogB4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogB4Id; } }

        public ItemB4() : base()
        {
        }
    }
}
