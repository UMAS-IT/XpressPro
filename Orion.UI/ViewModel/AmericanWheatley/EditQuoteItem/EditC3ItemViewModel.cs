﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem
{
    public class EditC3ItemViewModel : BindableBase
    {
        private MessageService messageService;
        private CatalogService catalogService;
        private ItemService itemService;

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

        private ObservableCollection<ICatalog> _catalogs;
        public ObservableCollection<ICatalog> Catalogs
        {
            get => _catalogs;
            set => SetProperty(ref _catalogs, value);
        }

        private ObservableCollection<ICatalog> _catalogsBase;
        public ObservableCollection<ICatalog> CatalogsBase
        {
            get => _catalogsBase;
            set => SetProperty(ref _catalogsBase, value);
        }

        private string _Model;
        public string Model
        {
            get => _Model;
            set => SetProperty(ref _Model, value);
        }

        private ItemType _itemType;
        public ItemType ItemType
        {
            get => _itemType;
            set => SetProperty(ref _itemType, value);
        }
        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }
        public RelayCommand ResetSearchCommand { get; set; }
        public RelayCommand<dynamic> BackCommand { get; set; }
        public RelayCommand<dynamic> SaveCommand { get; set; }
        public RelayCommand<IItem> RemoveItemCommand { get; set; }
        public RelayCommand<ICatalog> AddItemCommand { get; set; }

        public Action<IList<IItem>> OnItemsSavedRequested = delegate { };

        public EditC3ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, ItemType itemType)
        {
            Quote = quote;
            Items = items.Clone().ToObservableCollection();
            ItemType = itemType;
            LoadDataCommand = new RelayCommand(OnLoadData);
            BackCommand = new RelayCommand<dynamic>(OnBack);
            AddItemCommand = new RelayCommand<ICatalog>(OnAddItem);
            RemoveItemCommand = new RelayCommand<IItem>(OnRemoveItem);
            SaveCommand = new RelayCommand<dynamic>(OnSave);
            SearchCommand = new RelayCommand(OnSearch);
            ResetSearchCommand = new RelayCommand(OnResetSearch);

            messageService = new MessageService(dialogCoordinator, this);
            catalogService = new CatalogService();
            itemService = new ItemService();
        }

        private void OnResetSearch()
        {
            Catalogs = CatalogsBase;
        }

        private void OnSearch()
        {
            Catalogs = CatalogsBase.Where(x => x.Model.ToFormat().Contains(Model.ToFormat())).ToObservableCollection();
        }

        private async void OnSave(dynamic window)
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Saving items, please wait...");

                if (!await CanUpdateQuoteItems())
                    return;

                Items = itemService.UpdateItems(Quote, Items, ItemType).ToObservableCollection();

                await messageService.EndMessage("Quote Items", "Items has been saved");

                OnItemsSavedRequested(Items);
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }

            window.Close();
        }

        private async Task<bool> CanUpdateQuoteItems()
        {

            if (Items.Any(x => string.IsNullOrWhiteSpace(x.Tag)))
            {
                await messageService.ResultMessage("Error", "Some one tag is empty, please review this information");
                return false;
            }

            return true;
        }

        private void OnRemoveItem(IItem item)
        {
            if (item is null)
                return;

            Items.Remove(item);
            Items.ToList().ForEach(s => s.DesignIndex = Items.IndexOf(s));
        }

        private void OnAddItem(ICatalog catalog)
        {
            if (catalog is null)
                return;

            ItemC3 itemC3 = new ItemC3()
            {
                CatalogC3 = catalog as CatalogC3,
                CatalogC3Id = catalog.Id,
                ListPrice = catalog.ListPrice,
                SellPrice = catalog.SellPrice,
                Cost = catalog.Cost,
                SellMargin = catalog.SellMargin,
                CostMultiplier = catalog.CostMultiplier,
            };

            Items.Add(itemC3);
            Items.ToList().ForEach(s => s.DesignIndex = Items.IndexOf(s));
        }

        private void OnBack(dynamic window)
        {
            window.Close();
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Loading items, please wait...");

                Model = "";
                Catalogs = catalogService.GetCatalogs(ItemType).ToObservableCollection();
                CatalogsBase = Catalogs;

                await messageService.EndMessage("Quote Items", "Items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
