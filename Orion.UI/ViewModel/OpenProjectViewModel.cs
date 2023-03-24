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
    public class OpenProjectViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private ProjectService projectService;
        private int currentProjectId;
        //private bool currentProjectDeleted;
        //private int userId;

        private ObservableCollection<Project> _projects;
        public ObservableCollection<Project> Projects
        {
            get => _projects;
            set => SetProperty(ref _projects, value);
        }
        private ObservableCollection<Project> _projectsBase;
        public ObservableCollection<Project> ProjectsBase
        {
            get => _projectsBase;
            set => SetProperty(ref _projectsBase, value);
        }

        private Project _projectSelected;
        public Project ProjectSelected
        {
            get => _projectSelected;
            set => SetProperty(ref _projectSelected, value);
        }

        private string _projectName;
        public string ProjectName
        {
            get => _projectName;
            set => SetProperty(ref _projectName, value);
        }

        private User _user;
        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public RelayCommand<dynamic> LoadDataCommand { get; set; }
        public RelayCommand<dynamic> OpenProjectCommand { get; set; }
        public RelayCommand<object> DeleteProjectCommand { get; set; }
        public RelayCommand<object> SearchCommand { get; set; }
        public RelayCommand<object> ResetSearchCommand { get; set; }
        public RelayCommand<object> ReloadCommand { get; set; }
        public RelayCommand<dynamic> CloseCommand { get; set; }

        public event Action<int> ProjectOpenedRequested = delegate { };
        public event Action<bool> ProjectDeletedRequested = delegate { };

        public OpenProjectViewModel(IDialogCoordinator dialogCoordinator, int currentProjectId, User user)
        {
            this.currentProjectId = currentProjectId;
            this.dialogCoordinator = dialogCoordinator;
            User = user;
            LoadDataCommand = new RelayCommand<dynamic>(OnLoadData);
            OpenProjectCommand = new RelayCommand<dynamic>(OnOpenProject);
            DeleteProjectCommand = new RelayCommand<object>(OnDeleteProject);
            SearchCommand = new RelayCommand<object>(OnSearch);
            ResetSearchCommand = new RelayCommand<object>(OnResetSearch);
            ReloadCommand = new RelayCommand<object>(OnReload);
            CloseCommand = new RelayCommand<dynamic>(OnClose);

            projectService = new ProjectService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnClose(dynamic window)
        {
            //if (currentProjectDeleted)
            //    ProjectDeletedRequested(currentProjectDeleted);
            window.Close();
        }

        private async void OnLoadData(dynamic window)
        {
            try
            {
                await messageService.StartMessage("Project Information", "Loading projects from your database, please wait...");

                ProjectName = "";
                //ProjectsBase = projectService.GetProjects();
                ProjectsBase = projectService.GetProjectByUserId(User).ToObservableCollection();
                Projects = ProjectsBase;

                await messageService.EndMessage("Project Information", "Project(s) loaded successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnOpenProject(dynamic window)
        {
            if (ProjectSelected == null)
                return;
            ProjectOpenedRequested(ProjectSelected.Id);
            window.Close();
        }

        private async void OnDeleteProject(object obj)
        {
            if (ProjectSelected == null)
                return;



            if (await dialogCoordinator.ShowMessageAsync(this, "Project Information", $"Are you sure to delete this project?", MessageDialogStyle.AffirmativeAndNegative) == MessageDialogResult.Affirmative)
            {
                //if (!currentProjectDeleted)
                //    currentProjectDeleted = currentProjectId == ProjectSelected.Id;

                int projectId = ProjectSelected.Id;
                Projects = Projects.Where(x => x.Id != projectId).ToObservableCollection();
                ProjectsBase = ProjectsBase.Where(x => x.Id != projectId).ToObservableCollection();
                await projectService.DeleteProject(projectId);

                if (projectId == currentProjectId)
                    ProjectDeletedRequested(true);
            }
        }

        private void OnSearch(object obj)
        {
            Projects = ProjectsBase.Where(x => x.Name.ToFormat().Contains(ProjectName.ToFormat())).ToObservableCollection();
            Projects = Projects.OrderBy(x => x.Number).ToObservableCollection();
        }

        private void AllProjects()
        {
            Projects = ProjectsBase;
        }

        private void OnResetSearch(object obj)
        {
            ProjectName = "";
            AllProjects();
        }

        private async void OnReload(object obj)
        {
            try
            {
                await messageService.StartMessage("Project Information", "Reloading projects from your database, please wait...");

                ProjectName = "";
                ProjectsBase = projectService.GetProjectByUserId(User).ToObservableCollection();
                Projects = ProjectsBase.OrderBy(x => x.Id).ToObservableCollection();

                await messageService.EndMessage("Project Information", "Project(s) reloaded successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
