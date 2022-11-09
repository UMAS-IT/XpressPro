using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Quantech
{
    public class AQuoteItemListViewModel : BindableBase
    {
        IDialogCoordinator dialogCoordinator;
        QuoteService quoteService;
        MessageService messageService;
        ItemService itemService;
        WindowService windowService;

        int quoteId;

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }

        private IItem _itemSelected;
        public IItem ItemSelected
        {
            get => _itemSelected;
            set => SetProperty(ref _itemSelected, value);
        }

        private IList<IItem> _items;
        public IList<IItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

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

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<string> EditItemsCommand { get; set; }
        public RelayCommand UpdateQuoteItemsCommand { get; set; }
        public RelayCommand BackToProductsCommand { get; set; }

        public RelayCommand<IItem> MoveToStartCommand { get; set; }
        public RelayCommand<IItem> MoveToUpCommand { get; set; }
        public RelayCommand<IItem> DeleteItemCommand { get; set; }
        public RelayCommand<IItem> ShowItemTitlesCommand { get; set; }
        public RelayCommand<IItem> MoveToDownCommand { get; set; }
        public RelayCommand<IItem> MoveToEndCommand { get; set; }

        public Action<IItem> ShowItemTitlesRequested = delegate { };
        public Action BackToProductsRequested = delegate { };

        public AQuoteItemListViewModel(IDialogCoordinator dialogCoordinator, int quoteId)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.quoteId = quoteId;

            LoadDataCommand = new RelayCommand(OnLoadData);
            EditItemsCommand = new RelayCommand<string>(OnEditItems);
            BackToProductsCommand = new RelayCommand(OnBackToProducts);

            MoveToStartCommand = new RelayCommand<IItem>(OnMoveToStart);
            MoveToUpCommand = new RelayCommand<IItem>(OnMoveToUp);
            DeleteItemCommand = new RelayCommand<IItem>(OnDeleteItem);
            ShowItemTitlesCommand = new RelayCommand<IItem>(OnShowItemTitles);
            MoveToDownCommand = new RelayCommand<IItem>(OnMoveToDown);
            MoveToEndCommand = new RelayCommand<IItem>(OnMoveToEnd);
            UpdateQuoteItemsCommand = new RelayCommand(OnUpdateQuoteItems);


            quoteService = new QuoteService();
            itemService = new ItemService();
            windowService = new WindowService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnBackToProducts()
        {
            BackToProductsRequested();
        }

        private void OnShowItemTitles(IItem item)
        {
            ShowItemTitlesRequested(item);
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Loading items, please wait...");

                Quote = quoteService.GetQuoteByQuoteId(quoteId);
                Items = itemService.GetAllItemByQuoteId(quoteId).ToObservableCollection();
                LoadItemLists();

                await messageService.EndMessage("Quote Items", "Items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void LoadItemLists()
        {
            ItemA1s = Items.Where(x => x is ItemA1).ToObservableCollection();
            ItemA2s = Items.Where(x => x is ItemA2).ToObservableCollection();
            ItemA3s = Items.Where(x => x is ItemA3).ToObservableCollection();
            ItemA4s = Items.Where(x => x is ItemA4).ToObservableCollection();
        }

        private async void OnUpdateQuoteItems()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Saving quote items, please wait...");


                if (!await CanUpdateQuoteItems())
                    return;

                List<IItem> items = new List<IItem>();

                // last set of DesignIndex
                ItemA1s.ToList().ForEach(x => x.DesignIndex = ItemA1s.IndexOf(x));
                ItemA2s.ToList().ForEach(x => x.DesignIndex = ItemA2s.IndexOf(x));
                ItemA3s.ToList().ForEach(x => x.DesignIndex = ItemA3s.IndexOf(x));
                ItemA4s.ToList().ForEach(x => x.DesignIndex = ItemA4s.IndexOf(x));

                //add all items in one list
                items.AddRange(ItemA1s);
                items.AddRange(ItemA2s);
                items.AddRange(ItemA3s);
                items.AddRange(ItemA4s);

                Items = itemService.UpdateQuoteAllItems(Quote, items).ToObservableCollection();

                LoadItemLists();

                await messageService.EndMessage("Quote Items", "Quote items has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        private async Task<bool> CanUpdateQuoteItems()
        {
            if (ItemA1s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Air Cooled Factory Lead Time tag is empty, please review this information");
                return false;
            }

            if (ItemA2s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Air Cooled Stock Non Coated tag is empty, please review this information");
                return false;
            }

            if (ItemA3s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Air cooled Stock Post Coated tag is empty, please review this information");
                return false;
            }

            if (ItemA4s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Water Cooled Chiller tag is empty, please review this information");
                return false;
            }
            return true;
        }

        private void OnEditItems(string itemsName)
        {
            if (itemsName.ToFormat() == "a1")
            {
                EditA1ItemViewModel editA1ItemViewModel = new EditA1ItemViewModel(dialogCoordinator, Quote, ItemA1s);
                editA1ItemViewModel.OnItemsSavedRequested += OnItemA1Saved;
                windowService.EditItemsWndow(editA1ItemViewModel, "Edit air cooled chillers factory lead time");
            }
            else if (itemsName.ToFormat() == "a2")
            {
                EditA2ItemViewModel editA2ItemViewModel = new EditA2ItemViewModel(dialogCoordinator, Quote, ItemA2s);
                editA2ItemViewModel.OnItemsSavedRequested += OnItemA2Saved;
                windowService.EditItemsWndow(editA2ItemViewModel, "Edit air cooled chillers stock non coated condenser");
            }
            else if (itemsName.ToFormat() == "a3")
            {
                EditA3ItemViewModel editA3ItemViewModel = new EditA3ItemViewModel(dialogCoordinator, Quote, ItemA3s);
                editA3ItemViewModel.OnItemsSavedRequested += OnItemA3Saved;
                windowService.EditItemsWndow(editA3ItemViewModel, "Edit air cooled chillers stock post coated condenser");
            }
            else if (itemsName.ToFormat() == "a4")
            {
                EditA4ItemViewModel editA4ItemViewModel = new EditA4ItemViewModel(dialogCoordinator, Quote, ItemA4s);
                editA4ItemViewModel.OnItemsSavedRequested += OnItemA4Saved;
                windowService.EditItemsWndow(editA4ItemViewModel, "Edit water cooled chillers factory lead time");
            }
        }

        private void OnItemA1Saved(IList<IItem> editedItems)
        {
            ItemA1s = editedItems.ToObservableCollection();
        }

        private void OnItemA2Saved(IList<IItem> editedItems)
        {
            ItemA2s = editedItems.ToObservableCollection();
        }

        private void OnItemA3Saved(IList<IItem> editedItems)
        {
            ItemA3s = editedItems.ToObservableCollection();
        }

        private void OnItemA4Saved(IList<IItem> editedItems)
        {
            ItemA4s = editedItems.ToObservableCollection();
        }


        private void OnMoveToEnd(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItemICatalogs = GetSelectedItems(item);

            int sectionIndex = currentItemICatalogs.IndexOf(item);
            int lastIndex = currentItemICatalogs.IndexOf(currentItemICatalogs.Last());

            currentItemICatalogs.Move(sectionIndex, lastIndex);
            currentItemICatalogs.ToList().ForEach(s => s.DesignIndex = currentItemICatalogs.IndexOf(s));
        }

        private void OnMoveToDown(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItemICatalogs = GetSelectedItems(item);

            int oldIndex = currentItemICatalogs.IndexOf(item);
            int lastIndex = currentItemICatalogs.IndexOf(currentItemICatalogs.Last());

            if (oldIndex == lastIndex)
                return;

            currentItemICatalogs.Move(oldIndex, oldIndex + 1);
            currentItemICatalogs.ToList().ForEach(s => s.DesignIndex = currentItemICatalogs.IndexOf(s));
        }

        private void OnDeleteItem(IItem item)
        {
            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            currentItems.Remove(item);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }

        private void OnMoveToUp(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            int oldIndex = currentItems.IndexOf(item);

            if (oldIndex == 0)
                return;

            currentItems.Move(oldIndex, oldIndex - 1);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }

        private void OnMoveToStart(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            int sectionIndex = currentItems.IndexOf(item);
            int firstIndex = currentItems.IndexOf(currentItems.First());

            currentItems.Move(sectionIndex, firstIndex);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }

        private ObservableCollection<IItem> GetSelectedItems(IItem item)
        {
            ObservableCollection<IItem> selectedItems = null;

            if (item is ItemA1)
                selectedItems = ItemA1s;
            else if (item is ItemA2)
                selectedItems = ItemA2s;
            else if (item is ItemA3)
                selectedItems = ItemA3s;
            else if (item is ItemA4)
                selectedItems = ItemA4s;
            return selectedItems;
        }

    }
}
