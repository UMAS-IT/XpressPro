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
    public class MenuViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private int userId;
        private int projectId;
        private MainWindowViewModel mw;

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        public RelayCommand<object> LoadDataCommand { get; set; }
        public RelayCommand<string> NavCommand { get; set; }

        public MenuViewModel(IDialogCoordinator dialogCoordinator, int userId, int projectId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.userId = userId;
            this.projectId = projectId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand<object>(OnLoadData);
            NavCommand = new RelayCommand<string>(OnNav);
        }

        private void OnLoadData(object obj)
        {
            OnNav("Project Information");
        }

        private async void OnNav(string destination)
        {
            //este delay es para que CurrentViewModel sea completamete nulo(10 || 100)
            CurrentViewModel = null;
            await Task.Delay(10);

            switch (destination)
            {
                case "Project Information":
                    CurrentViewModel = new ProjectInformationViewModel(dialogCoordinator, userId, projectId, mw);
                    break;
                case "Quotes":
                    CurrentViewModel = new QuoteViewModel(dialogCoordinator, userId, projectId, mw);
                    break;
                case "Catalogs":
                    CurrentViewModel = new CatalogViewModel(dialogCoordinator,  mw);
                    break;
                case "Reports":
                    //CurrentViewModel = new ReportsViewModel(dialogCoordinator, userId, projectId, mw);
                    CurrentViewModel = new ComingSoonViewModel();

                    break;
                default:
                    CurrentViewModel = new ComingSoonViewModel();
                    break;
            }
        }
    }
}
