using Orion.Binding.Binding;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemCatalog
{
    public class ItemVfdCatalogVfd : ValidatableBindableBase
    {

        private int _itemVfdId;
        public int ItemVfdId
        {
            get => _itemVfdId;
            set => SetProperty(ref _itemVfdId, value);
        }

        private ItemVfd _itemVdf;
        public ItemVfd ItemVfd
        {
            get => _itemVdf;
            set => SetProperty(ref _itemVdf, value);
        }

        private int _catalogVfdId;
        public int CatalogVfdId
        {
            get => _catalogVfdId;
            set => SetProperty(ref _catalogVfdId, value);
        }

        private CatalogVfd _catalogVfd;
        public CatalogVfd CatalogVfd
        {
            get => _catalogVfd;
            set => SetProperty(ref _catalogVfd, value);
        }
    }
}
