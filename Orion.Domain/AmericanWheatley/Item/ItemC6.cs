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
    public class ItemC6 : Item
    {
        private int? _catalogC6Id;
        public int? CatalogC6Id
        {
            get => _catalogC6Id;
            set => SetProperty(ref _catalogC6Id, value);
        }

        private CatalogC6 _catalogC6;
        public CatalogC6 CatalogC6
        {
            get => _catalogC6;
            set => SetProperty(ref _catalogC6, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogC6; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogC6Id; } }

        public ItemC6() : base()
        {
        }
    }
}
