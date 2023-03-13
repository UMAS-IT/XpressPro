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
    public class ItemE7 : Item
    {
        private int? _catalogE7Id;
        public int? CatalogE7Id
        {
            get => _catalogE7Id;
            set => SetProperty(ref _catalogE7Id, value);
        }

        private CatalogE7 _catalogE7;
        public CatalogE7 CatalogE7
        {
            get => _catalogE7;
            set => SetProperty(ref _catalogE7, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogE7; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogE7Id; } }

        public ItemE7() : base()
        {
        }
    }
}