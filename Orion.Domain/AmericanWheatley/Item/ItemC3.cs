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
    public class ItemC3 : Item
    {
        private int? _catalogC3Id;
        public int? CatalogC3Id
        {
            get => _catalogC3Id;
            set => SetProperty(ref _catalogC3Id, value);
        }

        private CatalogC3 _catalogC3;
        public CatalogC3 CatalogC3
        {
            get => _catalogC3;
            set => SetProperty(ref _catalogC3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogC3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogC3Id; } }

        public ItemC3() : base()
        {

        }
    }
}
