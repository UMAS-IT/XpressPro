using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.AmericanWheatley.QuoteItemList
{
    public class CItemListViewModel : ItemListViewModel
    {

        private ObservableCollection<IItem> _itemC1s;
        public ObservableCollection<IItem> ItemC1s
        {
            get => _itemC1s;
            set => SetProperty(ref _itemC1s, value);
        }

        private ObservableCollection<IItem> _itemC2s;
        public ObservableCollection<IItem> ItemC2s
        {
            get => _itemC2s;
            set => SetProperty(ref _itemC2s, value);
        }

        private ObservableCollection<IItem> _itemC3s;
        public ObservableCollection<IItem> ItemC3s
        {
            get => _itemC3s;
            set => SetProperty(ref _itemC3s, value);
        }

        private ObservableCollection<IItem> _itemC4s;
        public ObservableCollection<IItem> ItemC4s
        {
            get => _itemC4s;
            set => SetProperty(ref _itemC4s, value);
        }

        private ObservableCollection<IItem> _itemC5s;
        public ObservableCollection<IItem> ItemC5s
        {
            get => _itemC5s;
            set => SetProperty(ref _itemC5s, value);
        }

        private ObservableCollection<IItem> _itemC6s;
        public ObservableCollection<IItem> ItemC6s
        {
            get => _itemC6s;
            set => SetProperty(ref _itemC6s, value);
        }

        private ObservableCollection<IItem> _itemC7s;
        public ObservableCollection<IItem> ItemC7s
        {
            get => _itemC7s;
            set => SetProperty(ref _itemC7s, value);
        }

        public CItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemC1s = Items.Where(x => x is ItemC1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemC2s = Items.Where(x => x is ItemC2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemC3s = Items.Where(x => x is ItemC3).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemC4s = Items.Where(x => x is ItemC4).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemC5s = Items.Where(x => x is ItemC5).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemC6s = Items.Where(x => x is ItemC6).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemC7s = Items.Where(x => x is ItemC7).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemC1s.ToList().ForEach(x => x.DesignIndex = ItemC1s.IndexOf(x));
            ItemC2s.ToList().ForEach(x => x.DesignIndex = ItemC2s.IndexOf(x));
            ItemC3s.ToList().ForEach(x => x.DesignIndex = ItemC3s.IndexOf(x));
            ItemC4s.ToList().ForEach(x => x.DesignIndex = ItemC4s.IndexOf(x));
            ItemC5s.ToList().ForEach(x => x.DesignIndex = ItemC5s.IndexOf(x));
            ItemC6s.ToList().ForEach(x => x.DesignIndex = ItemC6s.IndexOf(x));
            ItemC7s.ToList().ForEach(x => x.DesignIndex = ItemC7s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemC1s);
            items.AddRange(ItemC2s);
            items.AddRange(ItemC3s);
            items.AddRange(ItemC4s);
            items.AddRange(ItemC5s);
            items.AddRange(ItemC6s);
            items.AddRange(ItemC7s);

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
