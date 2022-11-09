using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.Domain.EntityCatalogQuantech;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.Quantech.CatalogList;
using System.Threading.Tasks;

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

        private async void OnCatalogA1()
        {
            if (CurrentViewModel is CatalogA1ListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            ProductsActive = false;

            CatalogA1ListViewModel catalogA1ListViewModel = new CatalogA1ListViewModel(dialogCoordinator);
            catalogA1ListViewModel.BackRequested += OnBackToProducts;

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
            catalogA2ListViewModel.BackRequested += OnBackToProducts;

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
            catalogA3ListViewModel.BackRequested += OnBackToProducts;

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
            catalogA4ListViewModel.BackRequested += OnBackToProducts;

            CurrentViewModel = catalogA4ListViewModel;
        }

        private async void OnBackToProducts()
        {
            ProductsActive = true;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = airTreatmentViewModel;
        }

        private void OnLoadData()
        {
            ProductsActive = true;
                mw.Title = "XpressPro";
            CurrentViewModel = airTreatmentViewModel;
        }
    }
}
