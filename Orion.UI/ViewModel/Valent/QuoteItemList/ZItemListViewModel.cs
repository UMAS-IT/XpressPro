using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.Entity;
using Orion.Domain.Valent.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Valent.QuoteItemList
{
    internal class ZItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemZ1s;
        public ObservableCollection<IItem> ItemZ1s
        {
            get => _itemZ1s;
            set => SetProperty(ref _itemZ1s, value);
        }

        public ZItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemZ1s = Items.Where(x => x is ItemZ1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemZ1s.ToList().ForEach(x => x.DesignIndex = ItemZ1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemZ1s);

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
