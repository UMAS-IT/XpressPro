using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.Entity;
using Orion.Domain.NYLE.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.NYLE.QuoteItemList
{
    internal class UItemListViewModel : ItemListViewModel
    {

        private ObservableCollection<IItem> _itemU1s;
        public ObservableCollection<IItem> ItemU1s
        {
            get => _itemU1s;
            set => SetProperty(ref _itemU1s, value);
        }

        public UItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemU1s = Items.Where(x => x is ItemU1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemU1s.ToList().ForEach(x => x.DesignIndex = ItemU1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemU1s);

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
