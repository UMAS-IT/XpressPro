using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.BACClosedCircuits.QuoteItemList
{
    public class HItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemH1s;
        public ObservableCollection<IItem> ItemH1s
        {
            get => _itemH1s;
            set => SetProperty(ref _itemH1s, value);
        }

        private ObservableCollection<IItem> _itemH2s;
        public ObservableCollection<IItem> ItemH2s
        {
            get => _itemH2s;
            set => SetProperty(ref _itemH2s, value);
        }

        private ObservableCollection<IItem> _itemH3s;
        public ObservableCollection<IItem> ItemH3s
        {
            get => _itemH3s;
            set => SetProperty(ref _itemH3s, value);
        }

        private ObservableCollection<IItem> _itemH4s;
        public ObservableCollection<IItem> ItemH4s
        {
            get => _itemH4s;
            set => SetProperty(ref _itemH4s, value);
        }

        private ObservableCollection<IItem> _itemH5s;
        public ObservableCollection<IItem> ItemH5s
        {
            get => _itemH5s;
            set => SetProperty(ref _itemH5s, value);
        }

        public HItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemH1s = Items.Where(x => x is ItemH1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemH2s = Items.Where(x => x is ItemH2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemH3s = Items.Where(x => x is ItemH3).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemH4s = Items.Where(x => x is ItemH4).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemH5s = Items.Where(x => x is ItemH5).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemH1s.ToList().ForEach(x => x.DesignIndex = ItemH1s.IndexOf(x));
            ItemH2s.ToList().ForEach(x => x.DesignIndex = ItemH2s.IndexOf(x));
            ItemH3s.ToList().ForEach(x => x.DesignIndex = ItemH3s.IndexOf(x));
            ItemH4s.ToList().ForEach(x => x.DesignIndex = ItemH4s.IndexOf(x));
            ItemH5s.ToList().ForEach(x => x.DesignIndex = ItemH5s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemH1s);
            items.AddRange(ItemH2s);
            items.AddRange(ItemH3s);
            items.AddRange(ItemH4s);
            items.AddRange(ItemH5s);

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
