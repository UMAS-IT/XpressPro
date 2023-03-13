using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogBACCoolingTowers;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemBACCoolingTowers
{
    public class ItemG2 : Item
    {
        private int? _catalogG2Id;
        public int? CatalogG2Id
        {
            get => _catalogG2Id;
            set => SetProperty(ref _catalogG2Id, value);
        }

        private CatalogG2 _catalogG2;
        public CatalogG2 CatalogG2
        {
            get => _catalogG2;
            set => SetProperty(ref _catalogG2, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG2; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG2Id; } }

        public ItemG2() : base()
        {
        }
    }
}
