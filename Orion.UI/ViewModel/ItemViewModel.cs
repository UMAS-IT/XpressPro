using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.EditItemViewModel;
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
        private ItemService itemService;
        private ProjectService projectService;
        private QuoteService quoteService;
        private TitleService titleService;
        private MainWindowViewModel mw;
        WindowService windowService;
        private int projectId;
        private int quoteId;

        private bool _itemTitlesActive;
        public bool ItemTitlesActive
        {
            get => _itemTitlesActive;
            set => SetProperty(ref _itemTitlesActive, value);
        }

        private IItem _itemSelected;
        public IItem ItemSelected
        {
            get => _itemSelected;
            set => SetProperty(ref _itemSelected, value);
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

        private ObservableCollection<IItem> _airCooledChillers;
        public ObservableCollection<IItem> AirCooledChillers
        {
            get => _airCooledChillers;
            set => SetProperty(ref _airCooledChillers, value);
        }

        private ObservableCollection<IItem> _units;
        public ObservableCollection<IItem> Units
        {
            get => _units;
            set => SetProperty(ref _units, value);
        }

        private ObservableCollection<IItem> _pumps;
        public ObservableCollection<IItem> Pumps
        {
            get => _pumps;
            set => SetProperty(ref _pumps, value);
        }

        private ObservableCollection<IItem> _vfds;
        public ObservableCollection<IItem> Vfds
        {
            get => _vfds;
            set => SetProperty(ref _vfds, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<string> EditItemsCommand { get; set; }

        public RelayCommand<IItem> MoveToStartCommand { get; set; }
        public RelayCommand<IItem> MoveToUpCommand { get; set; }
        public RelayCommand<IItem> DeleteItemCommand { get; set; }
        public RelayCommand<IItem> ShowItemTitlesCommand { get; set; }
        public RelayCommand<IItem> MoveToDownCommand { get; set; }
        public RelayCommand<IItem> MoveToEndCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public RelayCommand UpdateQuoteItemsCommand { get; set; }


        public RelayCommand AddTitleCommand { get; set; }
        public RelayCommand<Title> AddSpecCommand { get; set; }
        public RelayCommand<Title> DeleteTitleCommand { get; set; }
        public RelayCommand<Spec> DeleteSpecCommand { get; set; }
        public RelayCommand UpdateItemTitlesCommand { get; set; }
        public RelayCommand BackFromTitlesCommand { get; set; }

        public Action OnUpdateItemsRequested = delegate { };

        public ItemViewModel(IDialogCoordinator dialogCoordinator, int projectId, int quoteId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.projectId = projectId;
            this.quoteId = quoteId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand(OnLoadData);
            EditItemsCommand = new RelayCommand<string>(OnEditItems);

            MoveToStartCommand = new RelayCommand<IItem>(OnMoveToStart);
            MoveToUpCommand = new RelayCommand<IItem>(OnMoveToUp);
            DeleteItemCommand = new RelayCommand<IItem>(OnDeleteItem);
            ShowItemTitlesCommand = new RelayCommand<IItem>(OnShowItemTitles);
            MoveToDownCommand = new RelayCommand<IItem>(OnMoveToDown);
            MoveToEndCommand = new RelayCommand<IItem>(OnMoveToEnd);
            UpdateQuoteItemsCommand = new RelayCommand(OnUpdateQuoteItems);
            BackCommand = new RelayCommand(OnBack);

            AddTitleCommand = new RelayCommand(OnAddTitle);
            AddSpecCommand = new RelayCommand<Title>(OnAddSpec);
            DeleteTitleCommand = new RelayCommand<Title>(OnDeleteTitle);
            DeleteSpecCommand = new RelayCommand<Spec>(OnDeleteSpec);
            UpdateItemTitlesCommand = new RelayCommand(OnUpdateItemTitles);
            BackFromTitlesCommand = new RelayCommand(OnBackFromItemTitles);

            itemService = new ItemService();
            projectService = new ProjectService();
            quoteService = new QuoteService();
            titleService = new TitleService();
            messageService = new MessageService(dialogCoordinator, this);
            windowService = new WindowService();
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
                AirCooledChillers.ToList().ForEach(x => x.DesignIndex = AirCooledChillers.IndexOf(x));
                Units.ToList().ForEach(x => x.DesignIndex = Units.IndexOf(x));
                Pumps.ToList().ForEach(x => x.DesignIndex = Pumps.IndexOf(x));
                Vfds.ToList().ForEach(x => x.DesignIndex = Vfds.IndexOf(x));

                //add all items in one list
                items.AddRange(AirCooledChillers);
                items.AddRange(Units);
                items.AddRange(Pumps);
                items.AddRange(Vfds);

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

        private void LoadItemLists()
        {
            AirCooledChillers = Items.Where(x => x is ItemAirCooledChiller).ToObservableCollection();
            Units = Items.Where(x => x is ItemUnit).ToObservableCollection();
            Pumps = Items.Where(x => x is ItemPump).ToObservableCollection();
            Vfds = Items.Where(x => x is ItemVfd).ToObservableCollection();
        }

        private async Task<bool> CanUpdateQuoteItems()
        {
            if (AirCooledChillers.Any() && string.IsNullOrWhiteSpace(Quote.ItemAirCooledChillersName))
            {
                await messageService.ResultMessage("Error", "Air cooled chillers title is empty, please review this information");
                return false;
            }
            if (AirCooledChillers.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Air cooled chiller tag is empty, please review this information");
                return false;
            }

            if (Units.Any() && string.IsNullOrWhiteSpace(Quote.ItemUnitsName))
            {
                await messageService.ResultMessage("Error", "Units title is empty, please review this information");
                return false;
            }
            if (Units.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Unit tag is empty, please review this information");
                return false;
            }

            if (Pumps.Any() && string.IsNullOrWhiteSpace(Quote.ItemPumpsName))
            {
                await messageService.ResultMessage("Error", "Pumps title is empty, please review this information");
                return false;
            }
            if (Pumps.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Pump tag is empty, please review this information");
                return false;
            }

            if (Vfds.Any() && string.IsNullOrWhiteSpace(Quote.ItemVfdsName))
            {
                await messageService.ResultMessage("Error", "Vfds title is empty, please review this information");
                return false;
            }
            if (Vfds.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Vfd tag is empty, please review this information");
                return false;
            }
            return true;
        }

        private void OnEditItems(string itemsName)
        {
            if (itemsName.ToFormat() == "air cooled chillers")
            {
                EditItemAirCooledChillerViewModel editItemAirCooledChillerViewModel = new EditItemAirCooledChillerViewModel(dialogCoordinator, Quote, AirCooledChillers);
                editItemAirCooledChillerViewModel.OnItemsSavedRequested += OnAirCooledChillersSaved;
                windowService.EditItemsWndow(editItemAirCooledChillerViewModel, "Edit Air Cooler Chillers");
            }
            else if (itemsName.ToFormat() == "units")
            {
                EditItemUnitViewModel editItemUnitViewModel = new EditItemUnitViewModel(dialogCoordinator, Quote, Units);
                editItemUnitViewModel.OnItemsSavedRequested += OnUnitsSaved;
                windowService.EditItemsWndow(editItemUnitViewModel, "Edit Units");
            }
            else if (itemsName.ToFormat() == "pumps")
            {
                EditItemPumpViewModel editItemPumpViewModel = new EditItemPumpViewModel(dialogCoordinator, Quote, Pumps);
                editItemPumpViewModel.OnItemsSavedRequested += OnPumpsSaved;
                windowService.EditItemsWndow(editItemPumpViewModel, "Edit Pumps");
            }
            else if (itemsName.ToFormat() == "vfds")
            {
                EditItemVfdViewModel editItemVfdViewModel = new EditItemVfdViewModel(dialogCoordinator, Quote, Vfds);
                editItemVfdViewModel.OnItemsSavedRequested += OnVfdsSaved;
                windowService.EditItemsWndow(editItemVfdViewModel, "Edit Vfds");
            }
        }

        private void OnVfdsSaved(IList<IItem> editedItems)
        {
            Vfds = editedItems.ToObservableCollection();
        }

        private void OnUnitsSaved(IList<IItem> editedItems)
        {
            Units = editedItems.ToObservableCollection();
        }

        private void OnPumpsSaved(IList<IItem> editedItems)
        {
            Pumps = editedItems.ToObservableCollection();
        }

        private void OnAirCooledChillersSaved(IList<IItem> editedItems)
        {
            AirCooledChillers = editedItems.ToObservableCollection();
        }

        private void OnDeleteTitle(Title title)
        {
            if (title is null)
                return;

            Titles.Remove(title);
        }

        private void OnDeleteSpec(Spec obj)
        {
            if (obj is null)
                return;

                int titleIndex = Titles.IndexOf(obj.Title);

            Title selectedTitle = Titles[titleIndex];

            selectedTitle.Specs.Remove(obj);
        }

        private void OnAddSpec(Title title)
        {
            title.Specs.Add(new Spec(){ Title = title});
        }

        private void OnAddTitle()
        {
            Titles.Add(new Title());
        }

        private void OnBackFromItemTitles()
        {
            ItemTitlesActive = false;
        }

        private async void OnUpdateItemTitles()
        {
            try
            {
                await messageService.StartMessage("Item Specs", "Saving item specs, please wait...");


                if (!await CanUpdateTitles())
                    return;

                Titles = titleService.UpdateTitlesFromItem(ItemSelected, Titles).ToObservableCollection();

                await messageService.EndMessage("Item Specs", "Item specs has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        private async Task<bool> CanUpdateTitles()
        {
            if (Titles.Any(x => string.IsNullOrWhiteSpace(x.Name)))
            {
                await messageService.ResultMessage("Error", "Some titles name are empty, please review your titles information");
                return false;
            }

            if (Titles.SelectMany(x => x.Specs).Any(x => string.IsNullOrWhiteSpace(x.Name)))
            {
                await messageService.ResultMessage("Error", "Some specs name are empty, please review your specs information");
                return false;
            }

            return true;
        }

        private async void OnShowItemTitles(IItem item)
        {
            if (item is null)
                return;

            try
            {
                await messageService.StartMessage("Item Specs", "Loading item specs, please wait...");

                ItemTitlesActive = true;
                ItemSelected = item;
                Titles = titleService.GetTitlesFromItem(item).ToObservableCollection();

                await messageService.EndMessage("Item Specs", "Item specs has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
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

            if (item is ItemAirCooledChiller)
                selectedItems = AirCooledChillers;
            else if (item is ItemUnit)
                selectedItems = Units;
            else if (item is ItemPump)
                selectedItems = Pumps;
            else if (item is ItemVfd)
                selectedItems = Vfds;
            return selectedItems;
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Loading items, please wait...");


                Project = projectService.GetProjectById(projectId);
                Quote = quoteService.GetQuoteByQuoteId(quoteId);
                mw.Title = $@"XpressPro ({Project.Name} / {Quote.Name})";
                Titles = new ObservableCollection<Title>();
                Items = itemService.GetAllItemByQuoteId(quoteId).ToObservableCollection();
                LoadItemLists();

                await messageService.EndMessage("Quote Items", "Items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnBack()
        {
            OnUpdateItemsRequested();
        }
    }
}
