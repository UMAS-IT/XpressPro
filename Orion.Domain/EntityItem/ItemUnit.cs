using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    public class ItemUnit : ValidatableBindableBase, IItem
    {
        private int _Id;
        public int Id
        {
            get => _Id;
            set => SetProperty(ref _Id, value);
        }

        private string _tag;
        public string Tag
        {
            get => _tag;
            set => SetProperty(ref _tag, value);
        }

        private int _designIndex;
        public int DesignIndex
        {
            get => _designIndex;
            set => SetProperty(ref _designIndex, value);
        }

        private int _quantity;
        public int Quantity
        {
            get => _quantity;
            set => SetProperty(ref _quantity, value);
        }

        private bool _isExclded;
        public bool IsExcluded
        {
            get => _isExclded;
            set => SetProperty(ref _isExclded, value);
        }

        [NotMapped]
        public string DefaultItemName { get { return "Units"; } }

        private int _quoteId;
        public int QuoteId
        {
            get => _quoteId;
            set => SetProperty(ref _quoteId, value);
        }

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }


        private int? _catalogUnitId;
        public int? CatalogUnitId
        {
            get => _catalogUnitId;
            set => SetProperty(ref _catalogUnitId, value);
        }

        private CatalogUnit _catalogUnit;
        public CatalogUnit CatalogUnit
        {
            get => _catalogUnit;
            set => SetProperty(ref _catalogUnit, value);
        }

        [NotMapped]
        public ICatalog Catalog { get { return CatalogUnit; } }

        [NotMapped]
        public int? CatalogId { get { return CatalogUnitId; } }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        public ItemUnit()
        {
            Tag = "";
            Titles = new ObservableCollection<Title>();
        }
    }
}
