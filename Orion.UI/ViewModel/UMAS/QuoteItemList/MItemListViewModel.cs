using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.PACE.Item;
using Orion.Domain.UMAS.Item;
using Orion.Helper.Extension;
using Orion.UI.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.UMAS.QuoteItemList
{
    public class MItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemM1s;
        public ObservableCollection<IItem> ItemM1s
        {
            get => _itemM1s;
            set => SetProperty(ref _itemM1s, value);
        }

        public MItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemM1s = Items.Where(x => x is ItemM1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemM1s.ToList().ForEach(x => x.DesignIndex = ItemM1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemM1s);

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
