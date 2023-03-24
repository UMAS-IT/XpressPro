using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.DataBase;
using Orion.Domain.Entity;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Orion.UI.ViewModel
{
    public class MainWindowViewModel : BindableBase
    {
        private readonly static IDialogCoordinator dialogCoordinator = DialogCoordinator.Instance;
        private readonly LoginViewModel _loginViewModel = new LoginViewModel(dialogCoordinator);
        private readonly AirTreatmentViewModel umasViewModel = new AirTreatmentViewModel();
        private WindowService windowService = new WindowService();
        private int userId;
        private int currentProjectId;

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }


        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private Visibility _userVisibility;
        public Visibility UserVisibility
        {
            get => _userVisibility;
            set => SetProperty(ref _userVisibility, value);
        }

        private string _userName;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private User _user;
        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<object> LogOutCommand { get; set; }
        public RelayCommand<object> NewProjectCommand { get; set; }
        public RelayCommand<object> OpenProjectCommand { get; set; }

        public RelayCommand<object> ConfigurationCommand { get; set; }

        public MainWindowViewModel()
        {
            //UserName = "";
            Title = "XpressPro";
            UserVisibility = Visibility.Collapsed;

            CurrentViewModel = _loginViewModel;
            _loginViewModel.MenuViewRequested += NavToMainPage;
            LogOutCommand = new RelayCommand<object>(OnLogOut);

            LoadDataCommand = new RelayCommand(OnLoadData);
            NewProjectCommand = new RelayCommand<object>(OnNewProject);
            OpenProjectCommand = new RelayCommand<object>(OnOpenProject);
            ConfigurationCommand = new RelayCommand<object>(OnConfiguration);
        }

        private async void OnConfiguration(object obj)
        {
            if (User.Permission == null || !User.Permission.CanEditCatalogs)
            {
                await dialogCoordinator.ShowMessageAsync(this, "Warning", "Unauthorized user", MessageDialogStyle.Affirmative);
                return;
            }

            ConfigurationMenuViewModel configurationMenuViewModel = new ConfigurationMenuViewModel(dialogCoordinator);
            windowService.ConfigurationMenuWindow(configurationMenuViewModel, "Configuration");
        }

        private void OnLoadData()
        {
            //bool isLocalVersion = true;
            //GV.SetResourceTarget(isLocalVersion);
        }

        private void OnNewProject(object obj)
        {
            NewProjectViewModel newProjectViewModel = new NewProjectViewModel(dialogCoordinator, userId);
            newProjectViewModel.ProjectCreatedRequested += OnProjectCreated;
            windowService.NewProjectWindow(newProjectViewModel, "New Project");
        }

        private async void OnProjectCreated(int projectId, bool projectCreeated)
        {
            this.currentProjectId = projectId;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = new MenuViewModel(dialogCoordinator, userId, projectId, this);
        }

        private void OnOpenProject(object obj)
        {
            OpenProjectViewModel openProjectViewModel = new OpenProjectViewModel(dialogCoordinator, currentProjectId, User);
            openProjectViewModel.ProjectOpenedRequested += OnProjectOpened;
            openProjectViewModel.ProjectDeletedRequested += OnCurrentProjectDeleted;
            windowService.OpenProjectWindow(openProjectViewModel, "Open Project");
        }

        private async void OnCurrentProjectDeleted(bool currentProjectDeleted)
        {
            this.currentProjectId = 0;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = umasViewModel;
        }

        private async void OnProjectOpened(int projectId)
        {
            this.currentProjectId = projectId;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = new MenuViewModel(dialogCoordinator, userId, projectId, this);
        }

        private async void NavToMainPage(User user)
        {
            User = user;
            userId = User.Id;
            UserName = User.Name;
            UserVisibility = Visibility.Visible;

            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = umasViewModel;
        }

        private void OnLogOut(object obj)
        {
            Title = "XpressPro";
            _loginViewModel.UserRequestLogOut = true;
            UserVisibility = Visibility.Collapsed;
            CurrentViewModel = _loginViewModel;
        }
    }
}
