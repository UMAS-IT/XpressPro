using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.Entity;
using Orion.Domain.Robur.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Robur.QuoteItemList
{
    internal class YItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemY1s;
        public ObservableCollection<IItem> ItemY1s
        {
            get => _itemY1s;
            set => SetProperty(ref _itemY1s, value);
        }

        public YItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemY1s = Items.Where(x => x is ItemY1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemY1s.ToList().ForEach(x => x.DesignIndex = ItemY1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemY1s);

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
