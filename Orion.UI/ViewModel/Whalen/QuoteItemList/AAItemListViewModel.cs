using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.Entity;
using Orion.Domain.Whalen.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Whalen.QuoteItemList
{
    internal class AAItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemAA1s;
        public ObservableCollection<IItem> ItemAA1s
        {
            get => _itemAA1s;
            set => SetProperty(ref _itemAA1s, value);
        }

        public AAItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemAA1s = Items.Where(x => x is ItemAA1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemAA1s.ToList().ForEach(x => x.DesignIndex = ItemAA1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemAA1s);

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
