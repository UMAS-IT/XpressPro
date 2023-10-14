using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.ViewModel.ABB.EditQuoteItem;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.ABB.QuoteItemList
{
    public class BItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemB1s;
        public ObservableCollection<IItem> ItemB1s
        {
            get => _itemB1s;
            set => SetProperty(ref _itemB1s, value);
        }

        private ObservableCollection<IItem> _itemB2s;
        public ObservableCollection<IItem> ItemB2s
        {
            get => _itemB2s;
            set => SetProperty(ref _itemB2s, value);
        }

        private ObservableCollection<IItem> _itemB3s;
        public ObservableCollection<IItem> ItemB3s
        {
            get => _itemB3s;
            set => SetProperty(ref _itemB3s, value);
        }

        private ObservableCollection<IItem> _itemB4s;
        public ObservableCollection<IItem> ItemB4s
        {
            get => _itemB4s;
            set => SetProperty(ref _itemB4s, value);
        }

        private ObservableCollection<IItem> _itemB5s;
        public ObservableCollection<IItem> ItemB5s
        {
            get => _itemB5s;
            set => SetProperty(ref _itemB5s, value);
        }

        public BItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {

        }

        public override void OnLoadData()
        {
            ItemB1s = Items.Where(x => x is ItemB1).ToObservableCollection();
            ItemB2s = Items.Where(x => x is ItemB2).ToObservableCollection();
            ItemB3s = Items.Where(x => x is ItemB3).ToObservableCollection();
            ItemB4s = Items.Where(x => x is ItemB4).ToObservableCollection();
            ItemB5s = Items.Where(x => x is ItemB5).ToObservableCollection();
        }
    }
}
