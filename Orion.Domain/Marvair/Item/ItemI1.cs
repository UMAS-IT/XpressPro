using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogUvResources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Marvair.Item
{
    public class ItemI1 : Entity.Item
    {
        private int? _catalogI1Id;
        public int? CatalogI1Id
        {
            get => _catalogI1Id;
            set => SetProperty(ref _catalogI1Id, value);
        }

        private CatalogI1 _catalogI1;
        public CatalogI1 CatalogI1
        {
            get => _catalogI1;
            set => SetProperty(ref _catalogI1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogI1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogI1Id; } }

        public ItemI1() : base()
        {
        }
    }
}
