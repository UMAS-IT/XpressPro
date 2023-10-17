using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
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
using Orion.UI.Misc;
using Orion.UI.Service;
using Orion.UI.ViewModel.ABB.EditQuoteItem;
using Orion.UI.ViewModel.ABB.QuoteItemList;
using Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem;
using Orion.UI.ViewModel.BACClosedCircuits.EditQuoteItem;
using Orion.UI.ViewModel.BACCoolingTowers.EditQuoteItem;
using Orion.UI.ViewModel.GeneralProduct.EditQuoteItem;
using Orion.UI.ViewModel.Groundfos.EditQuoteItem;
using Orion.UI.ViewModel.Mavair.EditQuoteItem;
using Orion.UI.ViewModel.Multiaqua.EditQuoteItem;
using Orion.UI.ViewModel.PACE.EditQuoteItem;
using Orion.UI.ViewModel.Puroflux.EditQuoteItem;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using Orion.UI.ViewModel.Quantech.QuoteItemList;
using Orion.UI.ViewModel.UvResources.EditQuoteItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel
{
    public class ItemViewModel : BindableBase
    {
        private readonly IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private ProjectService projectService;
        private QuoteService quoteService;
        private CompanyService companyService;
        ItemService itemService;
        private MainWindowViewModel mw;
        WindowService windowService;
        private int projectId;
        private int quoteId;

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

        private ObservableCollection<Company> _companies;
        public ObservableCollection<Company> Companies
        {
            get => _companies;
            set => SetProperty(ref _companies, value);
        }

        private ObservableCollection<IItem> _items;
        public ObservableCollection<IItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private ObservableCollection<IListViewModel> _itemListViewModels;
        public ObservableCollection<IListViewModel> ItemListViewModels
        {
            get => _itemListViewModels;
            set => SetProperty(ref _itemListViewModels, value);
        }

        public RelayCommand BackToQuotesCommad { get; set; }
        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<string> EditItemsCommand { get; set; }
        public RelayCommand UpdateQuoteItemsCommand { get; set; }
        public RelayCommand<IListViewModel> MoveToStartCommand { get; set; }
        public RelayCommand<IListViewModel> MoveToUpCommand { get; set; }
        public RelayCommand<IListViewModel> MoveToDownCommand { get; set; }
        public RelayCommand<IListViewModel> MoveToEndCommand { get; set; }

        public Action BackToQuotesRequested = delegate { };

        public ItemViewModel(IDialogCoordinator dialogCoordinator, int projectId, int quoteId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.projectId = projectId;
            this.quoteId = quoteId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand(OnLoadData);
            BackToQuotesCommad = new RelayCommand(OnBackToQuotes);
            EditItemsCommand = new RelayCommand<string>(OnEditItems);
            
            
            MoveToStartCommand = new RelayCommand<IListViewModel>(OnMoveToStart);//
            MoveToUpCommand = new RelayCommand<IListViewModel>(OnMoveToUp);//
            
            
            MoveToDownCommand = new RelayCommand<IListViewModel>(OnMoveToDown);//
            MoveToEndCommand = new RelayCommand<IListViewModel>(OnMoveToEnd);//
            
            
            UpdateQuoteItemsCommand = new RelayCommand(OnUpdateQuoteItems);

            projectService = new ProjectService();
            quoteService = new QuoteService();
            messageService = new MessageService(dialogCoordinator, this);
            windowService = new WindowService();
            itemService = new ItemService();
            companyService = new CompanyService();
        }

        private async void OnUpdateQuoteItems()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Saving quote items, please wait...");

                List<IItem> items = new List<IItem>();

                ItemListViewModels.ToList().ForEach(x => items.AddRange(x.GetItems()));

                if (!await CanUpdateQuoteItems(items))
                    return;

                Items = itemService.UpdateQuoteAllItems(Quote, items).ToObservableCollection();

                Quote.QuoteCompanies = ItemListViewModels.Select(x => x.QuoteCompany).ToList();

                Quote.QuoteCompanies = quoteService.UpdateQuoteCompanies(Quote);

                FillItemListViewModels();

                await messageService.EndMessage("Quote Items", "Quote items has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        private async Task<bool> CanUpdateQuoteItems(List<IItem> items)
        {
            string message = "";

            foreach (IItem item in items)
            {
                if (string.IsNullOrWhiteSpace(item.Tag))
                {
                    message += $"{item.Catalog.Company}, {item.Catalog.Product}, Model: {item.Catalog.Model}\n";
                }
            }

            if (!string.IsNullOrWhiteSpace(message))
            {
                await messageService.ResultMessage("Error", "Some Tags Are Empty \n" + message);
                return false;
            }

            message = itemService.ValidateAllItemsTag(items);

            if (!string.IsNullOrWhiteSpace(message))
            {
                await messageService.ResultMessage("Error", "Some Tags Are Duplicated \n" + message);
                return false;
            }

            return true;
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

            titleFromItemViewModel.BackFromUpdateItemTitlesRequested += OnBackFromUpdatedItemTitles;

            TitlesViewModel = titleFromItemViewModel;
        }

        private async void OnBackFromUpdatedItemTitles(IList<Title> titles, IItem item)
        {
            TitlesActive = false;
            TitlesViewModel = null;
            await Task.Delay(100);

            ItemType itemType = VmHelper.GetItemType(item);
            
            Subfix subfix = VmHelper.GetSubfix(itemType);
            
            Type viewModelType = VmHelper.GetItemListViewModelTypeForSubfix(subfix);

            IListViewModel itemListViewModel = ItemListViewModels.FirstOrDefault(x => viewModelType.IsAssignableFrom(x.GetType()));
            
            ObservableCollection<IItem> currentItems = itemListViewModel.GetSelectedItems(itemType);
            
            IItem currentItem = currentItems.FirstOrDefault(x => x.Id == item.Id);
            
            currentItem.Titles = titles.ToObservableCollection();
            
            currentItem.HasTitles = titles != null && titles.Count > 0;
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
                Companies = companyService.GetCompanies().ToObservableCollection();
                Items = itemService.GetAllItemByQuoteId(quoteId).ToObservableCollection();

                //LoadItemLists();
                ItemListViewModels = new ObservableCollection<IListViewModel>();
                FillItemListViewModels();

                await messageService.EndMessage("Quote Items", "Items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void FillItemListViewModels()
        {
            ItemListViewModels.Clear();

            Items.ToList().ForEach(x => x.HasTitles = x.Titles != null && x.Titles.Count() > 0);

            bool hasIndex = Quote.QuoteCompanies.Any();

            foreach (IItem item in Items)
            {
                ItemType itemType = VmHelper.GetItemType(item);
                Subfix subfix = VmHelper.GetSubfix(itemType);

                Type viewModelType = VmHelper.GetItemListViewModelTypeForSubfix(subfix);

                // Find the list view model from the collection
                IListViewModel itemListViewModel = ItemListViewModels.FirstOrDefault(x => viewModelType.IsAssignableFrom(x.GetType()));

                if (itemListViewModel == null)
                {
                    itemListViewModel = (IListViewModel)Activator.CreateInstance(viewModelType, dialogCoordinator, Items, Quote, Companies);
                    CreateAddItemListViewModelAndQuoteCompany(subfix, itemListViewModel, hasIndex);
                }
            }

            OrderItemListViewModels();
        }

        private void CreateAddItemListViewModelAndQuoteCompany(Subfix subfix, IListViewModel itemListViewModel, bool hasIndex = false)
        {
            ItemListViewModels.Add(itemListViewModel);

            if (!hasIndex)
            {
                int currentIndex = ItemListViewModels.ToList().IndexOf(itemListViewModel);

                QuoteCompanies quoteCompany = new QuoteCompanies()
                {
                    Company = Companies.FirstOrDefault(x => x.Subfix == subfix.ToString()),
                    DesignIndex = currentIndex
                };

                Quote.QuoteCompanies.Add(quoteCompany);
                itemListViewModel.QuoteCompany = quoteCompany;
            }
            else
            {
                QuoteCompanies quoteCompany = Quote.QuoteCompanies.FirstOrDefault(x => x.Company.Subfix == subfix.ToString());
                itemListViewModel.QuoteCompany = quoteCompany;
            }
            itemListViewModel.ShowTitlesRequested += OnShowItemTitles;
            itemListViewModel.DeleteItemListViewRequested += OnDeleteItemListViewModel;
        }

        private void OnDeleteItemListViewModel(IListViewModel itemListViewModel)
        {
            ItemListViewModels.Remove(itemListViewModel);

            ItemListViewModels.ToList().ForEach(x => x.QuoteCompany.DesignIndex = ItemListViewModels.IndexOf(x));
        }

        private void OrderItemListViewModels()
        {
            ItemListViewModels = ItemListViewModels.OrderBy(x => x.QuoteCompany.DesignIndex).ToObservableCollection();
        }

        private void OnBackToQuotes()
        {
            BackToQuotesRequested();
        }

        private void OnMoveToEnd(IListViewModel itemListViewModel)
        {
            if (itemListViewModel is null)
                return;

            int viewModelIndex = itemListViewModel.QuoteCompany.DesignIndex;
            int viewModelLastIndex = ItemListViewModels.IndexOf(ItemListViewModels.Last());

            ItemListViewModels.Move(viewModelIndex, viewModelLastIndex);

            ItemListViewModels.ToList().ForEach(x => x.QuoteCompany.DesignIndex = ItemListViewModels.IndexOf(x));
        }

        private void OnMoveToDown(IListViewModel itemListViewModel)
        {
            if (itemListViewModel is null)
                return;

            int viewModelIndex = itemListViewModel.QuoteCompany.DesignIndex;
            int viewModelLastIndex = ItemListViewModels.IndexOf(ItemListViewModels.Last());

            if (viewModelIndex == viewModelLastIndex)
                return;

            ItemListViewModels.Move(viewModelIndex, viewModelIndex + 1);

            ItemListViewModels.ToList().ForEach(x => x.QuoteCompany.DesignIndex = ItemListViewModels.IndexOf(x));
        }

        private void OnMoveToUp(IListViewModel itemListViewModel)
        {
            if (itemListViewModel is null)
                return;

            int viewModelIndex = itemListViewModel.QuoteCompany.DesignIndex;

            if (viewModelIndex == 0)
                return;

            ItemListViewModels.Move(viewModelIndex, viewModelIndex - 1);

            ItemListViewModels.ToList().ForEach(x => x.QuoteCompany.DesignIndex = ItemListViewModels.IndexOf(x));
        }

        private void OnMoveToStart(IListViewModel itemListViewModel)
        {
            if (itemListViewModel is null)
                return;

            int viewModelIndex = itemListViewModel.QuoteCompany.DesignIndex;

            ItemListViewModels.Move(viewModelIndex, 0);

            ItemListViewModels.ToList().ForEach(x=> x.QuoteCompany.DesignIndex = ItemListViewModels.IndexOf(x));
        }

        private void OnEditItems(string itemsName)
        {
            itemsName = itemsName.ToFormat();
            Subfix subfix = VmHelper.GetSubfix(itemsName);
            ItemType itemType = VmHelper.GetItemType(itemsName);

            Type listViewModelType = VmHelper.GetItemListViewModelTypeForSubfix(subfix);

            IListViewModel itemListViewModel = ItemListViewModels.FirstOrDefault(x => listViewModelType.IsAssignableFrom(x.GetType()));

            ObservableCollection<IItem> currentItems = null;

            if (itemListViewModel != null)
                currentItems = itemListViewModel.GetSelectedItems(itemType);
            else
                currentItems= new ObservableCollection<IItem>();

            ItemType myItemType = VmHelper.GetItemType(itemsName);

            Type viewModelType = VmHelper.GetEditViewModelTypeForItemType(myItemType);

            IEditItemViewModel viewModel = (IEditItemViewModel)Activator.CreateInstance(viewModelType, dialogCoordinator, Quote, currentItems, myItemType);

            Product product = companyService.GetProduct(Companies, itemsName);
            viewModel.OnItemsSavedRequested += OnItemsSaved;
            windowService.EditItemsWndow(viewModel, $"Edit {product.Name}");
        }

        private void OnItemsSaved(IList<IItem> items, ItemType itemType)
        {
            // Set HasTitles property based on item Titles
            items.ToList().ForEach(x => x.HasTitles = x.Titles != null && x.Titles.Count() > 0);

            // Get the subfix based on the itemType
            Subfix subfix = VmHelper.GetSubfix(itemType);

            // Get the ViewModel type based on the subfix
            Type viewModelType = VmHelper.GetItemListViewModelTypeForSubfix(subfix);

            // Find the list view model from the collection
            IListViewModel itemListViewModel = ItemListViewModels.FirstOrDefault(x => viewModelType.IsAssignableFrom(x.GetType()));

            if (itemListViewModel != null)
            {
                // Call OnItemsSaved on the existing list view model
                itemListViewModel.OnItemsSaved(items, itemType);
            }
            else
            {
                // Create a new list view model and quote company if not found
                itemListViewModel = (IListViewModel)Activator.CreateInstance(viewModelType,dialogCoordinator, items, Quote, Companies);
                CreateAddItemListViewModelAndQuoteCompany(subfix, itemListViewModel);
            }
        }
    }
}
