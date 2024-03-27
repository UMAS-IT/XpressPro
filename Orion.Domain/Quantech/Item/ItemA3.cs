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
    // QUANTECH - Air Cooled Stock Post Coated
    public class ItemA3 : ItemA
    {
        private int? _catalogA3Id;
        public int? CatalogA3Id
        {
            get => _catalogA3Id;
            set => SetProperty(ref _catalogA3Id, value);
        }

        private CatalogA3 _catalogA3;
        public CatalogA3 CatalogA3
        {
            get => _catalogA3;
            set => SetProperty(ref _catalogA3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogA3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogA3Id; } }

        public ItemA3() : base()
        {
        }
    }
}
