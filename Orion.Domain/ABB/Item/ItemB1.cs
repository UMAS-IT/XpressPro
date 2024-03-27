using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemABB
{
    public class ItemB1 : Item
    {
        private int? _catalogB1Id;
        public int? CatalogB1Id
        {
            get => _catalogB1Id;
            set => SetProperty(ref _catalogB1Id, value);
        }

        private CatalogB1 _catalogB1;
        public CatalogB1 CatalogB1
        {
            get => _catalogB1;
            set => SetProperty(ref _catalogB1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogB1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogB1Id; } }

        public ItemB1() : base()
        {

        }

    }
}
