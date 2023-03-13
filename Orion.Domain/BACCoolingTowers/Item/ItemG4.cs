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
    public class ItemG4 : Item
    {
        private int? _catalogG4Id;
        public int? CatalogG4Id
        {
            get => _catalogG4Id;
            set => SetProperty(ref _catalogG4Id, value);
        }

        private CatalogG4 _catalogG4;
        public CatalogG4 CatalogG4
        {
            get => _catalogG4;
            set => SetProperty(ref _catalogG4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG4Id; } }

        public ItemG4() : base()
        {

        }
    }
}
