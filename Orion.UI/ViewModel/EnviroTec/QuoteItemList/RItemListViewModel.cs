using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Condair.Item;
using Orion.Domain.Entity;
using Orion.Domain.EnviroTec.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.EnviroTec.QuoteItemList
{
    internal class RItemListViewModel : ItemListViewModel
    {

        private ObservableCollection<IItem> _itemR1s;
        public ObservableCollection<IItem> ItemR1s
        {
            get => _itemR1s;
            set => SetProperty(ref _itemR1s, value);
        }

        private ObservableCollection<IItem> _itemR2s;
        public ObservableCollection<IItem> ItemR2s
        {
            get => _itemR2s;
            set => SetProperty(ref _itemR2s, value);
        }

        private ObservableCollection<IItem> _itemR3s;
        public ObservableCollection<IItem> ItemR3s
        {
            get => _itemR3s;
            set => SetProperty(ref _itemR3s, value);
        }

        private ObservableCollection<IItem> _itemR4s;
        public ObservableCollection<IItem> ItemR4s
        {
            get => _itemR4s;
            set => SetProperty(ref _itemR4s, value);
        }

        public RItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemR1s = Items.Where(x => x is ItemR1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemR2s = Items.Where(x => x is ItemR2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemR3s = Items.Where(x => x is ItemR3).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemR4s = Items.Where(x => x is ItemR4).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemR1s.ToList().ForEach(x => x.DesignIndex = ItemR1s.IndexOf(x));
            ItemR2s.ToList().ForEach(x => x.DesignIndex = ItemR2s.IndexOf(x));
            ItemR3s.ToList().ForEach(x => x.DesignIndex = ItemR3s.IndexOf(x));
            ItemR4s.ToList().ForEach(x => x.DesignIndex = ItemR4s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemR1s);
            items.AddRange(ItemR2s);
            items.AddRange(ItemR3s);
            items.AddRange(ItemR4s);

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
