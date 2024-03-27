using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemABB;
using Orion.Domain.PVI.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.PVI.QuoteItemList
{
    internal class XItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemX1s;
        public ObservableCollection<IItem> ItemX1s
        {
            get => _itemX1s;
            set => SetProperty(ref _itemX1s, value);
        }

        private ObservableCollection<IItem> _itemX2s;
        public ObservableCollection<IItem> ItemX2s
        {
            get => _itemX2s;
            set => SetProperty(ref _itemX2s, value);
        }

        private ObservableCollection<IItem> _itemX3s;
        public ObservableCollection<IItem> ItemX3s
        {
            get => _itemX3s;
            set => SetProperty(ref _itemX3s, value);
        }

        private ObservableCollection<IItem> _itemX4s;
        public ObservableCollection<IItem> ItemX4s
        {
            get => _itemX4s;
            set => SetProperty(ref _itemX4s, value);
        }

        private ObservableCollection<IItem> _itemX5s;
        public ObservableCollection<IItem> ItemX5s
        {
            get => _itemX5s;
            set => SetProperty(ref _itemX5s, value);
        }

        public XItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {

        }

        public override void OnLoadData()
        {
            ItemX1s = Items.Where(x => x is ItemX1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemX2s = Items.Where(x => x is ItemX2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemX3s = Items.Where(x => x is ItemX3).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemX4s = Items.Where(x => x is ItemX4).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemX5s = Items.Where(x => x is ItemX5).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemX1s.ToList().ForEach(x => x.DesignIndex = ItemX1s.IndexOf(x));
            ItemX2s.ToList().ForEach(x => x.DesignIndex = ItemX2s.IndexOf(x));
            ItemX3s.ToList().ForEach(x => x.DesignIndex = ItemX3s.IndexOf(x));
            ItemX4s.ToList().ForEach(x => x.DesignIndex = ItemX4s.IndexOf(x));
            ItemX5s.ToList().ForEach(x => x.DesignIndex = ItemX4s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemX1s);
            items.AddRange(ItemX2s);
            items.AddRange(ItemX3s);
            items.AddRange(ItemX4s);
            items.AddRange(ItemX5s);

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
