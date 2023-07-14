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
    public class ExportProjectViewModel : BindableBase
    {
        private MessageService messageService;
        private ProjectService projectService;
        private UserService userService;
        private QuoteService quoteService;
        private ItemService itemService;

        IDialogCoordinator dialogCoordinator;
        int selectedProjectId;
        int userId;

        private Project _selectedProject;
        public Project SelectedProject
        {
            get => _selectedProject;
            set => SetProperty(ref _selectedProject, value);
        }

        private Project _newProject;
        public Project NewProject
        {
            get => _newProject;
            set => SetProperty(ref _newProject, value);
        }

        private ObservableCollection<User> _users;
        public ObservableCollection<User> Users
        {
            get => _users;
            set => SetProperty(ref _users, value);
        }

        private User _selectedUser;
        public User SelectedUser
        {
            get => _selectedUser;
            set => SetProperty(ref _selectedUser, value);
        }


        private string _projectName;
        public string ProjectName
        {
            get => _projectName;
            set => SetProperty(ref _projectName, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand ExportProjectCommand { get; set; }
        public RelayCommand BackFromExportProjectCommand { get; set; }

        public Action BackFromExportProjectRequested = delegate { };
        public Action<Project> ExportProjectRequested = delegate { };

        public ExportProjectViewModel(IDialogCoordinator dialogCoordinator, int userId, int selectedProjectId)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.selectedProjectId = selectedProjectId;
            this.userId = userId;

            LoadDataCommand = new RelayCommand(OnLoadData);
            BackFromExportProjectCommand = new RelayCommand(OnBackFromExportProject);
            ExportProjectCommand = new RelayCommand(OnExportProject);

            projectService = new ProjectService();
            userService = new UserService();
            quoteService = new QuoteService();
            itemService = new ItemService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private async void OnExportProject()
        {
            try
            {
                await messageService.StartMessage("Project Export", "Exporting project, please wait...");

                if (!await CanUpdate())
                    return;

                NewProject = await projectService.CloneProject(SelectedProject.Id, SelectedUser.Id, ProjectName);

                foreach (Quote quote in SelectedProject.Quotes)
                {
                    Quote newQuote = quoteService.CreateQuote(NewProject.Id, quote.Name);

                    itemService.CloneQuoteItems(quote,newQuote);
                }

                await messageService.EndMessage("Project Export", "Project exported successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
            ExportProjectRequested(NewProject);
        }

        private async Task<bool> CanUpdate()
        {
            if (string.IsNullOrWhiteSpace(ProjectName)
                || SelectedUser == null)
            {
                await messageService.ResultMessage("Error", "Please verify and complete your input information");
                return false;
            }

            if (projectService.ProjectNameExist(ProjectName))
            {
                await messageService.ResultMessage("Error", "This project name already exist, please type another different");
                return false;
            }

            return true;
        }

        private void OnBackFromExportProject()
        {
            BackFromExportProjectRequested();
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Project Export", "Loading project, please wait...");

                SelectedProject = projectService.GetProjectById(selectedProjectId);
                ProjectName = SelectedProject.Name;
                Users = userService.GetUsers().ToObservableCollection();
                
                User currentUser = Users.FirstOrDefault(x => x.Id == userId);
                Users.Remove(currentUser);

                await messageService.EndMessage("Project Export", "Project loaded successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
