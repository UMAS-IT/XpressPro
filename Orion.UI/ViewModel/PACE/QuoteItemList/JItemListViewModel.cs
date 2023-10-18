using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.PACE.Item;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.PACE.QuoteItemList
{
    public class JItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemJ1s;
        public ObservableCollection<IItem> ItemJ1s
        {
            get => _itemJ1s;
            set => SetProperty(ref _itemJ1s, value);
        }

        public JItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemJ1s = Items.Where(x => x is ItemJ1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemJ1s.ToList().ForEach(x => x.DesignIndex = ItemJ1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemJ1s);

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
