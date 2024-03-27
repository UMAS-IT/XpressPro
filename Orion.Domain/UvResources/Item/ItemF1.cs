using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemUvResources
{
    public class ItemF1 : Item
    {
        private int? _catalogF1Id;
        public int? CatalogF1Id
        {
            get => _catalogF1Id;
            set => SetProperty(ref _catalogF1Id, value);
        }

        private CatalogF1 _catalogF1;
        public CatalogF1 CatalogF1
        {
            get => _catalogF1;
            set => SetProperty(ref _catalogF1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogF1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogF1Id; } }

        public ItemF1() : base()
        {
        }
    }
}
