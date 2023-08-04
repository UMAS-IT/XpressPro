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

        private ObservableCollection<IItem> _itemC5s;
        public ObservableCollection<IItem> ItemC5s
        {
            get => _itemC5s;
            set => SetProperty(ref _itemC5s, value);
        }

        private ObservableCollection<IItem> _itemC6s;
        public ObservableCollection<IItem> ItemC6s
        {
            get => _itemC6s;
            set => SetProperty(ref _itemC6s, value);
        }

        private ObservableCollection<IItem> _itemC7s;
        public ObservableCollection<IItem> ItemC7s
        {
            get => _itemC7s;
            set => SetProperty(ref _itemC7s, value);
        }

        private ObservableCollection<IItem> _itemD1s;
        public ObservableCollection<IItem> ItemD1s
        {
            get => _itemD1s;
            set => SetProperty(ref _itemD1s, value);
        }

        private ObservableCollection<IItem> _itemD2s;
        public ObservableCollection<IItem> ItemD2s
        {
            get => _itemD2s;
            set => SetProperty(ref _itemD2s, value);
        }

        private ObservableCollection<IItem> _itemE1s;
        public ObservableCollection<IItem> ItemE1s
        {
            get => _itemE1s;
            set => SetProperty(ref _itemE1s, value);
        }

        private ObservableCollection<IItem> _itemE2s;
        public ObservableCollection<IItem> ItemE2s
        {
            get => _itemE2s;
            set => SetProperty(ref _itemE2s, value);
        }

        private ObservableCollection<IItem> _itemE3s;
        public ObservableCollection<IItem> ItemE3s
        {
            get => _itemE3s;
            set => SetProperty(ref _itemE3s, value);
        }

        private ObservableCollection<IItem> _itemE4s;
        public ObservableCollection<IItem> ItemE4s
        {
            get => _itemE4s;
            set => SetProperty(ref _itemE4s, value);
        }

        private ObservableCollection<IItem> _itemE5s;
        public ObservableCollection<IItem> ItemE5s
        {
            get => _itemE5s;
            set => SetProperty(ref _itemE5s, value);
        }

        private ObservableCollection<IItem> _itemE6s;
        public ObservableCollection<IItem> ItemE6s
        {
            get => _itemE6s;
            set => SetProperty(ref _itemE6s, value);
        }

        private ObservableCollection<IItem> _itemE7s;
        public ObservableCollection<IItem> ItemE7s
        {
            get => _itemE7s;
            set => SetProperty(ref _itemE7s, value);
        }

        private ObservableCollection<IItem> _itemF1s;
        public ObservableCollection<IItem> ItemF1s
        {
            get => _itemF1s;
            set => SetProperty(ref _itemF1s, value);
        }

        private ObservableCollection<IItem> _itemG1s;
        public ObservableCollection<IItem> ItemG1s
        {
            get => _itemG1s;
            set => SetProperty(ref _itemG1s, value);
        }

        private ObservableCollection<IItem> _itemG2s;
        public ObservableCollection<IItem> ItemG2s
        {
            get => _itemG2s;
            set => SetProperty(ref _itemG2s, value);
        }

        private ObservableCollection<IItem> _itemG3s;
        public ObservableCollection<IItem> ItemG3s
        {
            get => _itemG3s;
            set => SetProperty(ref _itemG3s, value);
        }

        private ObservableCollection<IItem> _itemG4s;
        public ObservableCollection<IItem> ItemG4s
        {
            get => _itemG4s;
            set => SetProperty(ref _itemG4s, value);
        }

        private ObservableCollection<IItem> _itemG5s;
        public ObservableCollection<IItem> ItemG5s
        {
            get => _itemG5s;
            set => SetProperty(ref _itemG5s, value);
        }

        private ObservableCollection<IItem> _itemG6s;
        public ObservableCollection<IItem> ItemG6s
        {
            get => _itemG6s;
            set => SetProperty(ref _itemG6s, value);
        }

        private ObservableCollection<IItem> _itemH1s;
        public ObservableCollection<IItem> ItemH1s
        {
            get => _itemH1s;
            set => SetProperty(ref _itemH1s, value);
        }

        private ObservableCollection<IItem> _itemH2s;
        public ObservableCollection<IItem> ItemH2s
        {
            get => _itemH2s;
            set => SetProperty(ref _itemH2s, value);
        }

        private ObservableCollection<IItem> _itemH3s;
        public ObservableCollection<IItem> ItemH3s
        {
            get => _itemH3s;
            set => SetProperty(ref _itemH3s, value);
        }

        private ObservableCollection<IItem> _itemH4s;
        public ObservableCollection<IItem> ItemH4s
        {
            get => _itemH4s;
            set => SetProperty(ref _itemH4s, value);
        }

        private ObservableCollection<IItem> _itemH5s;
        public ObservableCollection<IItem> ItemH5s
        {
            get => _itemH5s;
            set => SetProperty(ref _itemH5s, value);
        }

        private ObservableCollection<IItem> _itemI1s;
        public ObservableCollection<IItem> ItemI1s
        {
            get => _itemI1s;
            set => SetProperty(ref _itemI1s, value);
        }

        private ObservableCollection<IItem> _itemI2s;
        public ObservableCollection<IItem> ItemI2s
        {
            get => _itemI2s;
            set => SetProperty(ref _itemI2s, value);
        }

        private ObservableCollection<IItem> _itemJ1s;
        public ObservableCollection<IItem> ItemJ1s
        {
            get => _itemJ1s;
            set => SetProperty(ref _itemJ1s, value);
        }

        private ObservableCollection<IItem> _itemK1s;
        public ObservableCollection<IItem> ItemK1s
        {
            get => _itemK1s;
            set => SetProperty(ref _itemK1s, value);
        }

        private ObservableCollection<IItem> _itemK2s;
        public ObservableCollection<IItem> ItemK2s
        {
            get => _itemK2s;
            set => SetProperty(ref _itemK2s, value);
        }

        private ObservableCollection<IItem> _itemK3s;
        public ObservableCollection<IItem> ItemK3s
        {
            get => _itemK3s;
            set => SetProperty(ref _itemK3s, value);
        }

        private ObservableCollection<IItem> _itemL1s;
        public ObservableCollection<IItem> ItemL1s
        {
            get => _itemL1s;
            set => SetProperty(ref _itemL1s, value);
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

        public RelayCommand<IItem> TotalPriceChangedCommand { get; set; }

        #region Total Prices

        private double _totalPriceA1;
        public double TotalPriceA1
        {
            get => _totalPriceA1;
            set => SetProperty(ref _totalPriceA1, value);
        }
        #endregion

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
            TotalPriceChangedCommand = new RelayCommand<IItem>(OnTotalPriceChanged);

            projectService = new ProjectService();
            quoteService = new QuoteService();
            messageService = new MessageService(dialogCoordinator, this);
            windowService = new WindowService();
            itemService = new ItemService();
            companyService = new CompanyService();
        }

        private void LoadItemLists()
        {
            Items.ToList().ForEach(x => x.HasTitles = x.Titles != null && x.Titles.Count() > 0);

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
            ItemC5s = Items.Where(x => x is ItemC5).ToObservableCollection();
            ItemC6s = Items.Where(x => x is ItemC6).ToObservableCollection();
            ItemC7s = Items.Where(x => x is ItemC7).ToObservableCollection();

            ItemD1s = Items.Where(x => x is ItemD1).ToObservableCollection();
            ItemD2s = Items.Where(x => x is ItemD2).ToObservableCollection();

            ItemE1s = Items.Where(x => x is ItemE1).ToObservableCollection();
            ItemE2s = Items.Where(x => x is ItemE2).ToObservableCollection();
            ItemE3s = Items.Where(x => x is ItemE3).ToObservableCollection();
            ItemE4s = Items.Where(x => x is ItemE4).ToObservableCollection();
            ItemE5s = Items.Where(x => x is ItemE5).ToObservableCollection();
            ItemE6s = Items.Where(x => x is ItemE6).ToObservableCollection();
            ItemE7s = Items.Where(x => x is ItemE7).ToObservableCollection();

            ItemF1s = Items.Where(x => x is ItemF1).ToObservableCollection();

            ItemG1s = Items.Where(x => x is ItemG1).ToObservableCollection();
            ItemG2s = Items.Where(x => x is ItemG2).ToObservableCollection();
            ItemG3s = Items.Where(x => x is ItemG3).ToObservableCollection();
            ItemG4s = Items.Where(x => x is ItemG4).ToObservableCollection();
            ItemG5s = Items.Where(x => x is ItemG5).ToObservableCollection();
            ItemG6s = Items.Where(x => x is ItemG6).ToObservableCollection();

            ItemH1s = Items.Where(x => x is ItemH1).ToObservableCollection();
            ItemH2s = Items.Where(x => x is ItemH2).ToObservableCollection();
            ItemH3s = Items.Where(x => x is ItemH3).ToObservableCollection();
            ItemH4s = Items.Where(x => x is ItemH4).ToObservableCollection();
            ItemH5s = Items.Where(x => x is ItemH5).ToObservableCollection();

            ItemI1s = Items.Where(x => x is ItemI1).ToObservableCollection();
            ItemI2s = Items.Where(x => x is ItemI2).ToObservableCollection();

            ItemJ1s = Items.Where(x => x is ItemJ1).ToObservableCollection();

            ItemK1s = Items.Where(x => x is ItemK1).ToObservableCollection();
            ItemK2s = Items.Where(x => x is ItemK2).ToObservableCollection();
            ItemK3s = Items.Where(x => x is ItemK3).ToObservableCollection();

            ItemL1s = Items.Where(x => x is ItemL1).ToObservableCollection();
        }

        private async void OnUpdateQuoteItems()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Saving quote items, please wait...");

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
                ItemC5s.ToList().ForEach(x => x.DesignIndex = ItemC5s.IndexOf(x));
                ItemC6s.ToList().ForEach(x => x.DesignIndex = ItemC6s.IndexOf(x));
                ItemC7s.ToList().ForEach(x => x.DesignIndex = ItemC7s.IndexOf(x));

                // last set of DesignIndex
                ItemD1s.ToList().ForEach(x => x.DesignIndex = ItemD1s.IndexOf(x));
                ItemD2s.ToList().ForEach(x => x.DesignIndex = ItemD2s.IndexOf(x));

                // last set of DesignIndex
                ItemE1s.ToList().ForEach(x => x.DesignIndex = ItemE1s.IndexOf(x));
                ItemE2s.ToList().ForEach(x => x.DesignIndex = ItemE2s.IndexOf(x));
                ItemE3s.ToList().ForEach(x => x.DesignIndex = ItemE3s.IndexOf(x));
                ItemE4s.ToList().ForEach(x => x.DesignIndex = ItemE4s.IndexOf(x));
                ItemE5s.ToList().ForEach(x => x.DesignIndex = ItemE5s.IndexOf(x));
                ItemE6s.ToList().ForEach(x => x.DesignIndex = ItemE6s.IndexOf(x));
                ItemE7s.ToList().ForEach(x => x.DesignIndex = ItemE7s.IndexOf(x));
                
                // last set of DesignIndex
                ItemF1s.ToList().ForEach(x => x.DesignIndex = ItemF1s.IndexOf(x));

                // last set of DesignIndex
                ItemG1s.ToList().ForEach(x => x.DesignIndex = ItemG1s.IndexOf(x));
                ItemG2s.ToList().ForEach(x => x.DesignIndex = ItemG2s.IndexOf(x));
                ItemG3s.ToList().ForEach(x => x.DesignIndex = ItemG3s.IndexOf(x));
                ItemG4s.ToList().ForEach(x => x.DesignIndex = ItemG4s.IndexOf(x));
                ItemG5s.ToList().ForEach(x => x.DesignIndex = ItemG5s.IndexOf(x));
                ItemG6s.ToList().ForEach(x => x.DesignIndex = ItemG6s.IndexOf(x));

                // last set of DesignIndex
                ItemH1s.ToList().ForEach(x => x.DesignIndex = ItemH1s.IndexOf(x));
                ItemH2s.ToList().ForEach(x => x.DesignIndex = ItemH2s.IndexOf(x));
                ItemH3s.ToList().ForEach(x => x.DesignIndex = ItemH3s.IndexOf(x));
                ItemH4s.ToList().ForEach(x => x.DesignIndex = ItemH4s.IndexOf(x));
                ItemH5s.ToList().ForEach(x => x.DesignIndex = ItemH5s.IndexOf(x));

                // last set of DesignIndex
                ItemI1s.ToList().ForEach(x => x.DesignIndex = ItemI1s.IndexOf(x));
                ItemI2s.ToList().ForEach(x => x.DesignIndex = ItemI2s.IndexOf(x));

                // last set of DesignIndex
                ItemJ1s.ToList().ForEach(x => x.DesignIndex = ItemJ1s.IndexOf(x));

                // last set of DesignIndex
                ItemK1s.ToList().ForEach(x => x.DesignIndex = ItemK1s.IndexOf(x));
                ItemK2s.ToList().ForEach(x => x.DesignIndex = ItemK2s.IndexOf(x));
                ItemK3s.ToList().ForEach(x => x.DesignIndex = ItemK3s.IndexOf(x));

                ItemL1s.ToList().ForEach(x => x.DesignIndex = ItemL1s.IndexOf(x));


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
                items.AddRange(ItemC5s);
                items.AddRange(ItemC6s);
                items.AddRange(ItemC7s);

                items.AddRange(ItemD1s);
                items.AddRange(ItemD2s);

                items.AddRange(ItemE1s);
                items.AddRange(ItemE2s);
                items.AddRange(ItemE3s);
                items.AddRange(ItemE4s);
                items.AddRange(ItemE5s);
                items.AddRange(ItemE6s);
                items.AddRange(ItemE7s);

                items.AddRange(ItemF1s);

                items.AddRange(ItemG1s);
                items.AddRange(ItemG2s);
                items.AddRange(ItemG3s);
                items.AddRange(ItemG4s);
                items.AddRange(ItemG5s);
                items.AddRange(ItemG6s);

                items.AddRange(ItemH1s);
                items.AddRange(ItemH2s);
                items.AddRange(ItemH3s);
                items.AddRange(ItemH4s);
                items.AddRange(ItemH5s);

                items.AddRange(ItemI1s);
                items.AddRange(ItemI2s);

                items.AddRange(ItemJ1s);

                items.AddRange(ItemK1s);
                items.AddRange(ItemK2s);
                items.AddRange(ItemK3s);

                items.AddRange(ItemL1s);


                if (!await CanUpdateQuoteItems(items))
                    return;

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

        private void OnEditItems(string itemsName)
        {
            IEditItemViewModel viewModel = null;

            if (itemsName.ToFormat() == "a1")
            {
                viewModel = new EditA1ItemViewModel(dialogCoordinator, Quote, ItemA1s, ItemType.ItemA1);
            }
            else if (itemsName.ToFormat() == "a2")
            {
                viewModel = new EditA2ItemViewModel(dialogCoordinator, Quote, ItemA2s, ItemType.ItemA2);
            }
            else if (itemsName.ToFormat() == "a3")
            {
                viewModel = new EditA3ItemViewModel(dialogCoordinator, Quote, ItemA3s, ItemType.ItemA3);
            }
            else if (itemsName.ToFormat() == "a4")
            {
                viewModel = new EditA4ItemViewModel(dialogCoordinator, Quote, ItemA4s, ItemType.ItemA4);
            }

            else if (itemsName.ToFormat() == "b1")
            {
                viewModel = new EditB1ItemViewModel(dialogCoordinator, Quote, ItemB1s, ItemType.ItemB1);
            }
            else if (itemsName.ToFormat() == "b2")
            {
                viewModel = new EditB2ItemViewModel(dialogCoordinator, Quote, ItemB2s, ItemType.ItemB2);
            }
            else if (itemsName.ToFormat() == "b3")
            {
                viewModel = new EditB3ItemViewModel(dialogCoordinator, Quote, ItemB3s, ItemType.ItemB3);
            }
            else if (itemsName.ToFormat() == "b4")
            {
                viewModel = new EditB4ItemViewModel(dialogCoordinator, Quote, ItemB4s, ItemType.ItemB4);
            }
            else if (itemsName.ToFormat() == "b5")
            {
                viewModel = new EditB5ItemViewModel(dialogCoordinator, Quote, ItemB5s, ItemType.ItemB5);
            }

            else if (itemsName.ToFormat() == "c1")
            {
                viewModel = new EditC1ItemViewModel(dialogCoordinator, Quote, ItemC1s, ItemType.ItemC1);
            }
            else if (itemsName.ToFormat() == "c2")
            {
                viewModel = new EditC2ItemViewModel(dialogCoordinator, Quote, ItemC2s, ItemType.ItemC2);
            }
            else if (itemsName.ToFormat() == "c3")
            {
                viewModel = new EditC3ItemViewModel(dialogCoordinator, Quote, ItemC3s, ItemType.ItemC3);
            }
            else if (itemsName.ToFormat() == "c4")
            {
                viewModel = new EditC4ItemViewModel(dialogCoordinator, Quote, ItemC4s, ItemType.ItemC4);
            }
            else if (itemsName.ToFormat() == "c5")
            {
                viewModel = new EditC5ItemViewModel(dialogCoordinator, Quote, ItemC5s, ItemType.ItemC5);
            }
            else if (itemsName.ToFormat() == "c6")
            {
                viewModel = new EditC6ItemViewModel(dialogCoordinator, Quote, ItemC6s, ItemType.ItemC6);
            }
            else if (itemsName.ToFormat() == "c7")
            {
                viewModel = new EditC7ItemViewModel(dialogCoordinator, Quote, ItemC7s, ItemType.ItemC7);
            }

            else if (itemsName.ToFormat() == "d1")
            {
                viewModel = new EditD1ItemViewModel(dialogCoordinator, Quote, ItemD1s, ItemType.ItemD1);
            }
            else if (itemsName.ToFormat() == "d2")
            {
                viewModel = new EditD2ItemViewModel(dialogCoordinator, Quote, ItemD2s, ItemType.ItemD2);
            }

            else if (itemsName.ToFormat() == "e1")
            {
                viewModel = new EditE1ItemViewModel(dialogCoordinator, Quote, ItemE1s, ItemType.ItemE1);
            }
            else if (itemsName.ToFormat() == "e2")
            {
                viewModel = new EditE2ItemViewModel(dialogCoordinator, Quote, ItemE2s, ItemType.ItemE2);
            }
            else if (itemsName.ToFormat() == "e3")
            {
                viewModel = new EditE3ItemViewModel(dialogCoordinator, Quote, ItemE3s, ItemType.ItemE3);
            }
            else if (itemsName.ToFormat() == "e4")
            {
                viewModel = new EditE4ItemViewModel(dialogCoordinator, Quote, ItemE4s, ItemType.ItemE4);
            }
            else if (itemsName.ToFormat() == "e5")
            {
                viewModel = new EditE5ItemViewModel(dialogCoordinator, Quote, ItemE5s, ItemType.ItemE5);
            }
            else if (itemsName.ToFormat() == "e6")
            {
                viewModel = new EditE6ItemViewModel(dialogCoordinator, Quote, ItemE6s, ItemType.ItemE6);
            }
            else if (itemsName.ToFormat() == "e7")
            {
                viewModel = new EditE7ItemViewModel(dialogCoordinator, Quote, ItemE7s, ItemType.ItemE7);
            }

            else if (itemsName.ToFormat() == "f1")
            {
                viewModel = new EditF1ItemViewModel(dialogCoordinator, Quote, ItemF1s, ItemType.ItemF1);
            }

            else if (itemsName.ToFormat() == "g1")
            {
                viewModel = new EditG1ItemViewModel(dialogCoordinator, Quote, ItemG1s, ItemType.ItemG1);
            }
            else if (itemsName.ToFormat() == "g2")
            {
                viewModel = new EditG2ItemViewModel(dialogCoordinator, Quote, ItemG2s, ItemType.ItemG2);
            }
            else if (itemsName.ToFormat() == "g3")
            {
                viewModel = new EditG3ItemViewModel(dialogCoordinator, Quote, ItemG3s, ItemType.ItemG3);
            }
            else if (itemsName.ToFormat() == "g4")
            {
                viewModel = new EditG4ItemViewModel(dialogCoordinator, Quote, ItemG4s, ItemType.ItemG4);
            }
            else if (itemsName.ToFormat() == "g5")
            {
                viewModel = new EditG5ItemViewModel(dialogCoordinator, Quote, ItemG5s, ItemType.ItemG5);
            }
            else if (itemsName.ToFormat() == "g6")
            {
                viewModel = new EditG6ItemViewModel(dialogCoordinator, Quote, ItemG6s, ItemType.ItemG6);
            }

            else if (itemsName.ToFormat() == "h1")
            {
                viewModel = new EditH1ItemViewModel(dialogCoordinator, Quote, ItemH1s, ItemType.ItemH1);
            }
            else if (itemsName.ToFormat() == "h2")
            {
                viewModel = new EditH2ItemViewModel(dialogCoordinator, Quote, ItemH2s, ItemType.ItemH2);
            }
            else if (itemsName.ToFormat() == "h3")
            {
                viewModel = new EditH3ItemViewModel(dialogCoordinator, Quote, ItemH3s, ItemType.ItemH3);
            }
            else if (itemsName.ToFormat() == "h4")
            {
                viewModel = new EditH4ItemViewModel(dialogCoordinator, Quote, ItemH4s, ItemType.ItemH4);
            }
            else if (itemsName.ToFormat() == "h5")
            {
                viewModel = new EditH5ItemViewModel(dialogCoordinator, Quote, ItemH5s, ItemType.ItemH5);
            }

            else if (itemsName.ToFormat() == "i1")
            {
                viewModel = new EditI1ItemViewModel(dialogCoordinator, Quote, ItemI1s, ItemType.ItemI1);
            }
            else if (itemsName.ToFormat() == "i2")
            {
                viewModel = new EditI2ItemViewModel(dialogCoordinator, Quote, ItemI2s, ItemType.ItemI2);
            }

            else if (itemsName.ToFormat() == "j1")
            {
                viewModel = new EditJ1ItemViewModel(dialogCoordinator, Quote, ItemJ1s, ItemType.ItemJ1);
            }

            else if (itemsName.ToFormat() == "k1")
            {
                viewModel = new EditK1ItemViewModel(dialogCoordinator, Quote, ItemK1s, ItemType.ItemK1);
            }
            else if (itemsName.ToFormat() == "k2")
            {
                viewModel = new EditK2ItemViewModel(dialogCoordinator, Quote, ItemK2s, ItemType.ItemK2);
            }
            else if (itemsName.ToFormat() == "k3")
            {
                viewModel = new EditK3ItemViewModel(dialogCoordinator, Quote, ItemK3s, ItemType.ItemK3);
            }
            else if (itemsName.ToFormat() == "l1")
            {
                viewModel = new EditL1ItemViewModel(dialogCoordinator, Quote, ItemL1s, ItemType.ItemL1);
            }

            Product product = companyService.GetProduct(Companies, itemsName);

            viewModel.OnItemsSavedRequested += OnItemsSaved;
            windowService.EditItemsWndow(viewModel, $"Edit {product.Name}");

            // aqui me quede
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

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            IItem currentItem = currentItems.FirstOrDefault(x => x.Id == item.Id);

            currentItem.Titles = titles.ToObservableCollection();

            currentItem.HasTitles = titles != null && titles.Count > 0;

            //OnPropertyChange(nameof(currentItem.HasTitles));
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

            OnTotalPriceChanged(item);
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
            else if (item is ItemC5)
                selectedItems = ItemC5s;
            else if (item is ItemC6)
                selectedItems = ItemC6s;
            else if (item is ItemC7)
                selectedItems = ItemC7s;

            else if (item is ItemD1)
                selectedItems = ItemD1s;
            else if (item is ItemD2)
                selectedItems = ItemC2s;

            else if (item is ItemE1)
                selectedItems = ItemE1s;
            else if (item is ItemE2)
                selectedItems = ItemE2s;
            else if (item is ItemE3)
                selectedItems = ItemE3s;
            else if (item is ItemE4)
                selectedItems = ItemE4s;
            else if (item is ItemE5)
                selectedItems = ItemE5s;
            else if (item is ItemE6)
                selectedItems = ItemE6s;
            else if (item is ItemE7)
                selectedItems = ItemE7s;

            else if (item is ItemF1)
                selectedItems = ItemF1s;

            else if (item is ItemG1)
                selectedItems = ItemG1s;
            else if (item is ItemG2)
                selectedItems = ItemG2s;
            else if (item is ItemG3)
                selectedItems = ItemG3s;
            else if (item is ItemG4)
                selectedItems = ItemG4s;
            else if (item is ItemG5)
                selectedItems = ItemG5s;
            else if (item is ItemG6)
                selectedItems = ItemG6s;

            else if (item is ItemH1)
                selectedItems = ItemH1s;
            else if (item is ItemH2)
                selectedItems = ItemH2s;
            else if (item is ItemH3)
                selectedItems = ItemH3s;
            else if (item is ItemH4)
                selectedItems = ItemH4s;
            else if (item is ItemH5)
                selectedItems = ItemH5s;

            else if (item is ItemI1)
                selectedItems = ItemI1s;
            else if (item is ItemI2)
                selectedItems = ItemI2s;

            else if (item is ItemJ1)
                selectedItems = ItemJ1s;

            else if (item is ItemK1)
                selectedItems = ItemK1s;
            else if (item is ItemK2)
                selectedItems = ItemK2s;
            else if (item is ItemK3)
                selectedItems = ItemK3s;

            else if (item is ItemL1)
                selectedItems = ItemL1s;

            return selectedItems;
        }


        private void OnTotalPriceChanged(IItem item)
        {
            
            if (item is ItemA1)
                OnPropertyChange(nameof(ItemA1s));
            else if (item is ItemA2)
                OnPropertyChange(nameof(ItemA2s));
            else if (item is ItemA3)
                OnPropertyChange(nameof(ItemA3s));
            else if (item is ItemA4)
                OnPropertyChange(nameof(ItemA4s));

            else if (item is ItemB1)
                OnPropertyChange(nameof(ItemB1s));
            else if (item is ItemB2)
                OnPropertyChange(nameof(ItemB2s));
            else if (item is ItemB3)
                OnPropertyChange(nameof(ItemB3s));
            else if (item is ItemB4)
                OnPropertyChange(nameof(ItemB4s));
            else if (item is ItemB5)
                OnPropertyChange(nameof(ItemB5s));

            else if (item is ItemC1)
                OnPropertyChange(nameof(ItemC1s));
            else if (item is ItemC2)
                OnPropertyChange(nameof(ItemC2s));
            else if (item is ItemC3)
                OnPropertyChange(nameof(ItemC3s));
            else if (item is ItemC4)
                OnPropertyChange(nameof(ItemC4s));
            else if (item is ItemC5)
                OnPropertyChange(nameof(ItemC5s));
            else if (item is ItemC6)
                OnPropertyChange(nameof(ItemC6s));
            else if (item is ItemC7)
                OnPropertyChange(nameof(ItemC7s));

            else if (item is ItemD1)
                OnPropertyChange(nameof(ItemD1s));
            else if (item is ItemD2)
                OnPropertyChange(nameof(ItemC2s));

            else if (item is ItemE1)
                OnPropertyChange(nameof(ItemE1s));
            else if (item is ItemE2)
                OnPropertyChange(nameof(ItemE2s));
            else if (item is ItemE3)
                OnPropertyChange(nameof(ItemE3s));
            else if (item is ItemE4)
                OnPropertyChange(nameof(ItemE4s));
            else if (item is ItemE5)
                OnPropertyChange(nameof(ItemE5s));
            else if (item is ItemE6)
                OnPropertyChange(nameof(ItemE6s));
            else if (item is ItemE7)
                OnPropertyChange(nameof(ItemE7s));

            else if (item is ItemF1)
                OnPropertyChange(nameof(ItemF1s));

            else if (item is ItemG1)
                OnPropertyChange(nameof(ItemG1s));
            else if (item is ItemG2)
                OnPropertyChange(nameof(ItemG2s));
            else if (item is ItemG3)
                OnPropertyChange(nameof(ItemG3s));
            else if (item is ItemG4)
                OnPropertyChange(nameof(ItemG4s));
            else if (item is ItemG5)
                OnPropertyChange(nameof(ItemG5s));
            else if (item is ItemG6)
                OnPropertyChange(nameof(ItemG6s));

            else if (item is ItemH1)
                OnPropertyChange(nameof(ItemH1s));
            else if (item is ItemH2)
                OnPropertyChange(nameof(ItemH2s));
            else if (item is ItemH3)
                OnPropertyChange(nameof(ItemH3s));
            else if (item is ItemH4)
                OnPropertyChange(nameof(ItemH4s));
            else if (item is ItemH5)
                OnPropertyChange(nameof(ItemH5s));

            else if (item is ItemI1)
                OnPropertyChange(nameof(ItemI1s));
            else if (item is ItemI2)
                OnPropertyChange(nameof(ItemI2s));

            else if (item is ItemJ1)
                OnPropertyChange(nameof(ItemJ1s));

            else if (item is ItemK1)
                OnPropertyChange(nameof(ItemK1s));
            else if (item is ItemK2)
                OnPropertyChange(nameof(ItemK2s));
            else if (item is ItemK3)
                OnPropertyChange(nameof(ItemK3s));
            else if (item is ItemL1)
                OnPropertyChange(nameof(ItemL1s));
        }


        private void OnItemsSaved(IList<IItem> items, ItemType itemType)
        {
            items.ToList().ForEach(x => x.HasTitles = x.Titles != null && x.Titles.Count() > 0);

            if (itemType is ItemType.ItemA1)
                ItemA1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemA2)
                ItemA2s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemA3)
                ItemA3s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemA4)
                ItemA4s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemB1)
                ItemB1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemB2)
                ItemB2s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemB3)
                ItemB3s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemB4)
                ItemB4s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemB5)
                ItemB5s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemC1)
                ItemC1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemC2)
                ItemC2s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemC3)
                ItemC3s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemC4)
                ItemC4s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemC5)
                ItemC5s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemC6)
                ItemC6s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemC7)
                ItemC7s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemD1)
                ItemD1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemD2)
                ItemD2s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemE1)
                ItemE1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemE2)
                ItemE2s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemE3)
                ItemE3s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemE4)
                ItemE4s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemE5)
                ItemE5s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemE6)
                ItemE6s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemE7)
                ItemE7s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemF1)
                ItemF1s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemG1)
                ItemG1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemG2)
                ItemG2s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemG3)
                ItemG3s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemG4)
                ItemG4s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemG5)
                ItemG5s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemG6)
                ItemG6s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemH1)
                ItemH1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemH2)
                ItemH2s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemH3)
                ItemH3s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemH4)
                ItemH4s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemH5)
                ItemH5s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemI1)
                ItemI1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemI2)
                ItemI2s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemJ1)
                ItemJ1s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemK1)
                ItemK1s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemK2)
                ItemK2s = items.ToObservableCollection();
            else if (itemType is ItemType.ItemK3)
                ItemK3s = items.ToObservableCollection();

            else if (itemType is ItemType.ItemL1)
                ItemL1s = items.ToObservableCollection();
        }

    }
}
