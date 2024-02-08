using Orion.Domain.AERCO.Catalog;
using Orion.Domain.AERCO.Related;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.AERCO.Item
{
    public class ItemO2 : ItemO
    {
        private int? _catalogO2Id;
        public int? CatalogO2Id
        {
            get => _catalogO2Id;
            set => SetProperty(ref _catalogO2Id, value);
        }

        private CatalogO2 _catalogO2;
        public CatalogO2 CatalogO2
        {
            get => _catalogO2;
            set => SetProperty(ref _catalogO2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogO2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogO2Id; } }

        public ItemO2() : base()
        {
        }
    }
}
