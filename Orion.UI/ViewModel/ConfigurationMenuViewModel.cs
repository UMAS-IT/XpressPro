using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.UI.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel
{
    public class ConfigurationMenuViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        public RelayCommand<object> LoadDataCommand { get; set; }
        public RelayCommand<string> NavCommand { get; set; }

        public ConfigurationMenuViewModel(IDialogCoordinator dialogCoordinator)
        {
            this.dialogCoordinator = dialogCoordinator;

            LoadDataCommand = new RelayCommand<object>(OnLoadData);
            NavCommand = new RelayCommand<string>(OnNav);
        }

        private void OnLoadData(object obj)
        {
            OnNav("Catalogs");
        }

        private async void OnNav(string destination)
        {
            //este delay es para que CurrentViewModel sea completamete nulo(10 || 100)
            CurrentViewModel = null;
            await Task.Delay(10);

            switch (destination)
            {
                case "Catalogs":
                    CurrentViewModel = new CatalogViewModel(dialogCoordinator);
                    break;
                case "Data Sheets":
                    CurrentViewModel = new DataSheetListViewModel(dialogCoordinator);
                    break;
                default:
                    CurrentViewModel = new ComingSoonViewModel();
                    break;
            }
        }
    }
}
