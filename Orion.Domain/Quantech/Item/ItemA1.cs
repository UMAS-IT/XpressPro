using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    //QUANTECH - Air Cooled Factory Lead Time
    public class ItemA1 : Item
    {
        private int? _catalogA1Id;
        public int? CatalogA1Id
        {
            get => _catalogA1Id;
            set => SetProperty(ref _catalogA1Id, value);
        }

        private CatalogA1 _catalogA1;
        public CatalogA1 CatalogA1
        {
            get => _catalogA1;
            set => SetProperty(ref _catalogA1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogA1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogA1Id; } }

        public ItemA1() : base()
        {
        }
    }
}
