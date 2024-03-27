using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItemUvResources;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.UvResources.QuoteItemList
{
    public class FItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemF1s;
        public ObservableCollection<IItem> ItemF1s
        {
            get => _itemF1s;
            set => SetProperty(ref _itemF1s, value);
        }

        public FItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }

        public override void OnLoadData()
        {
            ItemF1s = Items.Where(x => x is ItemF1).OrderBy(x => x.DesignIndex).ToObservableCollection();
        }

        public override IList<IItem> GetItems()
        {
            ItemF1s.ToList().ForEach(x => x.DesignIndex = ItemF1s.IndexOf(x));

            List<IItem> items = new List<IItem>();

            items.AddRange(ItemF1s);

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
