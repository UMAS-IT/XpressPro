using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.ABB.CatalogList;
using Orion.UI.ViewModel.ABB.EditCatalogItem;
using Orion.UI.ViewModel.Quantech.CatalogList;
using Orion.UI.ViewModel.Quantech.EditCatalogItem;
using System;
using System.ComponentModel;
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

        public RelayCommand<string> OpenCatalogCommand { get; set; }


        public CatalogViewModel(IDialogCoordinator dialogCoordinator, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.mw = mw;

            LoadDataCommand = new RelayCommand(OnLoadData);
            OpenCatalogCommand = new RelayCommand<string>(OnOpenCatalog);

            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnEditCatalogItem(ICatalog catalog)
        {
            EditActive = true;

            IEditCatalogViewModel viewModel = null;

            if (CurrentViewModel is CatalogA1ListViewModel)
                viewModel = new EditA1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogA2ListViewModel)
                viewModel = new EditA2CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogA3ListViewModel)
                viewModel = new EditA3CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogA4ListViewModel)
                viewModel = new EditA4CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB1ListViewModel)
                viewModel = new EditB1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB2ListViewModel)
                viewModel = new EditB2CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB3ListViewModel)
                viewModel = new EditB3CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB4ListViewModel)
                viewModel = new EditB4CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB5ListViewModel)
                viewModel = new EditB5CatalogViewModel(dialogCoordinator, catalog);

            viewModel.BackFromEditRequested += OnBackFromEdit;
            viewModel.BackFromEditItemSavedRequested += OnBackFromEditItemSaved;
            EditViewModel = (BindableBase)viewModel;

        }

        private void OnBackFromEditItemSaved(ICatalog catalog, bool isUpdated)
        {
            ICatalogListViewModel viewModel = null;

            if (CurrentViewModel is CatalogA1ListViewModel)
                viewModel = CurrentViewModel as CatalogA1ListViewModel;
            else if (CurrentViewModel is CatalogA2ListViewModel)
                viewModel = CurrentViewModel as CatalogA2ListViewModel;
            else if (CurrentViewModel is CatalogA3ListViewModel)
                viewModel = CurrentViewModel as CatalogA3ListViewModel;
            else if (CurrentViewModel is CatalogA4ListViewModel)
                viewModel = CurrentViewModel as CatalogA4ListViewModel;
            else if (CurrentViewModel is CatalogB1ListViewModel)
                viewModel = CurrentViewModel as CatalogB1ListViewModel;
            else if (CurrentViewModel is CatalogB2ListViewModel)
                viewModel = CurrentViewModel as CatalogB2ListViewModel;
            else if (CurrentViewModel is CatalogB3ListViewModel)
                viewModel = CurrentViewModel as CatalogB3ListViewModel;
            else if (CurrentViewModel is CatalogB4ListViewModel)
                viewModel = CurrentViewModel as CatalogB4ListViewModel;
            else if (CurrentViewModel is CatalogB5ListViewModel)
                viewModel = CurrentViewModel as CatalogB5ListViewModel;

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

        private async void OnOpenCatalog(string catalogName)
        {
            CurrentViewModel = null;
            await Task.Delay(100);
            ProductsActive = false;

            catalogName = catalogName.ToFormat();

            ICatalogListViewModel viewModel = null;

            if (catalogName == "a1")
                viewModel = new CatalogA1ListViewModel(dialogCoordinator);
            else if (catalogName == "a2")
                viewModel = new CatalogA2ListViewModel(dialogCoordinator);
            else if (catalogName == "a3")
                viewModel = new CatalogA3ListViewModel(dialogCoordinator);
            else if (catalogName == "a4")
                viewModel = new CatalogA4ListViewModel(dialogCoordinator);
            else if (catalogName == "b1")
                viewModel = new CatalogB1ListViewModel(dialogCoordinator);
            else if (catalogName == "b2")
                viewModel = new CatalogB2ListViewModel(dialogCoordinator);
            else if (catalogName == "b3")
                viewModel = new CatalogB3ListViewModel(dialogCoordinator);
            else if (catalogName == "b4")
                viewModel = new CatalogB4ListViewModel(dialogCoordinator);
            else if (catalogName == "b5")
                viewModel = new CatalogB5ListViewModel(dialogCoordinator);

            if (viewModel != null)
            {
                viewModel.BackToProductsRequested += OnBackToProducts;
                viewModel.OnEditCatalogTitlesRequested += OnEditCatalogTitles;
                viewModel.OnEditCatalogItemRequested += OnEditCatalogItem;

                CurrentViewModel = (BindableBase)viewModel;
            }
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
