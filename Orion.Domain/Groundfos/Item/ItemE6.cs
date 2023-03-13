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
    public class ItemE6 : Item
    {
        private int? _catalogE6Id;
        public int? CatalogE6Id
        {
            get => _catalogE6Id;
            set => SetProperty(ref _catalogE6Id, value);
        }

        private CatalogE6 _catalogE6;
        public CatalogE6 CatalogE6
        {
            get => _catalogE6;
            set => SetProperty(ref _catalogE6, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogE6; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogE6Id; } }

        public ItemE6() : base()
        {
        }
    }
}