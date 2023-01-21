using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.ABB.EditQuoteItem;
using Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem;
using Orion.UI.ViewModel.Quantech;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel
{
    public class ItemViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private ProjectService projectService;
        private QuoteService quoteService;
        ItemService itemService;
        private MainWindowViewModel mw;
        WindowService windowService;
        private int projectId;
        private int quoteId;
        private readonly AirTreatmentViewModel airTreatmentViewModel = new AirTreatmentViewModel();

        private BindableBase _titlesViewModel;
        public BindableBase TitlesViewModel
        {
            get => _titlesViewModel;
            set => SetProperty(ref _titlesViewModel, value);
        }

        private bool _titlesActive;
        public bool TitlesActive
        {
            get => _titlesActive;
            set => SetProperty(ref _titlesActive, value);
        }

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }

        private ObservableCollection<Title> _titles;
        public ObservableCollection<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }

        private ObservableCollection<IItem> _items;
        public ObservableCollection<IItem> Items
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

        private ObservableCollection<IItem> _itemC1s;
        public ObservableCollection<IItem> ItemC1s
        {
            get => _itemC1s;
            set => SetProperty(ref _itemC1s, value);
        }

        private ObservableCollection<IItem> _itemC2s;
        public ObservableCollection<IItem> ItemC2s
        {
            get => _itemC2s;
            set => SetProperty(ref _itemC2s, value);
        }

        private ObservableCollection<IItem> _itemC3s;
        public ObservableCollection<IItem> ItemC3s
        {
            get => _itemC3s;
            set => SetProperty(ref _itemC3s, value);
        }

        private ObservableCollection<IItem> _itemC4s;
        public ObservableCollection<IItem> ItemC4s
        {
            get => _itemC4s;
            set => SetProperty(ref _itemC4s, value);
        }

        public RelayCommand BackToQuotesCommad { get; set; }
        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<string> EditItemsCommand { get; set; }
        public RelayCommand UpdateQuoteItemsCommand { get; set; }

        public Action BackToQuotesRequested = delegate { };
        public RelayCommand<IItem> MoveToStartCommand { get; set; }
        public RelayCommand<IItem> MoveToUpCommand { get; set; }
        public RelayCommand<IItem> DeleteItemCommand { get; set; }
        public RelayCommand<IItem> ShowItemTitlesCommand { get; set; }
        public RelayCommand<IItem> MoveToDownCommand { get; set; }
        public RelayCommand<IItem> MoveToEndCommand { get; set; }

        public ItemViewModel(IDialogCoordinator dialogCoordinator, int projectId, int quoteId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.projectId = projectId;
            this.quoteId = quoteId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand(OnLoadData);
            BackToQuotesCommad = new RelayCommand(OnBackToQuotes);
            EditItemsCommand = new RelayCommand<string>(OnEditItems);
            MoveToStartCommand = new RelayCommand<IItem>(OnMoveToStart);
            MoveToUpCommand = new RelayCommand<IItem>(OnMoveToUp);
            DeleteItemCommand = new RelayCommand<IItem>(OnDeleteItem);
            ShowItemTitlesCommand = new RelayCommand<IItem>(OnShowItemTitles);
            MoveToDownCommand = new RelayCommand<IItem>(OnMoveToDown);
            MoveToEndCommand = new RelayCommand<IItem>(OnMoveToEnd);
            UpdateQuoteItemsCommand = new RelayCommand(OnUpdateQuoteItems);

            projectService = new ProjectService();
            quoteService = new QuoteService();
            messageService = new MessageService(dialogCoordinator, this);
            windowService = new WindowService();
            itemService = new ItemService();
        }

        private void LoadItemLists()
        {
            ItemA1s = Items.Where(x => x is ItemA1).ToObservableCollection();
            ItemA2s = Items.Where(x => x is ItemA2).ToObservableCollection();
            ItemA3s = Items.Where(x => x is ItemA3).ToObservableCollection();
            ItemA4s = Items.Where(x => x is ItemA4).ToObservableCollection();

            ItemB1s = Items.Where(x => x is ItemB1).ToObservableCollection();
            ItemB2s = Items.Where(x => x is ItemB2).ToObservableCollection();
            ItemB3s = Items.Where(x => x is ItemB3).ToObservableCollection();
            ItemB4s = Items.Where(x => x is ItemB4).ToObservableCollection();
            ItemB5s = Items.Where(x => x is ItemB5).ToObservableCollection();

            ItemC1s = Items.Where(x => x is ItemC1).ToObservableCollection();
            ItemC2s = Items.Where(x => x is ItemC2).ToObservableCollection();
            ItemC3s = Items.Where(x => x is ItemC3).ToObservableCollection();
            ItemC4s = Items.Where(x => x is ItemC4).ToObservableCollection();
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

                // last set of DesignIndex
                ItemB1s.ToList().ForEach(x => x.DesignIndex = ItemB1s.IndexOf(x));
                ItemB2s.ToList().ForEach(x => x.DesignIndex = ItemB2s.IndexOf(x));
                ItemB3s.ToList().ForEach(x => x.DesignIndex = ItemB3s.IndexOf(x));
                ItemB4s.ToList().ForEach(x => x.DesignIndex = ItemB4s.IndexOf(x));
                ItemB5s.ToList().ForEach(x => x.DesignIndex = ItemB5s.IndexOf(x));

                // last set of DesignIndex
                ItemC1s.ToList().ForEach(x => x.DesignIndex = ItemC1s.IndexOf(x));
                ItemC2s.ToList().ForEach(x => x.DesignIndex = ItemC2s.IndexOf(x));
                ItemC3s.ToList().ForEach(x => x.DesignIndex = ItemC3s.IndexOf(x));
                ItemC4s.ToList().ForEach(x => x.DesignIndex = ItemC4s.IndexOf(x));

                //add all items in one list
                items.AddRange(ItemA1s);
                items.AddRange(ItemA2s);
                items.AddRange(ItemA3s);
                items.AddRange(ItemA4s);

                items.AddRange(ItemB1s);
                items.AddRange(ItemB2s);
                items.AddRange(ItemB3s);
                items.AddRange(ItemB4s);
                items.AddRange(ItemB5s);

                items.AddRange(ItemC1s);
                items.AddRange(ItemC2s);
                items.AddRange(ItemC3s);
                items.AddRange(ItemC4s);

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

            if (ItemB1s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "BARE tag is empty, please review this information");
                return false;
            }

            if (ItemB2s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "VCR tag is empty, please review this information");
                return false;
            }

            if (ItemB3s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "PCR tag is empty, please review this information");
                return false;
            }

            if (ItemB4s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "BCR tag is empty, please review this information");
                return false;
            }

            if (ItemB5s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Accesories tag is empty, please review this information");
                return false;
            }

            if (ItemC1s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Triple Duty Valves tag is empty, please review this information");
                return false;
            }

            if (ItemC2s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Suction Diffusers tag is empty, please review this information");
                return false;
            }

            if (ItemC3s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Tanks tag is empty, please review this information");
                return false;
            }

            if (ItemC4s.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Separators tag is empty, please review this information");
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
            else if (itemsName.ToFormat() == "b1")
            {
                EditB1ItemViewModel editB1ItemViewModel = new EditB1ItemViewModel(dialogCoordinator, Quote, ItemB1s);
                editB1ItemViewModel.OnItemsSavedRequested += OnItemB1Saved;
                windowService.EditItemsWndow(editB1ItemViewModel, "Edit BARE");
            }
            else if (itemsName.ToFormat() == "b2")
            {
                EditB2ItemViewModel editB2ItemViewModel = new EditB2ItemViewModel(dialogCoordinator, Quote, ItemB2s);
                editB2ItemViewModel.OnItemsSavedRequested += OnItemB2Saved;
                windowService.EditItemsWndow(editB2ItemViewModel, "Edit VCR");
            }
            else if (itemsName.ToFormat() == "b3")
            {
                EditB3ItemViewModel editB3ItemViewModel = new EditB3ItemViewModel(dialogCoordinator, Quote, ItemB3s);
                editB3ItemViewModel.OnItemsSavedRequested += OnItemB3Saved;
                windowService.EditItemsWndow(editB3ItemViewModel, "Edit PCR");
            }
            else if (itemsName.ToFormat() == "b4")
            {
                EditB4ItemViewModel editB4ItemViewModel = new EditB4ItemViewModel(dialogCoordinator, Quote, ItemB4s);
                editB4ItemViewModel.OnItemsSavedRequested += OnItemB4Saved;
                windowService.EditItemsWndow(editB4ItemViewModel, "Edit BCR");
            }
            else if (itemsName.ToFormat() == "b5")
            {
                EditB5ItemViewModel editB5ItemViewModel = new EditB5ItemViewModel(dialogCoordinator, Quote, ItemB5s);
                editB5ItemViewModel.OnItemsSavedRequested += OnItemB5Saved;
                windowService.EditItemsWndow(editB5ItemViewModel, "Edit Accesories");
            }
            else if (itemsName.ToFormat() == "c1")
            {
                EditC1ItemViewModel editC1ItemViewModel = new EditC1ItemViewModel(dialogCoordinator, Quote, ItemC1s);
                editC1ItemViewModel.OnItemsSavedRequested += OnItemC1Saved;
                windowService.EditItemsWndow(editC1ItemViewModel, "Edit CARE");
            }
            else if (itemsName.ToFormat() == "c2")
            {
                EditC2ItemViewModel editC2ItemViewModel = new EditC2ItemViewModel(dialogCoordinator, Quote, ItemC2s);
                editC2ItemViewModel.OnItemsSavedRequested += OnItemC2Saved;
                windowService.EditItemsWndow(editC2ItemViewModel, "Edit VCR");
            }
            else if (itemsName.ToFormat() == "c3")
            {
                EditC3ItemViewModel editC3ItemViewModel = new EditC3ItemViewModel(dialogCoordinator, Quote, ItemC3s);
                editC3ItemViewModel.OnItemsSavedRequested += OnItemC3Saved;
                windowService.EditItemsWndow(editC3ItemViewModel, "Edit PCR");
            }
            else if (itemsName.ToFormat() == "c4")
            {
                EditC4ItemViewModel editC4ItemViewModel = new EditC4ItemViewModel(dialogCoordinator, Quote, ItemC4s);
                editC4ItemViewModel.OnItemsSavedRequested += OnItemC4Saved;
                windowService.EditItemsWndow(editC4ItemViewModel, "Edit CCR");
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

        private void OnItemB1Saved(IList<IItem> editedItems)
        {
            ItemB1s = editedItems.ToObservableCollection();
        }

        private void OnItemB2Saved(IList<IItem> editedItems)
        {
            ItemB2s = editedItems.ToObservableCollection();
        }

        private void OnItemB3Saved(IList<IItem> editedItems)
        {
            ItemB3s = editedItems.ToObservableCollection();
        }

        private void OnItemB4Saved(IList<IItem> editedItems)
        {
            ItemB4s = editedItems.ToObservableCollection();
        }

        private void OnItemB5Saved(IList<IItem> editedItems)
        {
            ItemB5s = editedItems.ToObservableCollection();
        }

        private void OnItemC1Saved(IList<IItem> editedItems)
        {
            ItemC1s = editedItems.ToObservableCollection();
        }

        private void OnItemC2Saved(IList<IItem> editedItems)
        {
            ItemC2s = editedItems.ToObservableCollection();
        }

        private void OnItemC3Saved(IList<IItem> editedItems)
        {
            ItemC3s = editedItems.ToObservableCollection();
        }

        private void OnItemC4Saved(IList<IItem> editedItems)
        {
            ItemC4s = editedItems.ToObservableCollection();
        }

        private async void OnShowItemTitles(IItem item)
        {
            if (TitlesViewModel is TitleFromItemViewModel)
                return;

            TitlesActive = true;

            TitlesViewModel = null;
            await Task.Delay(100);

            TitleFromItemViewModel titleFromItemViewModel = new TitleFromItemViewModel(dialogCoordinator, item);

            titleFromItemViewModel.BackFromItemTitlesRequested += OnBackFromItemTitles;

            TitlesViewModel = titleFromItemViewModel;
        }

        private async void OnBackFromItemTitles()
        {
            TitlesActive = false;
            TitlesViewModel = null;
            await Task.Delay(100);
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Loading items, please wait...");

                //ProductsActive = true;
                Project = projectService.GetProjectById(projectId);
                Quote = quoteService.GetQuoteByQuoteId(quoteId);
                mw.Title = $@"XpressPro ({Project.Name} / {Quote.Name})";
                Items = itemService.GetAllItemByQuoteId(quoteId).ToObservableCollection();
                LoadItemLists();

                await messageService.EndMessage("Quote Items", "Items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnBackToQuotes()
        {
            BackToQuotesRequested();
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
            else if (item is ItemB1)
                selectedItems = ItemB1s;
            else if (item is ItemB2)
                selectedItems = ItemB2s;
            else if (item is ItemB3)
                selectedItems = ItemB3s;
            else if (item is ItemB4)
                selectedItems = ItemB4s;
            else if (item is ItemB5)
                selectedItems = ItemB5s;
            else if (item is ItemC1)
                selectedItems = ItemC1s;
            else if (item is ItemC2)
                selectedItems = ItemC2s;
            else if (item is ItemC3)
                selectedItems = ItemC3s;
            else if (item is ItemC4)
                selectedItems = ItemC4s;
            return selectedItems;
        }

    }
}
