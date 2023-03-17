using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Domain.EntityItemBACClosedCircuits;
using Orion.Domain.EntityItemBACCoolingTowers;
using Orion.Domain.EntityItemGroundfos;
using Orion.Domain.EntityItemPuroFlux;
using Orion.Domain.EntityItemUvResources;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.ABB.EditQuoteItem;
using Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem;
using Orion.UI.ViewModel.BACClosedCircuits.EditQuoteItem;
using Orion.UI.ViewModel.BACCoolingTowers.EditQuoteItem;
using Orion.UI.ViewModel.Groundfos.EditQuoteItem;
using Orion.UI.ViewModel.Puroflux.EditQuoteItem;
using Orion.UI.ViewModel.Quantech;
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
            companyService = new CompanyService();
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
            if (itemsName.ToFormat() == "a1")
            {
                EditA1ItemViewModel editA1ItemViewModel = new EditA1ItemViewModel(dialogCoordinator, Quote, ItemA1s, ItemType.ItemA1);
                editA1ItemViewModel.OnItemsSavedRequested += OnItemA1Saved;
                windowService.EditItemsWndow(editA1ItemViewModel, "Edit air cooled chillers factory lead time");
            }
            else if (itemsName.ToFormat() == "a2")
            {
                EditA2ItemViewModel editA2ItemViewModel = new EditA2ItemViewModel(dialogCoordinator, Quote, ItemA2s, ItemType.ItemA2);
                editA2ItemViewModel.OnItemsSavedRequested += OnItemA2Saved;
                windowService.EditItemsWndow(editA2ItemViewModel, "Edit air cooled chillers stock non coated condenser");
            }
            else if (itemsName.ToFormat() == "a3")
            {
                EditA3ItemViewModel editA3ItemViewModel = new EditA3ItemViewModel(dialogCoordinator, Quote, ItemA3s, ItemType.ItemA3);
                editA3ItemViewModel.OnItemsSavedRequested += OnItemA3Saved;
                windowService.EditItemsWndow(editA3ItemViewModel, "Edit air cooled chillers stock post coated condenser");
            }
            else if (itemsName.ToFormat() == "a4")
            {
                EditA4ItemViewModel editA4ItemViewModel = new EditA4ItemViewModel(dialogCoordinator, Quote, ItemA4s, ItemType.ItemA4);
                editA4ItemViewModel.OnItemsSavedRequested += OnItemA4Saved;
                windowService.EditItemsWndow(editA4ItemViewModel, "Edit water cooled chillers factory lead time");
            }

            else if (itemsName.ToFormat() == "b1")
            {
                EditB1ItemViewModel editE1ItemViewModel = new EditB1ItemViewModel(dialogCoordinator, Quote, ItemB1s, ItemType.ItemB1);
                editE1ItemViewModel.OnItemsSavedRequested += OnItemB1Saved;
                windowService.EditItemsWndow(editE1ItemViewModel, "Edit VFD Drives");
            }
            else if (itemsName.ToFormat() == "b2")
            {
                EditB2ItemViewModel editE2ItemViewModel = new EditB2ItemViewModel(dialogCoordinator, Quote, ItemB2s, ItemType.ItemB2);
                editE2ItemViewModel.OnItemsSavedRequested += OnItemB2Saved;
                windowService.EditItemsWndow(editE2ItemViewModel, "Edit VCR");
            }
            else if (itemsName.ToFormat() == "b3")
            {
                EditB3ItemViewModel editE3ItemViewModel = new EditB3ItemViewModel(dialogCoordinator, Quote, ItemB3s, ItemType.ItemB3);
                editE3ItemViewModel.OnItemsSavedRequested += OnItemB3Saved;
                windowService.EditItemsWndow(editE3ItemViewModel, "Edit PCR");
            }
            else if (itemsName.ToFormat() == "b4")
            {
                EditB4ItemViewModel editE4ItemViewModel = new EditB4ItemViewModel(dialogCoordinator, Quote, ItemB4s, ItemType.ItemB4);
                editE4ItemViewModel.OnItemsSavedRequested += OnItemB4Saved;
                windowService.EditItemsWndow(editE4ItemViewModel, "Edit BCR");
            }
            else if (itemsName.ToFormat() == "b5")
            {
                EditB5ItemViewModel editE5ItemViewModel = new EditB5ItemViewModel(dialogCoordinator, Quote, ItemB5s, ItemType.ItemB5);
                editE5ItemViewModel.OnItemsSavedRequested += OnItemB5Saved;
                windowService.EditItemsWndow(editE5ItemViewModel, "Edit Accesories");
            }

            else if (itemsName.ToFormat() == "c1")
            {
                EditC1ItemViewModel editC1ItemViewModel = new EditC1ItemViewModel(dialogCoordinator, Quote, ItemC1s, ItemType.ItemC1);
                editC1ItemViewModel.OnItemsSavedRequested += OnItemC1Saved;
                windowService.EditItemsWndow(editC1ItemViewModel, "Edit CARE");
            }
            else if (itemsName.ToFormat() == "c2")
            {
                EditC2ItemViewModel editC2ItemViewModel = new EditC2ItemViewModel(dialogCoordinator, Quote, ItemC2s, ItemType.ItemC2);
                editC2ItemViewModel.OnItemsSavedRequested += OnItemC2Saved;
                windowService.EditItemsWndow(editC2ItemViewModel, "Edit VCR");
            }
            else if (itemsName.ToFormat() == "c3")
            {
                EditC3ItemViewModel editC3ItemViewModel = new EditC3ItemViewModel(dialogCoordinator, Quote, ItemC3s, ItemType.ItemC3);
                editC3ItemViewModel.OnItemsSavedRequested += OnItemC3Saved;
                windowService.EditItemsWndow(editC3ItemViewModel, "Edit Tanks");
            }
            else if (itemsName.ToFormat() == "c4")
            {
                EditC4ItemViewModel editC4ItemViewModel = new EditC4ItemViewModel(dialogCoordinator, Quote, ItemC4s, ItemType.ItemC4);
                editC4ItemViewModel.OnItemsSavedRequested += OnItemC4Saved;
                windowService.EditItemsWndow(editC4ItemViewModel, "Edit Separatos");
            }

            else if (itemsName.ToFormat() == "d1")
            {
                EditD1ItemViewModel editD1ItemViewModel = new EditD1ItemViewModel(dialogCoordinator, Quote, ItemD1s, ItemType.ItemD1);
                editD1ItemViewModel.OnItemsSavedRequested += OnItemD1Saved;
                windowService.EditItemsWndow(editD1ItemViewModel, "Edit Separators");
            }
            else if (itemsName.ToFormat() == "d2")
            {
                EditD2ItemViewModel editD2ItemViewModel = new EditD2ItemViewModel(dialogCoordinator, Quote, ItemD2s, ItemType.ItemD2);
                editD2ItemViewModel.OnItemsSavedRequested += OnItemD2Saved;
                windowService.EditItemsWndow(editD2ItemViewModel, "Edit Sand Filters");
            }

            else if (itemsName.ToFormat() == "e1")
            {
                EditE1ItemViewModel editE1ItemViewModel = new EditE1ItemViewModel(dialogCoordinator, Quote, ItemE1s, ItemType.ItemE1);
                editE1ItemViewModel.OnItemsSavedRequested += OnItemE1Saved;
                windowService.EditItemsWndow(editE1ItemViewModel, "Edit NBS");
            }
            else if (itemsName.ToFormat() == "e2")
            {
                EditE2ItemViewModel editE2ItemViewModel = new EditE2ItemViewModel(dialogCoordinator, Quote, ItemE2s, ItemType.ItemE2);
                editE2ItemViewModel.OnItemsSavedRequested += OnItemE2Saved;
                windowService.EditItemsWndow(editE2ItemViewModel, "Edit LCS");
            }
            else if (itemsName.ToFormat() == "e3")
            {
                EditE3ItemViewModel editE3ItemViewModel = new EditE3ItemViewModel(dialogCoordinator, Quote, ItemE3s, ItemType.ItemE3);
                editE3ItemViewModel.OnItemsSavedRequested += OnItemE3Saved;
                windowService.EditItemsWndow(editE3ItemViewModel, "Edit LC");
            }
            else if (itemsName.ToFormat() == "e4")
            {
                EditE4ItemViewModel editE4ItemViewModel = new EditE4ItemViewModel(dialogCoordinator, Quote, ItemE4s, ItemType.ItemE4);
                editE4ItemViewModel.OnItemsSavedRequested += OnItemE4Saved;
                windowService.EditItemsWndow(editE4ItemViewModel, "Edit LF");
            }
            else if (itemsName.ToFormat() == "e5")
            {
                EditE5ItemViewModel editE5ItemViewModel = new EditE5ItemViewModel(dialogCoordinator, Quote, ItemE5s, ItemType.ItemE5);
                editE5ItemViewModel.OnItemsSavedRequested += OnItemE5Saved;
                windowService.EditItemsWndow(editE5ItemViewModel, "Edit VL");
            }
            else if (itemsName.ToFormat() == "e6")
            {
                EditE6ItemViewModel editE6ItemViewModel = new EditE6ItemViewModel(dialogCoordinator, Quote, ItemE6s, ItemType.ItemE6);
                editE6ItemViewModel.OnItemsSavedRequested += OnItemE6Saved;
                windowService.EditItemsWndow(editE6ItemViewModel, "Edit VLS");
            }
            else if (itemsName.ToFormat() == "e7")
            {
                EditE7ItemViewModel editE7ItemViewModel = new EditE7ItemViewModel(dialogCoordinator, Quote, ItemE7s, ItemType.ItemE7);
                editE7ItemViewModel.OnItemsSavedRequested += OnItemE7Saved;
                windowService.EditItemsWndow(editE7ItemViewModel, "Edit KP");
            }

            else if (itemsName.ToFormat() == "f1")
            {
                EditF1ItemViewModel editF1ItemViewModel = new EditF1ItemViewModel(dialogCoordinator, Quote, ItemF1s, ItemType.ItemF1);
                editF1ItemViewModel.OnItemsSavedRequested += OnItemF1Saved;
                windowService.EditItemsWndow(editF1ItemViewModel, "Edit UV");
            }

            else if (itemsName.ToFormat() == "g1")
            {
                EditG1ItemViewModel editG1ItemViewModel = new EditG1ItemViewModel(dialogCoordinator, Quote, ItemG1s, ItemType.ItemG1);
                editG1ItemViewModel.OnItemsSavedRequested += OnItemG1Saved;
                windowService.EditItemsWndow(editG1ItemViewModel, "Edit Series 300");
            }
            else if (itemsName.ToFormat() == "g2")
            {
                EditG2ItemViewModel editG2ItemViewModel = new EditG2ItemViewModel(dialogCoordinator, Quote, ItemG2s, ItemType.ItemG2);
                editG2ItemViewModel.OnItemsSavedRequested += OnItemG2Saved;
                windowService.EditItemsWndow(editG2ItemViewModel, "Edit Series 1500");
            }
            else if (itemsName.ToFormat() == "g3")
            {
                EditG3ItemViewModel editG3ItemViewModel = new EditG3ItemViewModel(dialogCoordinator, Quote, ItemG3s, ItemType.ItemG3);
                editG3ItemViewModel.OnItemsSavedRequested += OnItemG3Saved;
                windowService.EditItemsWndow(editG3ItemViewModel, "Edit PT2");
            }
            else if (itemsName.ToFormat() == "g4")
            {
                EditG4ItemViewModel editG4ItemViewModel = new EditG4ItemViewModel(dialogCoordinator, Quote, ItemG4s, ItemType.ItemG4);
                editG4ItemViewModel.OnItemsSavedRequested += OnItemG4Saved;
                windowService.EditItemsWndow(editG4ItemViewModel, "Edit FXT");
            }
            else if (itemsName.ToFormat() == "g5")
            {
                EditG5ItemViewModel editG5ItemViewModel = new EditG5ItemViewModel(dialogCoordinator, Quote, ItemG5s, ItemType.ItemG5);
                editG5ItemViewModel.OnItemsSavedRequested += OnItemG5Saved;
                windowService.EditItemsWndow(editG5ItemViewModel, "Edit Series V (VT0 / VT1)");
            }
            else if (itemsName.ToFormat() == "g6")
            {
                EditG6ItemViewModel editG6ItemViewModel = new EditG6ItemViewModel(dialogCoordinator, Quote, ItemG6s, ItemType.ItemG6);
                editG6ItemViewModel.OnItemsSavedRequested += OnItemG6Saved;
                windowService.EditItemsWndow(editG6ItemViewModel, "Edit Low Profile Series V (VTL)");
            }

            else if (itemsName.ToFormat() == "h1")
            {
                EditH1ItemViewModel editH1ItemViewModel = new EditH1ItemViewModel(dialogCoordinator, Quote, ItemH1s, ItemType.ItemH1);
                editH1ItemViewModel.OnItemsSavedRequested += OnItemH1Saved;
                windowService.EditItemsWndow(editH1ItemViewModel, "Edit Series 300");
            }
            else if (itemsName.ToFormat() == "h2")
            {
                EditH2ItemViewModel editH2ItemViewModel = new EditH2ItemViewModel(dialogCoordinator, Quote, ItemH2s, ItemType.ItemH2);
                editH2ItemViewModel.OnItemsSavedRequested += OnItemH2Saved;
                windowService.EditItemsWndow(editH2ItemViewModel, "Edit Series 1500");
            }
            else if (itemsName.ToFormat() == "h3")
            {
                EditH3ItemViewModel editH3ItemViewModel = new EditH3ItemViewModel(dialogCoordinator, Quote, ItemH3s, ItemType.ItemH3);
                editH3ItemViewModel.OnItemsSavedRequested += OnItemH3Saved;
                windowService.EditItemsWndow(editH3ItemViewModel, "Edit PT2");
            }
            else if (itemsName.ToFormat() == "h4")
            {
                EditH4ItemViewModel editH4ItemViewModel = new EditH4ItemViewModel(dialogCoordinator, Quote, ItemH4s, ItemType.ItemH4);
                editH4ItemViewModel.OnItemsSavedRequested += OnItemH4Saved;
                windowService.EditItemsWndow(editH4ItemViewModel, "Edit FXT");
            }
            else if (itemsName.ToFormat() == "h5")
            {
                EditH5ItemViewModel editH5ItemViewModel = new EditH5ItemViewModel(dialogCoordinator, Quote, ItemH5s, ItemType.ItemH5);
                editH5ItemViewModel.OnItemsSavedRequested += OnItemH5Saved;
                windowService.EditItemsWndow(editH5ItemViewModel, "Edit Series V (VT0 / VT1)");
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

        private void OnItemD1Saved(IList<IItem> editedItems)
        {
            ItemD1s = editedItems.ToObservableCollection();
        }

        private void OnItemD2Saved(IList<IItem> editedItems)
        {
            ItemD2s = editedItems.ToObservableCollection();
        }

        private void OnItemE1Saved(IList<IItem> editedItems)
        {
            ItemE1s = editedItems.ToObservableCollection();
        }

        private void OnItemE2Saved(IList<IItem> editedItems)
        {
            ItemE2s = editedItems.ToObservableCollection();
        }

        private void OnItemE3Saved(IList<IItem> editedItems)
        {
            ItemE3s = editedItems.ToObservableCollection();
        }

        private void OnItemE4Saved(IList<IItem> editedItems)
        {
            ItemE4s = editedItems.ToObservableCollection();
        }

        private void OnItemE5Saved(IList<IItem> editedItems)
        {
            ItemE5s = editedItems.ToObservableCollection();
        }

        private void OnItemE6Saved(IList<IItem> editedItems)
        {
            ItemE6s = editedItems.ToObservableCollection();
        }

        private void OnItemE7Saved(IList<IItem> editedItems)
        {
            ItemE7s = editedItems.ToObservableCollection();
        }

        private void OnItemF1Saved(IList<IItem> editedItems)
        {
            ItemF1s = editedItems.ToObservableCollection();
        }

        private void OnItemG1Saved(IList<IItem> editedItems)
        {
            ItemG1s = editedItems.ToObservableCollection();
        }

        private void OnItemG2Saved(IList<IItem> editedItems)
        {
            ItemG2s = editedItems.ToObservableCollection();
        }

        private void OnItemG3Saved(IList<IItem> editedItems)
        {
            ItemG3s = editedItems.ToObservableCollection();
        }

        private void OnItemG4Saved(IList<IItem> editedItems)
        {
            ItemG4s = editedItems.ToObservableCollection();
        }

        private void OnItemG5Saved(IList<IItem> editedItems)
        {
            ItemG5s = editedItems.ToObservableCollection();
        }

        private void OnItemG6Saved(IList<IItem> editedItems)
        {
            ItemG6s = editedItems.ToObservableCollection();
        }

        private void OnItemH1Saved(IList<IItem> editedItems)
        {
            ItemH1s = editedItems.ToObservableCollection();
        }

        private void OnItemH2Saved(IList<IItem> editedItems)
        {
            ItemH2s = editedItems.ToObservableCollection();
        }

        private void OnItemH3Saved(IList<IItem> editedItems)
        {
            ItemH3s = editedItems.ToObservableCollection();
        }

        private void OnItemH4Saved(IList<IItem> editedItems)
        {
            ItemH4s = editedItems.ToObservableCollection();
        }

        private void OnItemH5Saved(IList<IItem> editedItems)
        {
            ItemH5s = editedItems.ToObservableCollection();
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

            currentItem.Titles = titles;

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

            return selectedItems;
        }

    }
}
