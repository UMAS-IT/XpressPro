using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.Entity;
using Orion.Domain.UMAS.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.AboveAir.QuoteItemList
{
    public class NItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemN1s;
        public ObservableCollection<IItem> ItemN1s
        {
            get => _itemN1s;
            set => SetProperty(ref _itemN1s, value);
        }

        public NItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemN1s = Items.Where(x => x is ItemN1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemN1s.ToList().ForEach(x => x.DesignIndex = ItemN1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemN1s);

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
