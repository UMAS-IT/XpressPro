using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.AERCO.Item;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.AERCO.QuoteItemList
{
    public class OItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemO1s;
        public ObservableCollection<IItem> ItemO1s
        {
            get => _itemO1s;
            set => SetProperty(ref _itemO1s, value);
        }

        private ObservableCollection<IItem> _itemO2s;
        public ObservableCollection<IItem> ItemO2s
        {
            get => _itemO2s;
            set => SetProperty(ref _itemO2s, value);
        }

        public OItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemO1s = Items.Where(x => x is ItemO1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemO2s = Items.Where(x => x is ItemO2).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemO1s.ToList().ForEach(x => x.DesignIndex = ItemO1s.IndexOf(x));
            ItemO2s.ToList().ForEach(x => x.DesignIndex = ItemO2s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemO1s);
            items.AddRange(ItemO2s);

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
