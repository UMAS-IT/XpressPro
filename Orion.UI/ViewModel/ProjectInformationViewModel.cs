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
    public class ProjectInformationViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private ProjectService projectService;
        private UserService userService;
        private MainWindowViewModel mw;

        private int userId;
        private int projectId;

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }

        private ObservableCollection<User> _Users;
        public ObservableCollection<User> Users
        {
            get => _Users;
            set => SetProperty(ref _Users, value);
        }

        private User _user;
        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public RelayCommand<object> LoadDataCommand { get; set; }
        public RelayCommand<object> UpdateProjectInformationCommand { get; set; }

        public ProjectInformationViewModel(IDialogCoordinator dialogCoordinator, int userId, int projectId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.userId = userId;
            this.projectId = projectId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand<object>(OnLoadData);
            UpdateProjectInformationCommand = new RelayCommand<object>(OnUpdateProjectInformation);

            projectService = new ProjectService();
            userService = new UserService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private async void OnLoadData(object obj)
        {
            try
            {
                await messageService.StartMessage("Project Information", "Loading project data, please wait...");

                Project = projectService.GetProjectById(projectId);
                mw.Title = $@"XpressPro ({Project.Name})";

                Users = userService.GetUsers().ToObservableCollection();

                User = Users.FirstOrDefault(x => x.Id == userId);
                Project.User = Users.FirstOrDefault(x => x.Id == Project.User.Id);


                await messageService.EndMessage("Project Information", "Project information loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private async void OnUpdateProjectInformation(object obj)
        {
            if (!await CanUpdateProject())
                return;

            try
            {
                await messageService.StartMessage("Project Information", $"Saving {Project.Name} data, please wait...");

                Project = await projectService.UpdateProject(Project);

                await messageService.EndMessage("Project Information", $"Project {Project.Name} saved successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        private async Task<bool> CanUpdateProject()
        {
            if (Project is null
                || Project.User is null
                || string.IsNullOrWhiteSpace(Project.Name)
                || string.IsNullOrWhiteSpace(Project.Number.ToString()))
            {
                await messageService.OkMessage("Error", "Please, verify and complete your input information");
                return false;
            }

            if (await projectService.ProjectNumberExist(Project))
            {
                await messageService.OkMessage("Error", "This project already exists in the system");
                return false;
            }

            return true;
        }

    }
}
