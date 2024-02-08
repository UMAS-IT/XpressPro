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
    public class ItemR3 : ItemR
    {
        private int? _catalogR3Id;
        public int? CatalogR3Id
        {
            get => _catalogR3Id;
            set => SetProperty(ref _catalogR3Id, value);
        }

        private CatalogR3 _catalogR3;
        public CatalogR3 CatalogR3
        {
            get => _catalogR3;
            set => SetProperty(ref _catalogR3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogR3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogR3Id; } }

        public ItemR3() : base()
        {

        }
    }
}
