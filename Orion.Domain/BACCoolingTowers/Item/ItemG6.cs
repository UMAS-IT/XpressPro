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
    public class ItemG6 : Item
    {
        private int? _catalogG6Id;
        public int? CatalogG6Id
        {
            get => _catalogG6Id;
            set => SetProperty(ref _catalogG6Id, value);
        }

        private CatalogG6 _catalogG6;
        public CatalogG6 CatalogG6
        {
            get => _catalogG6;
            set => SetProperty(ref _catalogG6, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG6; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG6Id; } }

        public ItemG6() : base()
        {

        }
    }
}
