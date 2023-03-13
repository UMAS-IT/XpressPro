using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    //QUANTECH - Water Cooled Chillers
    public class ItemA4 : Item
    {
        private int? _catalogA4Id;
        public int? CatalogA4Id
        {
            get => _catalogA4Id;
            set => SetProperty(ref _catalogA4Id, value);
        }

        private CatalogA4 _catalogA4;
        public CatalogA4 CatalogA4
        {
            get => _catalogA4;
            set => SetProperty(ref _catalogA4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogA4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogA4Id; } }

        public ItemA4() : base()
        {
        }
    }
}
