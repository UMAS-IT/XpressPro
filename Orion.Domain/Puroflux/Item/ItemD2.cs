using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemPuroFlux
{
    public class ItemD2 : Item
    {
        private int? _catalogD2Id;
        public int? CatalogD2Id
        {
            get => _catalogD2Id;
            set => SetProperty(ref _catalogD2Id, value);
        }

        private CatalogD2 _catalogD2;
        public CatalogD2 CatalogD2
        {
            get => _catalogD2;
            set => SetProperty(ref _catalogD2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogD2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogD2Id; } }

        public ItemD2() : base()
        {
        }
    }
}
