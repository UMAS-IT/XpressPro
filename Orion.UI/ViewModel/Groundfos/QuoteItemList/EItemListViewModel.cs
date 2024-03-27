using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemGroundfos;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Groundfos.QuoteItemList
{
    public class EItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemE1s;
        public ObservableCollection<IItem> ItemE1s
        {
            get => _itemE1s;
            set => SetProperty(ref _itemE1s, value);
        }

        private ObservableCollection<IItem> _itemE2s;
        public ObservableCollection<IItem> ItemE2s
        {
            get => _itemE2s;
            set => SetProperty(ref _itemE2s, value);
        }

        private ObservableCollection<IItem> _itemE3s;
        public ObservableCollection<IItem> ItemE3s
        {
            get => _itemE3s;
            set => SetProperty(ref _itemE3s, value);
        }

        private ObservableCollection<IItem> _itemE4s;
        public ObservableCollection<IItem> ItemE4s
        {
            get => _itemE4s;
            set => SetProperty(ref _itemE4s, value);
        }

        private ObservableCollection<IItem> _itemE5s;
        public ObservableCollection<IItem> ItemE5s
        {
            get => _itemE5s;
            set => SetProperty(ref _itemE5s, value);
        }

        private ObservableCollection<IItem> _itemE6s;
        public ObservableCollection<IItem> ItemE6s
        {
            get => _itemE6s;
            set => SetProperty(ref _itemE6s, value);
        }

        private ObservableCollection<IItem> _itemE7s;
        public ObservableCollection<IItem> ItemE7s
        {
            get => _itemE7s;
            set => SetProperty(ref _itemE7s, value);
        }

        public EItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemE1s = Items.Where(x => x is ItemE1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemE2s = Items.Where(x => x is ItemE2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemE3s = Items.Where(x => x is ItemE3).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemE4s = Items.Where(x => x is ItemE4).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemE5s = Items.Where(x => x is ItemE5).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemE6s = Items.Where(x => x is ItemE6).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemE7s = Items.Where(x => x is ItemE7).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemE1s.ToList().ForEach(x => x.DesignIndex = ItemE1s.IndexOf(x));
            ItemE2s.ToList().ForEach(x => x.DesignIndex = ItemE2s.IndexOf(x));
            ItemE3s.ToList().ForEach(x => x.DesignIndex = ItemE3s.IndexOf(x));
            ItemE4s.ToList().ForEach(x => x.DesignIndex = ItemE4s.IndexOf(x));
            ItemE5s.ToList().ForEach(x => x.DesignIndex = ItemE5s.IndexOf(x));
            ItemE6s.ToList().ForEach(x => x.DesignIndex = ItemE6s.IndexOf(x));
            ItemE7s.ToList().ForEach(x => x.DesignIndex = ItemE7s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemE1s);
            items.AddRange(ItemE2s);
            items.AddRange(ItemE3s);
            items.AddRange(ItemE4s);
            items.AddRange(ItemE5s);
            items.AddRange(ItemE6s);
            items.AddRange(ItemE7s);

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
