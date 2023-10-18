using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.GeneralProduct.QuoteItemList
{
    public class LItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemL1s;
        public ObservableCollection<IItem> ItemL1s
        {
            get => _itemL1s;
            set => SetProperty(ref _itemL1s, value);
        }

        public LItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemL1s = Items.Where(x => x is ItemL1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemL1s.ToList().ForEach(x => x.DesignIndex = ItemL1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemL1s);

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
