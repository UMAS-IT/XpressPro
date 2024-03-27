using Orion.Binding.Binding;
using Orion.Domain.Entity;
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
    public class ItemE5 : ItemE
    {
        private int? _catalogE5Id;
        public int? CatalogE5Id
        {
            get => _catalogE5Id;
            set => SetProperty(ref _catalogE5Id, value);
        }

        private CatalogE5 _catalogE5;
        public CatalogE5 CatalogE5
        {
            get => _catalogE5;
            set => SetProperty(ref _catalogE5, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogE5; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogE5Id; } }

        public ItemE5() : base()
        {

        }
    }
}