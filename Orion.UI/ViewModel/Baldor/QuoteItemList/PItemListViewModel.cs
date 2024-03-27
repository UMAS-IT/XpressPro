using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Baldor.Item;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Baldor.QuoteItemList
{
    internal class PItemListViewModel : ItemListViewModel
    {

        private ObservableCollection<IItem> _itemP1s;
        public ObservableCollection<IItem> ItemP1s
        {
            get => _itemP1s;
            set => SetProperty(ref _itemP1s, value);
        }

        public PItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemP1s = Items.Where(x => x is ItemP1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemP1s.ToList().ForEach(x => x.DesignIndex = ItemP1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemP1s);

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
