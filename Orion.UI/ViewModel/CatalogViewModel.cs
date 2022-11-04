using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.CatalogListViewModel;
using System;
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

        private bool _menuVisible;
        public bool MenuVisible
        {
            get => _menuVisible;
            set => SetProperty(ref _menuVisible, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand CatalogAirCooledChillerCommand { get; set; }
        public RelayCommand CatalogPumpCommand { get; set; }
        public RelayCommand CatalogUnitCommand { get; set; }
        public RelayCommand CatalogVfdCommand { get; set; }


        public CatalogViewModel(IDialogCoordinator dialogCoordinator, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.mw = mw;

            LoadDataCommand = new RelayCommand(OnLoadData);
            CatalogAirCooledChillerCommand = new RelayCommand(OnCatalogAirCooledChiller);
            CatalogPumpCommand = new RelayCommand(OnCatalogPump);
            CatalogUnitCommand = new RelayCommand(OnCatalogUnit);
            CatalogVfdCommand = new RelayCommand(OnCatalogVfd);

            messageService = new MessageService(dialogCoordinator, this);
        }

        private async void OnCatalogPump()
        {
            if (CurrentViewModel is CatalogPumpListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            MenuVisible = false;

            CatalogPumpListViewModel catalogPumpListViewModel = new CatalogPumpListViewModel(dialogCoordinator);
            catalogPumpListViewModel.BackRequested += OnBack;

            CurrentViewModel = catalogPumpListViewModel;
        }

        private async void OnCatalogUnit()
        {
            if (CurrentViewModel is CatalogUnitListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            MenuVisible = false;

            CatalogUnitListViewModel catalogUnitListViewModel = new CatalogUnitListViewModel(dialogCoordinator);
            catalogUnitListViewModel.BackRequested += OnBack;

            CurrentViewModel = catalogUnitListViewModel;
        }

        private async void OnCatalogVfd()
        {
            if (CurrentViewModel is CatalogVfdListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            MenuVisible = false;

            CatalogVfdListViewModel catalogVfdListViewModel = new CatalogVfdListViewModel(dialogCoordinator);
            catalogVfdListViewModel.BackRequested += OnBack;

            CurrentViewModel = catalogVfdListViewModel;
        }

        private async void OnCatalogAirCooledChiller()
        {
            if (CurrentViewModel is CatalogAirCooledChillerListViewModel)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);
            MenuVisible = false;

            CatalogAirCooledChillerListViewModel catalogAirCooledChillerListViewModel = new CatalogAirCooledChillerListViewModel(dialogCoordinator);
            catalogAirCooledChillerListViewModel.BackRequested += OnBack;

            CurrentViewModel = catalogAirCooledChillerListViewModel;
        }

        private async void OnBack()
        {
            MenuVisible = true;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = airTreatmentViewModel;
        }

        private void OnLoadData()
        {
            MenuVisible = true;
                mw.Title = "XpressPro";
            CurrentViewModel = airTreatmentViewModel;
        }
    }
}
