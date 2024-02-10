using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EnviroTec.Item;
using Orion.Domain.Nortek.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Nortek.QuoteItemList
{
    internal class TItemListViewModel : ItemListViewModel
    {

        private ObservableCollection<IItem> _itemT1s;
        public ObservableCollection<IItem> ItemT1s
        {
            get => _itemT1s;
            set => SetProperty(ref _itemT1s, value);
        }

        private ObservableCollection<IItem> _itemT2s;
        public ObservableCollection<IItem> ItemT2s
        {
            get => _itemT2s;
            set => SetProperty(ref _itemT2s, value);
        }

        private ObservableCollection<IItem> _itemT3s;
        public ObservableCollection<IItem> ItemT3s
        {
            get => _itemT3s;
            set => SetProperty(ref _itemT3s, value);
        }

        public TItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemT1s = Items.Where(x => x is ItemT1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemT2s = Items.Where(x => x is ItemT2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemT3s = Items.Where(x => x is ItemT3).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemT1s.ToList().ForEach(x => x.DesignIndex = ItemT1s.IndexOf(x));
            ItemT2s.ToList().ForEach(x => x.DesignIndex = ItemT2s.IndexOf(x));
            ItemT3s.ToList().ForEach(x => x.DesignIndex = ItemT3s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemT1s);
            items.AddRange(ItemT2s);
            items.AddRange(ItemT3s);

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
