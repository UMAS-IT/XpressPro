using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.LYNC.Item;
using Orion.Helper.Extension;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Orion.UI.ViewModel.LYNC.QuoteItemList
{
    internal class SItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemS1s;
        public ObservableCollection<IItem> ItemS1s
        {
            get => _itemS1s;
            set => SetProperty(ref _itemS1s, value);
        }

        public SItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemS1s = Items.Where(x => x is ItemS1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemS1s.ToList().ForEach(x => x.DesignIndex = ItemS1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemS1s);

            return items;
        }

        public override void OnDeleteItem(IItem item)
        {
            base.OnDeleteItem(item);

            if (GetItems().Count <= 0)
                DeleteItemListViewRequested(this);
        }
    }
}
