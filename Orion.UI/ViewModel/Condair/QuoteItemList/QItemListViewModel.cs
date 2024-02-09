using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Condair.Item;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Condair.QuoteItemList
{
    internal class QItemListViewModel : ItemListViewModel
    {

        private ObservableCollection<IItem> _itemQ1s;
        public ObservableCollection<IItem> ItemQ1s
        {
            get => _itemQ1s;
            set => SetProperty(ref _itemQ1s, value);
        }

        private ObservableCollection<IItem> _itemQ2s;
        public ObservableCollection<IItem> ItemQ2s
        {
            get => _itemQ2s;
            set => SetProperty(ref _itemQ2s, value);
        }

        private ObservableCollection<IItem> _itemQ3s;
        public ObservableCollection<IItem> ItemQ3s
        {
            get => _itemQ3s;
            set => SetProperty(ref _itemQ3s, value);
        }

        private ObservableCollection<IItem> _itemQ4s;
        public ObservableCollection<IItem> ItemQ4s
        {
            get => _itemQ4s;
            set => SetProperty(ref _itemQ4s, value);
        }

        public QItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemQ1s = Items.Where(x => x is ItemQ1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemQ2s = Items.Where(x => x is ItemQ2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemQ3s = Items.Where(x => x is ItemQ3).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemQ4s = Items.Where(x => x is ItemQ4).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemQ1s.ToList().ForEach(x => x.DesignIndex = ItemQ1s.IndexOf(x));
            ItemQ2s.ToList().ForEach(x => x.DesignIndex = ItemQ2s.IndexOf(x));
            ItemQ3s.ToList().ForEach(x => x.DesignIndex = ItemQ3s.IndexOf(x));
            ItemQ4s.ToList().ForEach(x => x.DesignIndex = ItemQ4s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemQ1s);
            items.AddRange(ItemQ2s);
            items.AddRange(ItemQ3s);
            items.AddRange(ItemQ4s);

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
