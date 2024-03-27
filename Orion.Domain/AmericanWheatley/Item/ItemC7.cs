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
    public class ItemC7 : Item
    {
        private int? _catalogC7Id;
        public int? CatalogC7Id
        {
            get => _catalogC7Id;
            set => SetProperty(ref _catalogC7Id, value);
        }

        private CatalogC7 _catalogC7;
        public CatalogC7 CatalogC7
        {
            get => _catalogC7;
            set => SetProperty(ref _catalogC7, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogC7; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogC7Id; } }

        public ItemC7() : base()
        {
        }
    }
}
