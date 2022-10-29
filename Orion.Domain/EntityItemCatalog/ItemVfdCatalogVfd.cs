using Orion.Binding.Binding;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemCatalog
{
    public class ItemVfdCatalogVfd : ValidatableBindableBase, IItemICatalog
    {
        private int _itemId;
        public int ItemId
        {
            get => _itemId;
            set => SetProperty(ref _itemId, value);
        }

        private IItem _item;
        [NotMapped]
        public IItem Item
        {
            get => ItemVfd;
            set => SetProperty(ref _item, value);
        }

        private ItemVfd _itemVfd;
        public ItemVfd ItemVfd
        {
            get => _itemVfd;
            set => SetProperty(ref _itemVfd, value);
        }

        private int _catalogId;
        public int CatalogId
        {
            get => _catalogId;
            set => SetProperty(ref _catalogId, value);
        }

        private ICatalog _catalog;
        [NotMapped]
        public ICatalog Catalog
        {
            get => CatalogVfd;
            set => SetProperty(ref _catalog, value);
        }

        private CatalogVfd _catalogVfd;
        public CatalogVfd CatalogVfd
        {
            get => _catalogVfd;
            set => SetProperty(ref _catalogVfd, value);
        }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value);
        }

        private int _designIndex;
        public int DesignIndex
        {
            get => _designIndex;
            set => SetProperty(ref _designIndex, value);
        }

        private bool _isExcluded;
        public bool IsExcluded
        {
            get => _isExcluded;
            set => SetProperty(ref _isExcluded, value);
        }

        private bool _isDeleted;
        [NotMapped]
        public bool IsDeleted
        {
            get => _isDeleted;
            set => SetProperty(ref _isDeleted, value);
        }
    }
}
