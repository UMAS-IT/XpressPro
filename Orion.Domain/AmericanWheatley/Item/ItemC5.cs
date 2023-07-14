using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemAmericanWheatley
{
    public class ItemC5 : Item
    {
        private int? _catalogC5Id;
        public int? CatalogC5Id
        {
            get => _catalogC5Id;
            set => SetProperty(ref _catalogC5Id, value);
        }

        private CatalogC5 _catalogC5;
        public CatalogC5 CatalogC5
        {
            get => _catalogC5;
            set => SetProperty(ref _catalogC5, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogC5; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogC5Id; } }

        public ItemC5() : base()
        {
        }
    }
}
