using Orion.Domain.Entity;
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
    public class ItemR2 : ItemR
    {
        private int? _catalogR2Id;
        public int? CatalogR2Id
        {
            get => _catalogR2Id;
            set => SetProperty(ref _catalogR2Id, value);
        }

        private CatalogR2 _catalogR2;
        public CatalogR2 CatalogR2
        {
            get => _catalogR2;
            set => SetProperty(ref _catalogR2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogR2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogR2Id; } }

        public ItemR2() : base()
        {

        }
    }
}
