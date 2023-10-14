using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Misc;
using Orion.UI.ViewModel.ABB.EditQuoteItem;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.ABB.QuoteItemList
{
    public class BItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemB1s;
        public ObservableCollection<IItem> ItemB1s
        {
            get => _itemB1s;
            set => SetProperty(ref _itemB1s, value);
        }

        private ObservableCollection<IItem> _itemB2s;
        public ObservableCollection<IItem> ItemB2s
        {
            get => _itemB2s;
            set => SetProperty(ref _itemB2s, value);
        }

        private ObservableCollection<IItem> _itemB3s;
        public ObservableCollection<IItem> ItemB3s
        {
            get => _itemB3s;
            set => SetProperty(ref _itemB3s, value);
        }

        private ObservableCollection<IItem> _itemB4s;
        public ObservableCollection<IItem> ItemB4s
        {
            get => _itemB4s;
            set => SetProperty(ref _itemB4s, value);
        }

        private ObservableCollection<IItem> _itemB5s;
        public ObservableCollection<IItem> ItemB5s
        {
            get => _itemB5s;
            set => SetProperty(ref _itemB5s, value);
        }

        public BItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {

        }

        public override void OnLoadData()
        {
            ItemB1s = Items.Where(x => x is ItemB1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemB2s = Items.Where(x => x is ItemB2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemB3s = Items.Where(x => x is ItemB3).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemB4s = Items.Where(x => x is ItemB4).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemB5s = Items.Where(x => x is ItemB5).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemB1s.ToList().ForEach(x => x.DesignIndex = ItemB1s.IndexOf(x));
            ItemB2s.ToList().ForEach(x => x.DesignIndex = ItemB2s.IndexOf(x));
            ItemB3s.ToList().ForEach(x => x.DesignIndex = ItemB3s.IndexOf(x));
            ItemB4s.ToList().ForEach(x => x.DesignIndex = ItemB4s.IndexOf(x));
            ItemB5s.ToList().ForEach(x => x.DesignIndex = ItemB4s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemB1s);
            items.AddRange(ItemB2s);
            items.AddRange(ItemB3s);
            items.AddRange(ItemB4s);
            items.AddRange(ItemB5s);

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
