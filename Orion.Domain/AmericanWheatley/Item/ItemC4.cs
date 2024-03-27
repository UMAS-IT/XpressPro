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
    public class ItemC4 : Item
    {
        private int? _catalogC4Id;
        public int? CatalogC4Id
        {
            get => _catalogC4Id;
            set => SetProperty(ref _catalogC4Id, value);
        }

        private CatalogC4 _catalogC4;
        public CatalogC4 CatalogC4
        {
            get => _catalogC4;
            set => SetProperty(ref _catalogC4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogC4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogC4Id; } }

        public ItemC4() : base()    
        {
        }
    }
}
