using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedLoopTowers;
using Orion.Domain.EntityItemBACOpenLoopTowers;
using Orion.Domain.EntityItemGeneralProduct;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Domain.Marvair.Item;
using Orion.Domain.Multiaqua.Item;
using Orion.Domain.PACE.Item;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using Orion.UI.Command;
using Orion.UI.ViewModel.ABB.QuoteItemList;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.Quantech.QuoteItemList
{
    public class AItemListViewModel : ItemListViewModel
    {
        private ObservableCollection<IItem> _itemA1s;
        public ObservableCollection<IItem> ItemA1s
        {
            get => _itemA1s;
            set => SetProperty(ref _itemA1s, value);
        }

        private ObservableCollection<IItem> _itemA2s;
        public ObservableCollection<IItem> ItemA2s
        {
            get => _itemA2s;
            set => SetProperty(ref _itemA2s, value);
        }

        private ObservableCollection<IItem> _itemA3s;
        public ObservableCollection<IItem> ItemA3s
        {
            get => _itemA3s;
            set => SetProperty(ref _itemA3s, value);
        }

        private ObservableCollection<IItem> _itemA4s;
        public ObservableCollection<IItem> ItemA4s
        {
            get => _itemA4s;
            set => SetProperty(ref _itemA4s, value);
        }

        public AItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {

        }

        public override void OnLoadData()
        {
            ItemA1s = Items.Where(x => x is ItemA1).ToObservableCollection();
            ItemA2s = Items.Where(x => x is ItemA2).ToObservableCollection();
            ItemA3s = Items.Where(x => x is ItemA3).ToObservableCollection();
            ItemA4s = Items.Where(x => x is ItemA4).ToObservableCollection();
        }


    }
}
