using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Puroflux.QuoteItemList
{
    public class DItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemD1s;
        public ObservableCollection<IItem> ItemD1s
        {
            get => _itemD1s;
            set => SetProperty(ref _itemD1s, value);
        }

        private ObservableCollection<IItem> _itemD2s;
        public ObservableCollection<IItem> ItemD2s
        {
            get => _itemD2s;
            set => SetProperty(ref _itemD2s, value);
        }

        public DItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemD1s = Items.Where(x => x is ItemD1).OrderBy(x => x.DesignIndex).ToObservableCollection();
            ItemD2s = Items.Where(x => x is ItemD2).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemD1s.ToList().ForEach(x => x.DesignIndex = ItemD1s.IndexOf(x));
            ItemD2s.ToList().ForEach(x => x.DesignIndex = ItemD2s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemD1s);
            items.AddRange(ItemD2s);

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
