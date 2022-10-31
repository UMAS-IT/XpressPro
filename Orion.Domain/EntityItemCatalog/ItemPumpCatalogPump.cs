using Orion.Binding.Binding;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItemCatalog
{
    public class ItemPumpCatalogPump : ValidatableBindableBase, IItemICatalog
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
            get => ItemPump;
            set => SetProperty(ref _item, value);
        }

        private ItemPump _itemPump;
        public ItemPump ItemPump
        {
            get => _itemPump;
            set => SetProperty(ref _itemPump, value);
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
            get => CatalogPump;
            set => SetProperty(ref _catalog, value);
        }

        private CatalogPump _catalogPump;
        public CatalogPump CatalogPump
        {
            get => _catalogPump;
            set => SetProperty(ref _catalogPump, value);
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

        private string _tag;
        public string Tag
        {
            get => _tag;
            set => SetProperty(ref _tag, value);
        }
        public ItemPumpCatalogPump()
        {
            Tag = "";
        }
    }
}
