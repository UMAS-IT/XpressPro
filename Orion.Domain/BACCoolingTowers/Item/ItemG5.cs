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
    public class ItemG5 : Item
    {
        private int? _catalogG5Id;
        public int? CatalogG5Id
        {
            get => _catalogG5Id;
            set => SetProperty(ref _catalogG5Id, value);
        }

        private CatalogG5 _catalogG5;
        public CatalogG5 CatalogG5
        {
            get => _catalogG5;
            set => SetProperty(ref _catalogG5, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG5; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG5Id; } }

        public ItemG5() : base()
        {

        }
    }
}
