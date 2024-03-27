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
    public class ItemB5 : Item
    {
        private int? _catalogB5Id;
        public int? CatalogB5Id
        {
            get => _catalogB5Id;
            set => SetProperty(ref _catalogB5Id, value);
        }

        private CatalogB5 _catalogB5;
        public CatalogB5 CatalogB5
        {
            get => _catalogB5;
            set => SetProperty(ref _catalogB5, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogB5; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogB5Id; } }

        public ItemB5() : base()
        {
        }
    }
}
