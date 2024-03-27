using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.EnviroTec.Catalog;
using Orion.Domain.EnviroTec.Related;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EnviroTec.Item
{
    public class ItemR1 : ItemR
    {
        private int? _catalogR1Id;
        public int? CatalogR1Id
        {
            get => _catalogR1Id;
            set => SetProperty(ref _catalogR1Id, value);
        }

        private CatalogR1 _catalogR1;
        public CatalogR1 CatalogR1
        {
            get => _catalogR1;
            set => SetProperty(ref _catalogR1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogR1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogR1Id; } }

        public ItemR1() : base()
        {

        }
    }
}
