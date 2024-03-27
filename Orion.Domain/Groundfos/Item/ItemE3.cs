using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.Groundfos.Related;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemGroundfos
{
    public class ItemE3 : ItemE
    {
        private int? _catalogE3Id;
        public int? CatalogE3Id
        {
            get => _catalogE3Id;
            set => SetProperty(ref _catalogE3Id, value);
        }

        private CatalogE3 _catalogE3;
        public CatalogE3 CatalogE3
        {
            get => _catalogE3;
            set => SetProperty(ref _catalogE3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogE3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogE3Id; } }

        public ItemE3() : base()
        {
        }
    }
}
