using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogGroundfos;
using Orion.Domain.Groundfos.Related;
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
    public class ItemE1 : ItemE
    {
        private int? _catalogE1Id;
        public int? CatalogE1Id
        {
            get => _catalogE1Id;
            set => SetProperty(ref _catalogE1Id, value);
        }

        private CatalogE1 _catalogE1;
        public CatalogE1 CatalogE1
        {
            get => _catalogE1;
            set => SetProperty(ref _catalogE1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogE1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogE1Id; } }

        public ItemE1() : base()
        {

        }
    }
}