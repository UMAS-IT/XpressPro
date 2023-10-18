using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.Multiaqua.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Multiaqua.QuoteItemList
{
    public class KItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemK1s;
        public ObservableCollection<IItem> ItemK1s
        {
            get => _itemK1s;
            set => SetProperty(ref _itemK1s, value);
        }

        private ObservableCollection<IItem> _itemK2s;
        public ObservableCollection<IItem> ItemK2s
        {
            get => _itemK2s;
            set => SetProperty(ref _itemK2s, value);
        }

        private ObservableCollection<IItem> _itemK3s;
        public ObservableCollection<IItem> ItemK3s
        {
            get => _itemK3s;
            set => SetProperty(ref _itemK3s, value);
        }

        public KItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemK1s = Items.Where(x => x is ItemK1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemK2s = Items.Where(x => x is ItemK2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemK3s = Items.Where(x => x is ItemK3).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemK1s.ToList().ForEach(x => x.DesignIndex = ItemK1s.IndexOf(x));
            ItemK2s.ToList().ForEach(x => x.DesignIndex = ItemK2s.IndexOf(x));
            ItemK3s.ToList().ForEach(x => x.DesignIndex = ItemK3s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemK1s);
            items.AddRange(ItemK2s);
            items.AddRange(ItemK3s);

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
