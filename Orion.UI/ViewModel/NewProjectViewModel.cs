using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel
{
    public class NewProjectViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        ProjectService projectService;
        UserService userService;
        private int userId;

        private bool _projectCreated;
        public bool ProjectCreated
        {
            get => _projectCreated;
            set => SetProperty(ref _projectCreated, value);
        }

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }

        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get => _users;
            set => SetProperty(ref _users, value);
        }

        private User _user;
        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public RelayCommand<object> LoadDataCommand { get; set; }
        public RelayCommand<dynamic> CreateProjectCommand { get; set; }
        public RelayCommand<object> CancelCommand { get; set; }

        public event Action<int, bool> ProjectCreatedRequested = delegate { };

        public NewProjectViewModel(IDialogCoordinator dialogCoordinator, int userId)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.userId = userId;

            LoadDataCommand = new RelayCommand<object>(OnLoadData);
            CreateProjectCommand = new RelayCommand<object>(OnCreateProject);
            CancelCommand = new RelayCommand<object>(OnCancel);

            messageService = new MessageService(dialogCoordinator, this);
            projectService = new ProjectService();
            userService = new UserService();
        }

        private async void OnLoadData(object obj)
        {
            try
            {
                await messageService.StartMessage($"Project Data", "Please wait...");

                ProjectCreated = false;
                Project = new Project();
                Project.Notes = "";

                Users = userService.GetUsers().ToObservableCollection();

                User = Users.FirstOrDefault(x => x.Id == userId);
                Project.User = Users.FirstOrDefault(x => x.Id == userId);

                await messageService.EndMessage($"Project Data", "Loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        private async void OnCreateProject(dynamic window)
        {
            if (!await CanCreateProject())
                return;

            try
            {
                await messageService.StartMessage($"Creating project {Project.Name}...");

                Project = await projectService.CreateProject(userId, Project);

                ProjectCreated = true;

                await messageService.EndMessage($"Project {Project.Name} created successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }

            ProjectCreatedRequested(Project.Id, ProjectCreated);
            window.Close();
        }

        private async Task<bool> CanCreateProject()
        {
            if (Project is null
                || string.IsNullOrWhiteSpace(Project.Name)
                )
            {
                await messageService.OkMessage("Error", "Please, verify and complete your input information");
                return false;
            }

            return true;
        }

        private void OnCancel(dynamic window)
        {
            window.Close();
        }
    }
}
