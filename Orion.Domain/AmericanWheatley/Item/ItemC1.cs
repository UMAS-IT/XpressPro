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
    public class ItemC1 : Item
    {
        private int? _catalogC1Id;
        public int? CatalogC1Id
        {
            get => _catalogC1Id;
            set => SetProperty(ref _catalogC1Id, value);
        }

        private CatalogC1 _catalogC1;
        public CatalogC1 CatalogC1
        {
            get => _catalogC1;
            set => SetProperty(ref _catalogC1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogC1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogC1Id; } }

        public ItemC1() : base()
        {
        }
    }
}
