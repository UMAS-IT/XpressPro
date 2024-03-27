using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.ABOVEAIR.Item;
using Orion.Domain.Entity;
using Orion.Domain.PlasmaAir.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.PlasmaAir.QuoteItemList
{
    internal class VItemListViewModel : ItemListViewModel
    {


        private ObservableCollection<IItem> _itemV1s;
        public ObservableCollection<IItem> ItemV1s
        {
            get => _itemV1s;
            set => SetProperty(ref _itemV1s, value);
        }

        public VItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemV1s = Items.Where(x => x is ItemV1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemV1s.ToList().ForEach(x => x.DesignIndex = ItemV1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemV1s);

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
