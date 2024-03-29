﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
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

namespace Orion.UI.ViewModel
{
    public class MasterCatalogListViewModel : BindableBase, ICatalogListViewModel
    {
        public IDialogCoordinator dialogCoordinator;
        public MessageService messageService;
        public CatalogService catalogService;

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

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }
        private ItemType _itemType;
        public ItemType ItemType
        {
            get => _itemType;
            set => SetProperty(ref _itemType, value);
        }

        private string _productName;
        public string ProductName
        {
            get => _productName;
            set => SetProperty(ref _productName, value);
        }

        public AsyncRelayCommand LoadDataCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }
        public RelayCommand ResetSearchCommand { get; set; }
        public RelayCommand AddCatalogItemCommand { get; set; }
        public RelayCommand<ICatalog> EditCatalogItemCommand { get; set; }
        public RelayCommand<ICatalog> EditCatalogTitlesCommand { get; set; }
        public RelayCommand BackToProductsCommand { get; set; }

        public Action BackToProductsRequested { get; set; } = delegate { };
        public Action<ICatalog, ItemType> OnEditCatalogItemRequested { get; set; } = delegate { };
        public Action<ICatalog> OnEditCatalogTitlesRequested { get; set; } = delegate { };

        public MasterCatalogListViewModel(IDialogCoordinator dialogCoordinator, ItemType itemType)
        {
            this.dialogCoordinator = dialogCoordinator;
            ItemType = itemType;
            LoadDataCommand = new AsyncRelayCommand(OnLoadData);
            SearchCommand = new RelayCommand(OnSearch);
            ResetSearchCommand = new RelayCommand(OnResetSearch);
            AddCatalogItemCommand = new RelayCommand(OnAddCatalogItem);
            EditCatalogItemCommand = new RelayCommand<ICatalog>(OnEditCatalogItem);
            EditCatalogTitlesCommand = new RelayCommand<ICatalog>(OnEditCatalogTitles);
            BackToProductsCommand = new RelayCommand(OnBackToProducts);

            catalogService = new CatalogService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnBackToProducts()
        {
            BackToProductsRequested();
        }

        private void OnEditCatalogTitles(ICatalog catalog)
        {
            if (catalog == null)
                return;

            OnEditCatalogTitlesRequested(catalog);
        }

        private void OnEditCatalogItem(ICatalog catalog)
        {
            if (catalog == null)
                return;

            OnEditCatalogItemRequested(catalog, ItemType);
        }

        private void OnAddCatalogItem()
        {
            ICatalog catalog = null;
            OnEditCatalogItemRequested(catalog, ItemType);
        }

        public virtual async Task OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Catalog Items", "Loading catalog items, please wait...");

                Model = "";
                CatalogsBase = catalogService.GetCatalogs(ItemType).OrderByDescending(x => x.Id).ToObservableCollection();
                ProductName = catalogService.GetProductName(ItemType);

                if (CatalogsBase.Any(x => x is CatalogB1))
                    CatalogsBase = CatalogsBase.Cast<CatalogB1>().OrderBy(x => x.Hp).ToList<ICatalog>().ToObservableCollection();
               
                Catalogs = CatalogsBase;

                await messageService.EndMessage("Catalog Items", "Catalog items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnResetSearch()
        {
            Catalogs = CatalogsBase;
            Model = "";
        }

        public virtual void OnSearch()
        {
            Catalogs = CatalogsBase.Where(x => x.Model.ToFormat().Contains(Model.ToFormat())).ToObservableCollection();
        }
    }
}
