using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.Quantech.CatalogList;
using Orion.UI.ViewModel.Quantech.EditCatalogItem;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Orion.UI.ViewModel
{
    public class CatalogViewModel : BindableBase
    {
        private AirTreatmentViewModel airTreatmentViewModel = new AirTreatmentViewModel();
        MessageService messageService;
        private MainWindowViewModel mw;
        IDialogCoordinator dialogCoordinator;

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private BindableBase _editViewModel;
        public BindableBase EditViewModel
        {
            get => _editViewModel;
            set => SetProperty(ref _editViewModel, value);
        }

        private bool _productsActive;
        public bool ProductsActive
        {
            get => _productsActive;
            set => SetProperty(ref _productsActive, value);
        }

        private bool _editActive;
        public bool EditActive
        {
            get => _editActive;
            set => SetProperty(ref _editActive, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand CatalogA1Command { get; set; }
        public RelayCommand CatalogA2Command { get; set; }
        public RelayCommand CatalogA3Command { get; set; }
        public RelayCommand CatalogA4Command { get; set; }


        public CatalogViewModel(IDialogCoordinator dialogCoordinator, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.mw = mw;

            LoadDataCommand = new RelayCommand(OnLoadData);
            CatalogA1Command = new RelayCommand(OnCatalogA1);
            CatalogA2Command = new RelayCommand(OnCatalogA2);
            CatalogA3Command = new RelayCommand(OnCatalogA3);
            CatalogA4Command = new RelayCommand(OnCatalogA4);

            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnEditCatalogItem(ICatalog catalog)
        {
            EditActive = true;

            if (CurrentViewModel is CatalogA1ListViewModel)
            {
                EditA1CatalogViewModel viewModel = new EditA1CatalogViewModel(dialogCoordinator, catalog);
                viewModel.BackFromEditRequested += OnBackFromEdit;
                viewModel.BackFromEditItemSavedRequested += OnBackFromEditItemSaved;
                EditViewModel = viewModel;
            }
            else if (CurrentViewModel is CatalogA2ListViewModel)
            {
                EditA2CatalogViewModel viewModel = new EditA2CatalogViewModel(dialogCoordinator, catalog);
                viewModel.BackFromEditRequested += OnBackFromEdit;
                viewModel.BackFromEditItemSavedRequested += OnBackFromEditItemSaved;
                EditViewModel = viewModel;
            }
            else if (CurrentViewModel is CatalogA3ListViewModel)
            {
                EditA3CatalogViewModel viewModel = new EditA3CatalogViewModel(dialogCoordinator, catalog);
                viewModel.BackFromEditRequested += OnBackFromEdit;
                viewModel.BackFromEditItemSavedRequested += OnBackFromEditItemSaved;
                EditViewModel = viewModel;
            }
            else if (CurrentViewModel is CatalogA4ListViewModel)
            {
                EditA4CatalogViewModel viewModel = new EditA4CatalogViewModel(dialogCoordinator, catalog);
                viewModel.BackFromEditRequested += OnBackFromEdit;
                viewModel.BackFromEditItemSavedRequested += OnBackFromEditItemSaved;
                EditViewModel = viewModel;
            }

        }

        private void OnBackFromEditItemSaved(ICatalog catalog, bool isUpdated)
        {
            ICatalogListViewModel viewModel = null;

            if (CurrentViewModel is CatalogA1ListViewModel)
            {
                viewModel = CurrentViewModel as CatalogA1ListViewModel;
            }
            else if (CurrentViewModel is CatalogA2ListViewModel)
            {
                viewModel = CurrentViewModel as CatalogA2ListViewModel;
            }
            else if (CurrentViewModel is CatalogA3ListViewModel)
            {
                viewModel = CurrentViewModel as CatalogA3ListViewModel;
            }
            else if (CurrentViewModel is CatalogA4ListViewModel)
            {
                viewModel = CurrentViewModel as CatalogA4ListViewModel;
            }

            if (isUpdated)
            {
                    int index = viewModel.Catalogs.ToList().FindIndex(s => s.Id == catalog.Id);

                    if (index != -1)
                        viewModel.Catalogs[index] = catalog;
            }
            else
            {
                viewModel.Catalogs.Add(catalog);
                int sectionIndex = viewModel.Catalogs.IndexOf(catalog);
                int firstIndex = 0;
                viewModel.Catalogs.Move(sectionIndex, firstIndex);
            }

            OnBackFromEdit();
        }

        private async void OnCatalogA1()
        {
            if (CurrentViewModel is CatalogA1ListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            ProductsActive = false;

            CatalogA1ListViewModel catalogA1ListViewModel = new CatalogA1ListViewModel(dialogCoordinator);
            catalogA1ListViewModel.BackToProductsRequested += OnBackToProducts;
            catalogA1ListViewModel.OnEditCatalogTitlesRequested += OnEditCatalogTitles;
            catalogA1ListViewModel.OnEditCatalogItemRequested += OnEditCatalogItem;

            CurrentViewModel = catalogA1ListViewModel;
        }

        private async void OnCatalogA2()
        {
            if (CurrentViewModel is CatalogA2ListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            ProductsActive = false;

            CatalogA2ListViewModel catalogA2ListViewModel = new CatalogA2ListViewModel(dialogCoordinator);
            catalogA2ListViewModel.BackToProductsRequested += OnBackToProducts;
            catalogA2ListViewModel.OnEditCatalogTitlesRequested += OnEditCatalogTitles;
            catalogA2ListViewModel.OnEditCatalogItemRequested += OnEditCatalogItem;

            CurrentViewModel = catalogA2ListViewModel;
        }

        private async void OnCatalogA3()
        {
            if (CurrentViewModel is CatalogA3ListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            ProductsActive = false;

            CatalogA3ListViewModel catalogA3ListViewModel = new CatalogA3ListViewModel(dialogCoordinator);
            catalogA3ListViewModel.BackToProductsRequested += OnBackToProducts;
            catalogA3ListViewModel.OnEditCatalogTitlesRequested += OnEditCatalogTitles;
            catalogA3ListViewModel.OnEditCatalogItemRequested += OnEditCatalogItem;

            CurrentViewModel = catalogA3ListViewModel;
        }

        private async void OnCatalogA4()
        {
            if (CurrentViewModel is CatalogA4ListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            ProductsActive = false;

            CatalogA4ListViewModel catalogA4ListViewModel = new CatalogA4ListViewModel(dialogCoordinator);
            catalogA4ListViewModel.BackToProductsRequested += OnBackToProducts;
            catalogA4ListViewModel.OnEditCatalogTitlesRequested += OnEditCatalogTitles;
            catalogA4ListViewModel.OnEditCatalogItemRequested += OnEditCatalogItem;

            CurrentViewModel = catalogA4ListViewModel;
        }

        private void OnLoadData()
        {
            ProductsActive = true;
                mw.Title = "XpressPro";
            CurrentViewModel = airTreatmentViewModel;
        }

        private void OnEditCatalogTitles(ICatalog catalog)
        {
            EditActive = true;

            TitleViewModel titleViewModel = new TitleViewModel(dialogCoordinator, catalog);
            titleViewModel.BackRequested += OnBackFromEdit;

            EditViewModel = titleViewModel;
        }

        private async void OnBackToProducts()
        {
            ProductsActive = true;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = airTreatmentViewModel;
        }

        private async void OnBackFromEdit()
        {
            EditActive = false;
            EditViewModel = null;
            await Task.Delay(100);
        }

    }
}
