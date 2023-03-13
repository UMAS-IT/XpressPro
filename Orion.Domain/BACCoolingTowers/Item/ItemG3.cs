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
    public class ItemG3 : Item
    {
        private int? _catalogG3Id;
        public int? CatalogG3Id
        {
            get => _catalogG3Id;
            set => SetProperty(ref _catalogG3Id, value);
        }

        private CatalogG3 _catalogG3;
        public CatalogG3 CatalogG3
        {
            get => _catalogG3;
            set => SetProperty(ref _catalogG3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG3Id; } }

        public ItemG3() : base()
        {
        }
    }
}
