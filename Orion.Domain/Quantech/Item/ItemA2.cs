using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.Quantech.Related;
using Orion.Helper.Extension;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    //QUANTECH - Air Cooled Stock Non Coated
    public class ItemA2 : ItemA
    {
        private int? _catalogA2Id;
        public int? CatalogA2Id
        {
            get => _catalogA2Id;
            set => SetProperty(ref _catalogA2Id, value);
        }

        private CatalogA2 _catalogA2;
        public CatalogA2 CatalogA2
        {
            get => _catalogA2;
            set => SetProperty(ref _catalogA2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogA2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogA2Id; } }

        public ItemA2() : base()
        {
        }
    }
}
