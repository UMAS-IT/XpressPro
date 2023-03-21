using Orion.Domain.Entity;
using Orion.Domain.Marvair.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Marvair.Item
{
    public class ItemI2 : Entity.Item
    {
        private int? _catalogI2Id;
        public int? CatalogI2Id
        {
            get => _catalogI2Id;
            set => SetProperty(ref _catalogI2Id, value);
        }

        private CatalogI2 _catalogI2;
        public CatalogI2 CatalogI2
        {
            get => _catalogI2;
            set => SetProperty(ref _catalogI2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogI2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogI2Id; } }

        public ItemI2() : base()
        {
        }
    }
}
