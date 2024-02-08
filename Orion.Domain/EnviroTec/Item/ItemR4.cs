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
    public class ItemR4 : ItemR
    {
        private int? _catalogR4Id;
        public int? CatalogR4Id
        {
            get => _catalogR4Id;
            set => SetProperty(ref _catalogR4Id, value);
        }

        private CatalogR4 _catalogR4;
        public CatalogR4 CatalogR4
        {
            get => _catalogR4;
            set => SetProperty(ref _catalogR4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogR4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogR4Id; } }

        public ItemR4() : base()
        {

        }
    }
}
