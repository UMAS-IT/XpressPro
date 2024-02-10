using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.Entity;
using Orion.Domain.Polaris.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Polaris.QuoteItemList
{
    internal class WItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemW1s;
        public ObservableCollection<IItem> ItemW1s
        {
            get => _itemW1s;
            set => SetProperty(ref _itemW1s, value);
        }

        public WItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemW1s = Items.Where(x => x is ItemW1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemW1s.ToList().ForEach(x => x.DesignIndex = ItemW1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemW1s);

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
