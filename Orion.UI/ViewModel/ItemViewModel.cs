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
using Orion.UI.Command;
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
        public RelayCommand<IItem> TotalPriceChangedCommand { get; set; }

        
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
            TotalPriceChangedCommand = new RelayCommand<IItem>(OnTotalPriceChanged);

            projectService = new ProjectService();
            quoteService = new QuoteService();
            messageService = new MessageService(dialogCoordinator, this);
            windowService = new WindowService();
            itemService = new ItemService();
            companyService = new CompanyService();
        }

        // REVISAR //
        private async void OnUpdateQuoteItems()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Saving quote items, please wait...");

                List<IItem> items = new List<IItem>();

                //// last set of DesignIndex
                ////ItemA1s.ToList().ForEach(x => x.DesignIndex = ItemA1s.IndexOf(x));
                ////ItemA2s.ToList().ForEach(x => x.DesignIndex = ItemA2s.IndexOf(x));
                ////ItemA3s.ToList().ForEach(x => x.DesignIndex = ItemA3s.IndexOf(x));
                ////ItemA4s.ToList().ForEach(x => x.DesignIndex = ItemA4s.IndexOf(x));

                //// last set of DesignIndex
                ////ItemB1s.ToList().ForEach(x => x.DesignIndex = ItemB1s.IndexOf(x));
                ////ItemB2s.ToList().ForEach(x => x.DesignIndex = ItemB2s.IndexOf(x));
                ////ItemB3s.ToList().ForEach(x => x.DesignIndex = ItemB3s.IndexOf(x));
                ////ItemB4s.ToList().ForEach(x => x.DesignIndex = ItemB4s.IndexOf(x));
                ////ItemB5s.ToList().ForEach(x => x.DesignIndex = ItemB5s.IndexOf(x));

                //// last set of DesignIndex
                //ItemC1s.ToList().ForEach(x => x.DesignIndex = ItemC1s.IndexOf(x));
                //ItemC2s.ToList().ForEach(x => x.DesignIndex = ItemC2s.IndexOf(x));
                //ItemC3s.ToList().ForEach(x => x.DesignIndex = ItemC3s.IndexOf(x));
                //ItemC4s.ToList().ForEach(x => x.DesignIndex = ItemC4s.IndexOf(x));
                //ItemC5s.ToList().ForEach(x => x.DesignIndex = ItemC5s.IndexOf(x));
                //ItemC6s.ToList().ForEach(x => x.DesignIndex = ItemC6s.IndexOf(x));
                //ItemC7s.ToList().ForEach(x => x.DesignIndex = ItemC7s.IndexOf(x));

                //// last set of DesignIndex
                //ItemD1s.ToList().ForEach(x => x.DesignIndex = ItemD1s.IndexOf(x));
                //ItemD2s.ToList().ForEach(x => x.DesignIndex = ItemD2s.IndexOf(x));

                //// last set of DesignIndex
                //ItemE1s.ToList().ForEach(x => x.DesignIndex = ItemE1s.IndexOf(x));
                //ItemE2s.ToList().ForEach(x => x.DesignIndex = ItemE2s.IndexOf(x));
                //ItemE3s.ToList().ForEach(x => x.DesignIndex = ItemE3s.IndexOf(x));
                //ItemE4s.ToList().ForEach(x => x.DesignIndex = ItemE4s.IndexOf(x));
                //ItemE5s.ToList().ForEach(x => x.DesignIndex = ItemE5s.IndexOf(x));
                //ItemE6s.ToList().ForEach(x => x.DesignIndex = ItemE6s.IndexOf(x));
                //ItemE7s.ToList().ForEach(x => x.DesignIndex = ItemE7s.IndexOf(x));
                
                //// last set of DesignIndex
                //ItemF1s.ToList().ForEach(x => x.DesignIndex = ItemF1s.IndexOf(x));

                //// last set of DesignIndex
                //ItemG1s.ToList().ForEach(x => x.DesignIndex = ItemG1s.IndexOf(x));
                //ItemG2s.ToList().ForEach(x => x.DesignIndex = ItemG2s.IndexOf(x));
                //ItemG3s.ToList().ForEach(x => x.DesignIndex = ItemG3s.IndexOf(x));
                //ItemG4s.ToList().ForEach(x => x.DesignIndex = ItemG4s.IndexOf(x));
                //ItemG5s.ToList().ForEach(x => x.DesignIndex = ItemG5s.IndexOf(x));
                //ItemG6s.ToList().ForEach(x => x.DesignIndex = ItemG6s.IndexOf(x));

                //// last set of DesignIndex
                //ItemH1s.ToList().ForEach(x => x.DesignIndex = ItemH1s.IndexOf(x));
                //ItemH2s.ToList().ForEach(x => x.DesignIndex = ItemH2s.IndexOf(x));
                //ItemH3s.ToList().ForEach(x => x.DesignIndex = ItemH3s.IndexOf(x));
                //ItemH4s.ToList().ForEach(x => x.DesignIndex = ItemH4s.IndexOf(x));
                //ItemH5s.ToList().ForEach(x => x.DesignIndex = ItemH5s.IndexOf(x));

                //// last set of DesignIndex
                //ItemI1s.ToList().ForEach(x => x.DesignIndex = ItemI1s.IndexOf(x));
                //ItemI2s.ToList().ForEach(x => x.DesignIndex = ItemI2s.IndexOf(x));

                //// last set of DesignIndex
                //ItemJ1s.ToList().ForEach(x => x.DesignIndex = ItemJ1s.IndexOf(x));

                //// last set of DesignIndex
                //ItemK1s.ToList().ForEach(x => x.DesignIndex = ItemK1s.IndexOf(x));
                //ItemK2s.ToList().ForEach(x => x.DesignIndex = ItemK2s.IndexOf(x));
                //ItemK3s.ToList().ForEach(x => x.DesignIndex = ItemK3s.IndexOf(x));

                //ItemL1s.ToList().ForEach(x => x.DesignIndex = ItemL1s.IndexOf(x));


                //add all items in one list
                //items.AddRange(ItemA1s);
                //items.AddRange(ItemA2s);
                //items.AddRange(ItemA3s);
                //items.AddRange(ItemA4s);

                //items.AddRange(ItemB1s);
                //items.AddRange(ItemB2s);
                //items.AddRange(ItemB3s);
                //items.AddRange(ItemB4s);
                //items.AddRange(ItemB5s);

                //items.AddRange(ItemC1s);
                //items.AddRange(ItemC2s);
                //items.AddRange(ItemC3s);
                //items.AddRange(ItemC4s);
                //items.AddRange(ItemC5s);
                //items.AddRange(ItemC6s);
                //items.AddRange(ItemC7s);

                //items.AddRange(ItemD1s);
                //items.AddRange(ItemD2s);

                //items.AddRange(ItemE1s);
                //items.AddRange(ItemE2s);
                //items.AddRange(ItemE3s);
                //items.AddRange(ItemE4s);
                //items.AddRange(ItemE5s);
                //items.AddRange(ItemE6s);
                //items.AddRange(ItemE7s);

                //items.AddRange(ItemF1s);

                //items.AddRange(ItemG1s);
                //items.AddRange(ItemG2s);
                //items.AddRange(ItemG3s);
                //items.AddRange(ItemG4s);
                //items.AddRange(ItemG5s);
                //items.AddRange(ItemG6s);

                //items.AddRange(ItemH1s);
                //items.AddRange(ItemH2s);
                //items.AddRange(ItemH3s);
                //items.AddRange(ItemH4s);
                //items.AddRange(ItemH5s);

                //items.AddRange(ItemI1s);
                //items.AddRange(ItemI2s);

                //items.AddRange(ItemJ1s);

                //items.AddRange(ItemK1s);
                //items.AddRange(ItemK2s);
                //items.AddRange(ItemK3s);

                //items.AddRange(ItemL1s);


                if (!await CanUpdateQuoteItems(items))
                    return;

                Items = itemService.UpdateQuoteAllItems(Quote, items).ToObservableCollection();

                //LoadItemLists(); // aqui si hay que hacer algo

                await messageService.EndMessage("Quote Items", "Quote items has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        // REVISAR //
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

        // REVISAR //
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

        // REVISAR //
        private async void OnBackFromUpdatedItemTitles(IList<Title> titles, IItem item)
        {
            TitlesActive = false;
            TitlesViewModel = null;
            await Task.Delay(100);

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            IItem currentItem = currentItems.FirstOrDefault(x => x.Id == item.Id);

            currentItem.Titles = titles.ToObservableCollection();

            currentItem.HasTitles = titles != null && titles.Count > 0;

            //OnPropertyChange(nameof(currentItem.HasTitles));
        }

        // REVISAR //
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
            Items.ToList().ForEach(x => x.HasTitles = x.Titles != null && x.Titles.Count() > 0);

            bool hasIndex = Quote.QuoteCompanies.Any();

            CreateAndAddItemListViewModelIfRequired<ItemA1, AItemListViewModel>(Subfix.A, hasIndex);
            CreateAndAddItemListViewModelIfRequired<ItemA2, AItemListViewModel>(Subfix.A, hasIndex);
            CreateAndAddItemListViewModelIfRequired<ItemA3, AItemListViewModel>(Subfix.A, hasIndex);
            CreateAndAddItemListViewModelIfRequired<ItemA4, AItemListViewModel>(Subfix.A, hasIndex);

            CreateAndAddItemListViewModelIfRequired<ItemB1, BItemListViewModel>(Subfix.B, hasIndex);
            CreateAndAddItemListViewModelIfRequired<ItemB2, BItemListViewModel>(Subfix.B, hasIndex);
            CreateAndAddItemListViewModelIfRequired<ItemB3, BItemListViewModel>(Subfix.B, hasIndex);
            CreateAndAddItemListViewModelIfRequired<ItemB4, BItemListViewModel>(Subfix.B, hasIndex);
            CreateAndAddItemListViewModelIfRequired<ItemB5, BItemListViewModel>(Subfix.B, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemC1, CItemListViewModel>(Subfix.C, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemC2, CItemListViewModel>(Subfix.C, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemC3, CItemListViewModel>(Subfix.C, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemC4, CItemListViewModel>(Subfix.C, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemC5, CItemListViewModel>(Subfix.C, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemC6, CItemListViewModel>(Subfix.C, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemC7, CItemListViewModel>(Subfix.C, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemD1, DItemListViewModel>(Subfix.D, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemD2, DItemListViewModel>(Subfix.D, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemE1, EItemListViewModel>(Subfix.E, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemE2, EItemListViewModel>(Subfix.E, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemE3, EItemListViewModel>(Subfix.E, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemE4, EItemListViewModel>(Subfix.E, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemE5, EItemListViewModel>(Subfix.E, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemE6, EItemListViewModel>(Subfix.E, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemE7, EItemListViewModel>(Subfix.E, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemF1, FItemListViewModel>(Subfix.F, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemG1, GItemListViewModel>(Subfix.G, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemG2, GItemListViewModel>(Subfix.G, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemG3, GItemListViewModel>(Subfix.G, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemG4, GItemListViewModel>(Subfix.G, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemG5, GItemListViewModel>(Subfix.G, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemG6, GItemListViewModel>(Subfix.G, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemH1, HItemListViewModel>(Subfix.H, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemH2, HItemListViewModel>(Subfix.H, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemH3, HItemListViewModel>(Subfix.H, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemH4, HItemListViewModel>(Subfix.H, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemH5, HItemListViewModel>(Subfix.H, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemI1, IItemListViewModel>(Subfix.I, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemI2, IItemListViewModel>(Subfix.I, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemJ1, JItemListViewModel>(Subfix.J, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemK1, KItemListViewModel>(Subfix.K, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemK2, KItemListViewModel>(Subfix.K, hasIndex);
            //CreateAndAddItemListViewModelIfRequired<ItemK3, KItemListViewModel>(Subfix.K, hasIndex);

            //CreateAndAddItemListViewModelIfRequired<ItemL1, LItemListViewModel>(Subfix.L, hasIndex);

            OrderItemListViewModels();
        }

        private void CreateAndAddItemListViewModelIfRequired<TItem, TItemListViewModel>(Subfix subfix, bool hasIndex) where TItemListViewModel : ItemListViewModel where TItem : IItem
        {
            var tempItemListViewModel = ItemListViewModels.OfType<TItemListViewModel>().FirstOrDefault();
            if (Items.Any(x => x is TItem) && tempItemListViewModel == null)
            {
                var itemListViewModel = Activator.CreateInstance(typeof(TItemListViewModel), dialogCoordinator, Items, Quote, Companies) as TItemListViewModel;
                CreateAddItemListViewModelAndQuoteCompany(subfix, itemListViewModel, hasIndex);
            }
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
        }

        private void OrderItemListViewModels()
        {
            ItemListViewModels = ItemListViewModels.OrderBy(x => x.QuoteCompany.DesignIndex).ToObservableCollection();
        }

        // REVISAR //
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

        // REVISAR //
        private ObservableCollection<IItem> GetSelectedItems(IItem item)
        {
            ObservableCollection<IItem> selectedItems = null;

            //if (item is ItemA1)
            //    selectedItems = ItemA1s;
            //else if (item is ItemA2)
            //    selectedItems = ItemA2s;
            //else if (item is ItemA3)
            //    selectedItems = ItemA3s;
            //else if (item is ItemA4)
            //    selectedItems = ItemA4s;

            //if (item is ItemB1)
            //    selectedItems = ItemB1s;
            //else if (item is ItemB2)
            //    selectedItems = ItemB2s;
            //else if (item is ItemB3)
            //    selectedItems = ItemB3s;
            //else if (item is ItemB4)
            //    selectedItems = ItemB4s;
            //else if (item is ItemB5)
            //    selectedItems = ItemB5s;

            //if (item is ItemC1)
            //    selectedItems = ItemC1s;
            //else if (item is ItemC2)
            //    selectedItems = ItemC2s;
            //else if (item is ItemC3)
            //    selectedItems = ItemC3s;
            //else if (item is ItemC4)
            //    selectedItems = ItemC4s;
            //else if (item is ItemC5)
            //    selectedItems = ItemC5s;
            //else if (item is ItemC6)
            //    selectedItems = ItemC6s;
            //else if (item is ItemC7)
            //    selectedItems = ItemC7s;

            //else if (item is ItemD1)
            //    selectedItems = ItemD1s;
            //else if (item is ItemD2)
            //    selectedItems = ItemC2s;

            //else if (item is ItemE1)
            //    selectedItems = ItemE1s;
            //else if (item is ItemE2)
            //    selectedItems = ItemE2s;
            //else if (item is ItemE3)
            //    selectedItems = ItemE3s;
            //else if (item is ItemE4)
            //    selectedItems = ItemE4s;
            //else if (item is ItemE5)
            //    selectedItems = ItemE5s;
            //else if (item is ItemE6)
            //    selectedItems = ItemE6s;
            //else if (item is ItemE7)
            //    selectedItems = ItemE7s;

            //else if (item is ItemF1)
            //    selectedItems = ItemF1s;

            //else if (item is ItemG1)
            //    selectedItems = ItemG1s;
            //else if (item is ItemG2)
            //    selectedItems = ItemG2s;
            //else if (item is ItemG3)
            //    selectedItems = ItemG3s;
            //else if (item is ItemG4)
            //    selectedItems = ItemG4s;
            //else if (item is ItemG5)
            //    selectedItems = ItemG5s;
            //else if (item is ItemG6)
            //    selectedItems = ItemG6s;

            //else if (item is ItemH1)
            //    selectedItems = ItemH1s;
            //else if (item is ItemH2)
            //    selectedItems = ItemH2s;
            //else if (item is ItemH3)
            //    selectedItems = ItemH3s;
            //else if (item is ItemH4)
            //    selectedItems = ItemH4s;
            //else if (item is ItemH5)
            //    selectedItems = ItemH5s;

            //else if (item is ItemI1)
            //    selectedItems = ItemI1s;
            //else if (item is ItemI2)
            //    selectedItems = ItemI2s;

            //else if (item is ItemJ1)
            //    selectedItems = ItemJ1s;

            //else if (item is ItemK1)
            //    selectedItems = ItemK1s;
            //else if (item is ItemK2)
            //    selectedItems = ItemK2s;
            //else if (item is ItemK3)
            //    selectedItems = ItemK3s;

            //else if (item is ItemL1)
            //    selectedItems = ItemL1s;

            return selectedItems;
        }

        // REVISAR //
        private void OnTotalPriceChanged(IItem item)
        {
            //if (item is ItemA1)
            //    OnPropertyChange(nameof(ItemA1s));
            //else if (item is ItemA2)
            //    OnPropertyChange(nameof(ItemA2s));
            //else if (item is ItemA3)
            //    OnPropertyChange(nameof(ItemA3s));
            //else if (item is ItemA4)
            //    OnPropertyChange(nameof(ItemA4s));

            //if (item is ItemB1)
            //    OnPropertyChange(nameof(ItemB1s));
            //else if (item is ItemB2)
            //    OnPropertyChange(nameof(ItemB2s));
            //else if (item is ItemB3)
            //    OnPropertyChange(nameof(ItemB3s));
            //else if (item is ItemB4)
            //    OnPropertyChange(nameof(ItemB4s));
            //else if (item is ItemB5)
            //    OnPropertyChange(nameof(ItemB5s));

            // if (item is ItemC1)
            //    OnPropertyChange(nameof(ItemC1s));
            //else if (item is ItemC2)
            //    OnPropertyChange(nameof(ItemC2s));
            //else if (item is ItemC3)
            //    OnPropertyChange(nameof(ItemC3s));
            //else if (item is ItemC4)
            //    OnPropertyChange(nameof(ItemC4s));
            //else if (item is ItemC5)
            //    OnPropertyChange(nameof(ItemC5s));
            //else if (item is ItemC6)
            //    OnPropertyChange(nameof(ItemC6s));
            //else if (item is ItemC7)
            //    OnPropertyChange(nameof(ItemC7s));

            //else if (item is ItemD1)
            //    OnPropertyChange(nameof(ItemD1s));
            //else if (item is ItemD2)
            //    OnPropertyChange(nameof(ItemC2s));

            //else if (item is ItemE1)
            //    OnPropertyChange(nameof(ItemE1s));
            //else if (item is ItemE2)
            //    OnPropertyChange(nameof(ItemE2s));
            //else if (item is ItemE3)
            //    OnPropertyChange(nameof(ItemE3s));
            //else if (item is ItemE4)
            //    OnPropertyChange(nameof(ItemE4s));
            //else if (item is ItemE5)
            //    OnPropertyChange(nameof(ItemE5s));
            //else if (item is ItemE6)
            //    OnPropertyChange(nameof(ItemE6s));
            //else if (item is ItemE7)
            //    OnPropertyChange(nameof(ItemE7s));

            //else if (item is ItemF1)
            //    OnPropertyChange(nameof(ItemF1s));

            //else if (item is ItemG1)
            //    OnPropertyChange(nameof(ItemG1s));
            //else if (item is ItemG2)
            //    OnPropertyChange(nameof(ItemG2s));
            //else if (item is ItemG3)
            //    OnPropertyChange(nameof(ItemG3s));
            //else if (item is ItemG4)
            //    OnPropertyChange(nameof(ItemG4s));
            //else if (item is ItemG5)
            //    OnPropertyChange(nameof(ItemG5s));
            //else if (item is ItemG6)
            //    OnPropertyChange(nameof(ItemG6s));

            //else if (item is ItemH1)
            //    OnPropertyChange(nameof(ItemH1s));
            //else if (item is ItemH2)
            //    OnPropertyChange(nameof(ItemH2s));
            //else if (item is ItemH3)
            //    OnPropertyChange(nameof(ItemH3s));
            //else if (item is ItemH4)
            //    OnPropertyChange(nameof(ItemH4s));
            //else if (item is ItemH5)
            //    OnPropertyChange(nameof(ItemH5s));

            //else if (item is ItemI1)
            //    OnPropertyChange(nameof(ItemI1s));
            //else if (item is ItemI2)
            //    OnPropertyChange(nameof(ItemI2s));

            //else if (item is ItemJ1)
            //    OnPropertyChange(nameof(ItemJ1s));

            //else if (item is ItemK1)
            //    OnPropertyChange(nameof(ItemK1s));
            //else if (item is ItemK2)
            //    OnPropertyChange(nameof(ItemK2s));
            //else if (item is ItemK3)
            //    OnPropertyChange(nameof(ItemK3s));
            //else if (item is ItemL1)
            //    OnPropertyChange(nameof(ItemL1s));
        }

        #region On Edit Items
        private void OnEditItems(string itemsName)
        {
            IEditItemViewModel viewModel = null;
            itemsName = itemsName.ToFormat();
            Subfix subfix = GetSubfix(itemsName);
            ItemType currentItemType = GetItemType(itemsName);

            Func<ItemType, ObservableCollection<IItem>> getItems = (itemType) =>
            {
                switch (subfix)
                {
                    case Subfix.A:
                        if (ItemListViewModels.Any(x => x is AItemListViewModel))
                        {
                            AItemListViewModel itemListViewModel = (AItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is AItemListViewModel);
                            return itemType == ItemType.ItemA1 ? itemListViewModel.ItemA1s.ToObservableCollection() :
                                   itemType == ItemType.ItemA2 ? itemListViewModel.ItemA2s.ToObservableCollection() :
                                   itemType == ItemType.ItemA3 ? itemListViewModel.ItemA3s.ToObservableCollection() :
                                   itemType == ItemType.ItemA4 ? itemListViewModel.ItemA4s.ToObservableCollection() :
                                   new ObservableCollection<IItem>();
                        }
                        break;
                    case Subfix.B:
                        if (ItemListViewModels.Any(x => x is BItemListViewModel))
                        {
                            BItemListViewModel itemListViewModel = (BItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is BItemListViewModel);
                            return itemType == ItemType.ItemB1 ? itemListViewModel.ItemB1s.ToObservableCollection() :
                                   itemType == ItemType.ItemB2 ? itemListViewModel.ItemB2s.ToObservableCollection() :
                                   itemType == ItemType.ItemB3 ? itemListViewModel.ItemB3s.ToObservableCollection() :
                                   itemType == ItemType.ItemB4 ? itemListViewModel.ItemB4s.ToObservableCollection() :
                                   itemType == ItemType.ItemB5 ? itemListViewModel.ItemB5s.ToObservableCollection() :
                                   new ObservableCollection<IItem>();
                        }
                        break;
                    case Subfix.C:
                        //    if (ItemListViewModels.Any(x => x is CItemListViewModel))
                        //    {
                        //        CItemListViewModel itemListViewModel = (CItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is CItemListViewModel);
                        //        return itemType == ItemType.ItemC1 ? itemListViewModel.ItemC1s.ToObservableCollection() :
                        //               itemType == ItemType.ItemC2 ? itemListViewModel.ItemC2s.ToObservableCollection() :
                        //               itemType == ItemType.ItemC3 ? itemListViewModel.ItemC3s.ToObservableCollection() :
                        //               itemType == ItemType.ItemC4 ? itemListViewModel.ItemC4s.ToObservableCollection() :
                        //               itemType == ItemType.ItemC5 ? itemListViewModel.ItemC5s.ToObservableCollection() :
                        //               itemType == ItemType.ItemC6 ? itemListViewModel.ItemC6s.ToObservableCollection() :
                        //               itemType == ItemType.ItemC7 ? itemListViewModel.ItemC7s.ToObservableCollection() :
                        //               new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.D:
                        //    if (ItemListViewModels.Any(x => x is DItemListViewModel))
                        //    {
                        //        DItemListViewModel itemListViewModel = (DItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is DItemListViewModel);
                        //        return itemType == ItemType.ItemD1 ? itemListViewModel.ItemD1s.ToObservableCollection() :
                        //               itemType == ItemType.ItemD2 ? itemListViewModel.ItemD2s.ToObservableCollection() :
                        //               new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.E:
                        //    if (ItemListViewModels.Any(x => x is EItemListViewModel))
                        //    {
                        //        EItemListViewModel itemListViewModel = (EItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is EItemListViewModel);
                        //        return itemType == ItemType.ItemE1 ? itemListViewModel.ItemE1s.ToObservableCollection() :
                        //               itemType == ItemType.ItemE2 ? itemListViewModel.ItemE2s.ToObservableCollection() :
                        //               itemType == ItemType.ItemE3 ? itemListViewModel.ItemE3s.ToObservableCollection() :
                        //               itemType == ItemType.ItemE4 ? itemListViewModel.ItemE4s.ToObservableCollection() :
                        //               itemType == ItemType.ItemE5 ? itemListViewModel.ItemE5s.ToObservableCollection() :
                        //               itemType == ItemType.ItemE6 ? itemListViewModel.ItemE6s.ToObservableCollection() :
                        //               itemType == ItemType.ItemE7 ? itemListViewModel.ItemE7s.ToObservableCollection() :
                        //               new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.F:
                        //    if (ItemListViewModels.Any(x => x is FItemListViewModel))
                        //    {
                        //        FItemListViewModel itemListViewModel = (FItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is FItemListViewModel);
                        //        return itemType == ItemType.ItemF1 ? itemListViewModel.ItemF1s.ToObservableCollection() : new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.G:
                        //    if (ItemListViewModels.Any(x => x is GItemListViewModel))
                        //    {
                        //        GItemListViewModel itemListViewModel = (GItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is GItemListViewModel);
                        //        return itemType == ItemType.ItemG1 ? itemListViewModel.ItemG1s.ToObservableCollection() :
                        //               itemType == ItemType.ItemG2 ? itemListViewModel.ItemG2s.ToObservableCollection() :
                        //               itemType == ItemType.ItemG3 ? itemListViewModel.ItemG3s.ToObservableCollection() :
                        //               itemType == ItemType.ItemG4 ? itemListViewModel.ItemG4s.ToObservableCollection() :
                        //               itemType == ItemType.ItemG5 ? itemListViewModel.ItemG5s.ToObservableCollection() :
                        //               itemType == ItemType.ItemG6 ? itemListViewModel.ItemG6s.ToObservableCollection() :
                        //               new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.H:
                        //    if (ItemListViewModels.Any(x => x is HItemListViewModel))
                        //    {
                        //        HItemListViewModel itemListViewModel = (HItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is HItemListViewModel);
                        //        return itemType == ItemType.ItemH1 ? itemListViewModel.ItemH1s.ToObservableCollection() :
                        //               itemType == ItemType.ItemH2 ? itemListViewModel.ItemH2s.ToObservableCollection() :
                        //               itemType == ItemType.ItemH3 ? itemListViewModel.ItemH3s.ToObservableCollection() :
                        //               itemType == ItemType.ItemH4 ? itemListViewModel.ItemH4s.ToObservableCollection() :
                        //               itemType == ItemType.ItemH5 ? itemListViewModel.ItemH5s.ToObservableCollection() :
                        //               new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.I:
                        //    if (ItemListViewModels.Any(x => x is IItemListViewModel))
                        //    {
                        //        IItemListViewModel itemListViewModel = (IItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is IItemListViewModel);
                        //        return itemType == ItemType.ItemI1 ? itemListViewModel.ItemI1s.ToObservableCollection() :
                        //               itemType == ItemType.ItemI2 ? itemListViewModel.ItemI2s.ToObservableCollection() :
                        //               new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.J:
                        //    if (ItemListViewModels.Any(x => x is JItemListViewModel))
                        //    {
                        //        JItemListViewModel itemListViewModel = (JItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is JItemListViewModel);
                        //        return itemType == ItemType.ItemJ1 ? itemListViewModel.ItemJ1s.ToObservableCollection() : new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.K:
                        //    if (ItemListViewModels.Any(x => x is KItemListViewModel))
                        //    {
                        //        KItemListViewModel itemListViewModel = (KItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is KItemListViewModel);
                        //        return itemType == ItemType.ItemK1 ? itemListViewModel.ItemK1s.ToObservableCollection() :
                        //               itemType == ItemType.ItemK2 ? itemListViewModel.ItemK2s.ToObservableCollection() :
                        //               itemType == ItemType.ItemK3 ? itemListViewModel.ItemK3s.ToObservableCollection() :
                        //               new ObservableCollection<IItem>();
                        //    }
                        break;
                    case Subfix.L:
                        //    if (ItemListViewModels.Any(x => x is LItemListViewModel))
                        //    {
                        //        LItemListViewModel itemListViewModel = (LItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is LItemListViewModel);
                        //        return itemType == ItemType.ItemL1 ? itemListViewModel.ItemL1s.ToObservableCollection() : new ObservableCollection<IItem>();
                        //    }
                        break;
                    default:
                        break;
                }
                return new ObservableCollection<IItem>();
            };

            switch (itemsName.ToFormat())
            {
                case "a1":
                    viewModel = new EditA1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemA1), ItemType.ItemA1);
                    break;
                case "a2":
                    viewModel = new EditA2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemA2), ItemType.ItemA2);
                    break;
                case "a3":
                    viewModel = new EditA3ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemA3), ItemType.ItemA3);
                    break;
                case "a4":
                    viewModel = new EditA4ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemA4), ItemType.ItemA4);
                    break;
                case "b1":
                    viewModel = new EditB1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemB1), ItemType.ItemB1);
                    break;
                case "b2":
                    viewModel = new EditB2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemB2), ItemType.ItemB2);
                    break;
                case "b3":
                    viewModel = new EditB3ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemB3), ItemType.ItemB3);
                    break;
                case "b4":
                    viewModel = new EditB4ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemB4), ItemType.ItemB4);
                    break;
                case "b5":
                    viewModel = new EditB5ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemB5), ItemType.ItemB5);
                    break;
                case "c1":
                    viewModel = new EditC1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemC1), ItemType.ItemC1);
                    break;
                case "c2":
                    viewModel = new EditC2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemC2), ItemType.ItemC2);
                    break;
                case "c3":
                    viewModel = new EditC3ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemC3), ItemType.ItemC3);
                    break;
                case "c4":
                    viewModel = new EditC4ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemC4), ItemType.ItemC4);
                    break;
                case "c5":
                    viewModel = new EditC5ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemC5), ItemType.ItemC5);
                    break;
                case "c6":
                    viewModel = new EditC6ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemC6), ItemType.ItemC6);
                    break;
                case "c7":
                    viewModel = new EditC7ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemC7), ItemType.ItemC7);
                    break;
                case "d1":
                    viewModel = new EditD1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemD1), ItemType.ItemD1);
                    break;
                case "d2":
                    viewModel = new EditD2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemD2), ItemType.ItemD2);
                    break;
                case "e1":
                    viewModel = new EditE1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemE1), ItemType.ItemE1);
                    break;
                case "e2":
                    viewModel = new EditE2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemE2), ItemType.ItemE2);
                    break;
                case "e3":
                    viewModel = new EditE3ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemE3), ItemType.ItemE3);
                    break;
                case "e4":
                    viewModel = new EditE4ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemE4), ItemType.ItemE4);
                    break;
                case "e5":
                    viewModel = new EditE5ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemE5), ItemType.ItemE5);
                    break;
                case "e6":
                    viewModel = new EditE6ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemE6), ItemType.ItemE6);
                    break;
                case "e7":
                    viewModel = new EditE7ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemE7), ItemType.ItemE7);
                    break;
                case "f1":
                    viewModel = new EditF1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemF1), ItemType.ItemF1);
                    break;
                case "g1":
                    viewModel = new EditG1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemG1), ItemType.ItemG1);
                    break;
                case "g2":
                    viewModel = new EditG2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemG2), ItemType.ItemG2);
                    break;
                case "g3":
                    viewModel = new EditG3ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemG3), ItemType.ItemG3);
                    break;
                case "g4":
                    viewModel = new EditG4ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemG4), ItemType.ItemG4);
                    break;
                case "g5":
                    viewModel = new EditG5ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemG5), ItemType.ItemG5);
                    break;
                case "g6":
                    viewModel = new EditG6ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemG6), ItemType.ItemG6);
                    break;
                case "h1":
                    viewModel = new EditH1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemH1), ItemType.ItemH1);
                    break;
                case "h2":
                    viewModel = new EditH2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemH2), ItemType.ItemH2);
                    break;
                case "h3":
                    viewModel = new EditH3ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemH3), ItemType.ItemH3);
                    break;
                case "h4":
                    viewModel = new EditH4ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemH4), ItemType.ItemH4);
                    break;
                case "h5":
                    viewModel = new EditH5ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemH5), ItemType.ItemH5);
                    break;
                case "i1":
                    viewModel = new EditI1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemI1), ItemType.ItemI1);
                    break;
                case "i2":
                    viewModel = new EditI2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemI2), ItemType.ItemI2);
                    break;
                case "j1":
                    viewModel = new EditJ1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemJ1), ItemType.ItemJ1);
                    break;
                case "k1":
                    viewModel = new EditK1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemK1), ItemType.ItemK1);
                    break;
                case "k2":
                    viewModel = new EditK2ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemK2), ItemType.ItemK2);
                    break;
                case "k3":
                    viewModel = new EditK3ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemK3), ItemType.ItemK3);
                    break;
                case "l1":
                    viewModel = new EditL1ItemViewModel(dialogCoordinator, Quote, getItems(ItemType.ItemL1), ItemType.ItemL1);
                    break;
            }

            if (viewModel != null)
            {
                Product product = companyService.GetProduct(Companies, itemsName);
                viewModel.OnItemsSavedRequested += OnItemsSaved;
                windowService.EditItemsWndow(viewModel, $"Edit {product.Name}");
            }
        }

        #endregion

        #region On Items Saved
        private void OnItemsSaved(IList<IItem> items, ItemType itemType)
        {
            items.ToList().ForEach(x => x.HasTitles = x.Titles != null && x.Titles.Count() > 0);

            Subfix subfix = GetSubfix(itemType);

            switch (subfix)
            {
                case Subfix.A:
                    HandleItemA(items, itemType);
                    break;

                case Subfix.B:
                    HandleItemB(items, itemType);
                    break;

                case Subfix.C:
                    HandleItemC(items, itemType);
                    break;

                case Subfix.D:
                    HandleItemD(items, itemType);
                    break;

                case Subfix.E:
                    HandleItemE(items, itemType);
                    break;

                case Subfix.F:
                    HandleItemF(items, itemType);
                    break;

                case Subfix.G:
                    HandleItemG(items, itemType);
                    break;

                case Subfix.H:
                    HandleItemH(items, itemType);
                    break;

                case Subfix.I:
                    HandleItemI(items, itemType);
                    break;

                case Subfix.J:
                    HandleItemJ(items, itemType);
                    break;

                case Subfix.K:
                    HandleItemK(items, itemType);
                    break;

                case Subfix.L:
                    HandleItemL(items, itemType);
                    break;

                default:
                    // Manejar otros tipos de elementos aquí, si es necesario
                    break;
            }
        }

        private void HandleItemA(IList<IItem> items, ItemType itemType)
        {
            if (ItemListViewModels.Any(x => x is AItemListViewModel))
            {
                AItemListViewModel itemListViewModel = (AItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is AItemListViewModel);

                switch (itemType)
                {
                    case ItemType.ItemA1:
                        itemListViewModel.ItemA1s = items.ToObservableCollection();
                        break;
                    case ItemType.ItemA2:
                        itemListViewModel.ItemA2s = items.ToObservableCollection();
                        break;
                    case ItemType.ItemA3:
                        itemListViewModel.ItemA3s = items.ToObservableCollection();
                        break;
                    case ItemType.ItemA4:
                        itemListViewModel.ItemA4s = items.ToObservableCollection();
                        break;
                }
            }
            else
            {
                AItemListViewModel itemListViewModel = new AItemListViewModel(dialogCoordinator, items, Quote, Companies);
                CreateAddItemListViewModelAndQuoteCompany(Subfix.A, itemListViewModel);
            }
        }

        private void HandleItemB(IList<IItem> items, ItemType itemType)
        {
            if (ItemListViewModels.Any(x => x is BItemListViewModel))
            {
                BItemListViewModel itemListViewModel = (BItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is BItemListViewModel);

                switch (itemType)
                {
                    case ItemType.ItemB1:
                        itemListViewModel.ItemB1s = items.ToObservableCollection();
                        break;
                    case ItemType.ItemB2:
                        itemListViewModel.ItemB2s = items.ToObservableCollection();
                        break;
                    case ItemType.ItemB3:
                        itemListViewModel.ItemB3s = items.ToObservableCollection();
                        break;
                    case ItemType.ItemB4:
                        itemListViewModel.ItemB4s = items.ToObservableCollection();
                        break;
                    case ItemType.ItemB5:
                        itemListViewModel.ItemB5s = items.ToObservableCollection();
                        break;
                }
            }
            else
            {
                BItemListViewModel itemListViewModel = new BItemListViewModel(dialogCoordinator, items, Quote, Companies);
                CreateAddItemListViewModelAndQuoteCompany(Subfix.B, itemListViewModel);
            }
        }

        private void HandleItemC(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is CItemListViewModel))
            //{
            //    CItemListViewModel itemListViewModel = (CItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is CItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemC1:
            //            itemListViewModel.ItemC1s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemC2:
            //            itemListViewModel.ItemC2s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemC3:
            //            itemListViewModel.ItemC3s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemC4:
            //            itemListViewModel.ItemC4s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemC5:
            //            itemListViewModel.ItemC5s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemC6:
            //            itemListViewModel.ItemC6s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemC7:
            //            itemListViewModel.ItemC7s = items.ToObservableCollection();
            //            break;
            //    }
            //}
            //else
            //{
            //    CItemListViewModel itemListViewModel = new CItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemD(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is DItemListViewModel))
            //{
            //    DItemListViewModel itemListViewModel = (DItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is DItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemD1:
            //            itemListViewModel.ItemD1s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemD2:
            //            itemListViewModel.ItemD2s = items.ToObservableCollection();
            //            break;
            //            // Agrega los casos para ItemD3, ItemD4, etc. según sea necesario.
            //    }
            //}
            //else
            //{
            //    DItemListViewModel itemListViewModel = new DItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemE(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is EItemListViewModel))
            //{
            //    EItemListViewModel itemListViewModel = (EItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is EItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemE1:
            //            itemListViewModel.ItemE1s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemE2:
            //            itemListViewModel.ItemE2s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemE3:
            //            itemListViewModel.ItemE3s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemE4:
            //            itemListViewModel.ItemE4s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemE5:
            //            itemListViewModel.ItemE5s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemE6:
            //            itemListViewModel.ItemE6s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemE7:
            //            itemListViewModel.ItemE7s = items.ToObservableCollection();
            //            break;
            //    }
            //}
            //else
            //{
            //    EItemListViewModel itemListViewModel = new EItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemF(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is FItemListViewModel))
            //{
            //    FItemListViewModel itemListViewModel = (FItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is FItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemF1:
            //            itemListViewModel.ItemF1s = items.ToObservableCollection();
            //            break;
            //            // Agregar más casos según sea necesario para elementos de tipo "F"
            //    }
            //}
            //else
            //{
            //    FItemListViewModel itemListViewModel = new FItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemG(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is GItemListViewModel))
            //{
            //    GItemListViewModel itemListViewModel = (GItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is GItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemG1:
            //            itemListViewModel.ItemG1s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemG2:
            //            itemListViewModel.ItemG2s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemG3:
            //            itemListViewModel.ItemG3s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemG4:
            //            itemListViewModel.ItemG4s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemG5:
            //            itemListViewModel.ItemG5s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemG6:
            //            itemListViewModel.ItemG6s = items.ToObservableCollection();
            //            break;
            //            // Agregar más casos según sea necesario para elementos de tipo "G"
            //    }
            //}
            //else
            //{
            //    GItemListViewModel itemListViewModel = new GItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemH(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is HItemListViewModel))
            //{
            //    HItemListViewModel itemListViewModel = (HItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is HItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemH1:
            //            itemListViewModel.ItemH1s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemH2:
            //            itemListViewModel.ItemH2s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemH3:
            //            itemListViewModel.ItemH3s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemH4:
            //            itemListViewModel.ItemH4s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemH5:
            //            itemListViewModel.ItemH5s = items.ToObservableCollection();
            //            break;
            //            // Agregar más casos según sea necesario para elementos de tipo "H"
            //    }
            //}
            //else
            //{
            //    HItemListViewModel itemListViewModel = new HItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemI(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is IItemListViewModel))
            //{
            //    IItemListViewModel itemListViewModel = (IItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is IItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemI1:
            //            itemListViewModel.ItemI1s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemI2:
            //            itemListViewModel.ItemI2s = items.ToObservableCollection();
            //            break;
            //            // Agregar más casos según sea necesario para elementos de tipo "I"
            //    }
            //}
            //else
            //{
            //    IItemListViewModel itemListViewModel = new IItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemJ(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is JItemListViewModel))
            //{
            //    JItemListViewModel itemListViewModel = (JItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is JItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemJ1:
            //            itemListViewModel.ItemJ1s = items.ToObservableCollection();
            //            break;
            //            // Agregar más casos según sea necesario para elementos de tipo "J"
            //    }
            //}
            //else
            //{
            //    JItemListViewModel itemListViewModel = new JItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemK(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is KItemListViewModel))
            //{
            //    KItemListViewModel itemListViewModel = (KItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is KItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemK1:
            //            itemListViewModel.ItemK1s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemK2:
            //            itemListViewModel.ItemK2s = items.ToObservableCollection();
            //            break;
            //        case ItemType.ItemK3:
            //            itemListViewModel.ItemK3s = items.ToObservableCollection();
            //            break;
            //            // Agregar más casos según sea necesario para elementos de tipo "K"
            //    }
            //}
            //else
            //{
            //    KItemListViewModel itemListViewModel = new KItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }

        private void HandleItemL(IList<IItem> items, ItemType itemType)
        {
            //if (ItemListViewModels.Any(x => x is LItemListViewModel))
            //{
            //    LItemListViewModel itemListViewModel = (LItemListViewModel)ItemListViewModels.FirstOrDefault(x => x is LItemListViewModel);

            //    switch (itemType)
            //    {
            //        case ItemType.ItemL1:
            //            itemListViewModel.ItemL1s = items.ToObservableCollection();
            //            break;
            //            // Agregar más casos según sea necesario para elementos de tipo "L"
            //    }
            //}
            //else
            //{
            //    LItemListViewModel itemListViewModel = new LItemListViewModel(dialogCoordinator, items, Quote, Companies);
            //    ItemListViewModels.Add(itemListViewModel);
            //}
        }
        #endregion
    }
}
