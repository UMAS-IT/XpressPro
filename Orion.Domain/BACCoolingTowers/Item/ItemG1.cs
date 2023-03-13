using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
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
    public class ItemG1 : Item
    {
        private int? _catalogG1Id;
        public int? CatalogG1Id
        {
            get => _catalogG1Id;
            set => SetProperty(ref _catalogG1Id, value);
        }

        private CatalogG1 _catalogG1;
        public CatalogG1 CatalogG1
        {
            get => _catalogG1;
            set => SetProperty(ref _catalogG1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogG1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogG1Id; } }

        public ItemG1() : base()
        {
        }
    }
}
