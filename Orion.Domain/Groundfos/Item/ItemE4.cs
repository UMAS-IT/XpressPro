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
    public class ItemE4 : Item
    {
        private int? _catalogE4Id;
        public int? CatalogE4Id
        {
            get => _catalogE4Id;
            set => SetProperty(ref _catalogE4Id, value);
        }

        private CatalogE4 _catalogE4;
        public CatalogE4 CatalogE4
        {
            get => _catalogE4;
            set => SetProperty(ref _catalogE4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogE4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogE4Id; } }

        public ItemE4() : base()
        {
        }
    }
}