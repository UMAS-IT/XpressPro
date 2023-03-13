using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogGroundfos;
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
    public class ItemE2 : Item
    {
        private int? _catalogE2Id;
        public int? CatalogE2Id
        {
            get => _catalogE2Id;
            set => SetProperty(ref _catalogE2Id, value);
        }

        private CatalogE2 _catalogE2;
        public CatalogE2 CatalogE2
        {
            get => _catalogE2;
            set => SetProperty(ref _catalogE2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogE2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogE2Id; } }

        public ItemE2() : base()
        {
        }
    }
}