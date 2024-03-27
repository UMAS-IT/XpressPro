using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemAmericanWheatley
{
    public class ItemC2 : Item
    {
        private int? _catalogC2Id;
        public int? CatalogC2Id
        {
            get => _catalogC2Id;
            set => SetProperty(ref _catalogC2Id, value);
        }

        private CatalogC2 _catalogC2;
        public CatalogC2 CatalogC2
        {
            get => _catalogC2;
            set => SetProperty(ref _catalogC2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogC2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogC2Id; } }

        public ItemC2() : base()
        {
        }
    }
}
