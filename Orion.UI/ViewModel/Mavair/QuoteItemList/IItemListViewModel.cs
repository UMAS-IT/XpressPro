using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.Marvair.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Mavair.QuoteItemList
{
    public class IItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemI1s;
        public ObservableCollection<IItem> ItemI1s
        {
            get => _itemI1s;
            set => SetProperty(ref _itemI1s, value);
        }

        private ObservableCollection<IItem> _itemI2s;
        public ObservableCollection<IItem> ItemI2s
        {
            get => _itemI2s;
            set => SetProperty(ref _itemI2s, value);
        }

        public IItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemI1s = Items.Where(x => x is ItemI1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemI2s = Items.Where(x => x is ItemI2).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemI1s.ToList().ForEach(x => x.DesignIndex = ItemI1s.IndexOf(x));
            ItemI2s.ToList().ForEach(x => x.DesignIndex = ItemI2s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemI1s);
            items.AddRange(ItemI2s);

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
