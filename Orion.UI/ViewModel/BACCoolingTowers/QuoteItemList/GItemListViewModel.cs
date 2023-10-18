using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.BACCoolingTowers.QuoteItemList
{
    public class GItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemG1s;
        public ObservableCollection<IItem> ItemG1s
        {
            get => _itemG1s;
            set => SetProperty(ref _itemG1s, value);
        }

        private ObservableCollection<IItem> _itemG2s;
        public ObservableCollection<IItem> ItemG2s
        {
            get => _itemG2s;
            set => SetProperty(ref _itemG2s, value);
        }

        private ObservableCollection<IItem> _itemG3s;
        public ObservableCollection<IItem> ItemG3s
        {
            get => _itemG3s;
            set => SetProperty(ref _itemG3s, value);
        }

        private ObservableCollection<IItem> _itemG4s;
        public ObservableCollection<IItem> ItemG4s
        {
            get => _itemG4s;
            set => SetProperty(ref _itemG4s, value);
        }

        private ObservableCollection<IItem> _itemG5s;
        public ObservableCollection<IItem> ItemG5s
        {
            get => _itemG5s;
            set => SetProperty(ref _itemG5s, value);
        }

        private ObservableCollection<IItem> _itemG6s;
        public ObservableCollection<IItem> ItemG6s
        {
            get => _itemG6s;
            set => SetProperty(ref _itemG6s, value);
        }

        public GItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemG1s = Items.Where(x => x is ItemG1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemG2s = Items.Where(x => x is ItemG2).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemG3s = Items.Where(x => x is ItemG3).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemG4s = Items.Where(x => x is ItemG4).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemG5s = Items.Where(x => x is ItemG5).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemG6s = Items.Where(x => x is ItemG6).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemG1s.ToList().ForEach(x => x.DesignIndex = ItemG1s.IndexOf(x));
            ItemG2s.ToList().ForEach(x => x.DesignIndex = ItemG2s.IndexOf(x));
            ItemG3s.ToList().ForEach(x => x.DesignIndex = ItemG3s.IndexOf(x));
            ItemG4s.ToList().ForEach(x => x.DesignIndex = ItemG4s.IndexOf(x));
            ItemG5s.ToList().ForEach(x => x.DesignIndex = ItemG5s.IndexOf(x));
            ItemG6s.ToList().ForEach(x => x.DesignIndex = ItemG6s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemG1s);
            items.AddRange(ItemG2s);
            items.AddRange(ItemG3s);
            items.AddRange(ItemG4s);
            items.AddRange(ItemG5s);
            items.AddRange(ItemG6s);

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
