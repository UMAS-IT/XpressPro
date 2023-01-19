using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Quantech.CatalogList
{
    public class CatalogA3ListViewModel : BindableBase, ICatalogListViewModel
    {
        IDialogCoordinator dialogCoordinator;
        MessageService messageService;
        CatalogService catalogService;

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

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand SearchCommand { get; set; }
        public RelayCommand ResetSearchCommand { get; set; }
        public RelayCommand AddCatalogItemCommand { get; set; }
        public RelayCommand<ICatalog> EditCatalogItemCommand { get; set; }
        public RelayCommand<ICatalog> EditCatalogTitlesCommand { get; set; }
        public RelayCommand BackToProductsCommand { get; set; }

        public Action BackToProductsRequested { get; set; } = delegate { };
        public Action<ICatalog> OnEditCatalogItemRequested { get; set; } = delegate { };
        public Action<ICatalog> OnEditCatalogTitlesRequested { get; set; } = delegate { };

        public CatalogA3ListViewModel(IDialogCoordinator dialogCoordinator)
        {
            this.dialogCoordinator = dialogCoordinator;

            LoadDataCommand = new RelayCommand(OnLoadData);
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

            OnEditCatalogItemRequested(catalog);
        }

        private void OnAddCatalogItem()
        {
            ICatalog catalog = null;
            OnEditCatalogItemRequested(catalog);
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Catalog Items", "Loading catalog items, please wait...");

                Model = "";
                CatalogsBase = catalogService.GetCatalogA3s().OrderByDescending(x => x.Id).ToObservableCollection();
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

        private void OnSearch()
        {
            Catalogs = CatalogsBase.Where(x => x.Model.ToFormat().Contains(Model.ToFormat())).ToObservableCollection();
        }
    }
}
