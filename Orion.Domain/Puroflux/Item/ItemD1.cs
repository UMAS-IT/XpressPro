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
    public class ItemD1 : Item
    {
        private int? _catalogD1Id;
        public int? CatalogD1Id
        {
            get => _catalogD1Id;
            set => SetProperty(ref _catalogD1Id, value);
        }

        private CatalogD1 _catalogD1;
        public CatalogD1 CatalogD1
        {
            get => _catalogD1;
            set => SetProperty(ref _catalogD1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogD1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogD1Id; } }

        public ItemD1() : base()
        {
        }
    }
}
