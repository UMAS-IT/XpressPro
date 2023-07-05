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
    public class UserListViewModel : BindableBase
    {
        IDialogCoordinator dialogCoordinator;

        private UserService userService;
        private MessageService messageService;

        private ObservableCollection<User> _users;

        public ObservableCollection<User> Users
        {
            get => _users;
            set => SetProperty(ref _users, value);
        }

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private User _selectedUser;

        public User SelectedUser
        {
            get => _selectedUser;
            set => SetProperty(ref _selectedUser, value);
        }

        private bool _isActive;
        public bool IsActive
        {
            get => _isActive;
            set => SetProperty(ref _isActive, value);
        }

        public RelayCommand LoadDataCommad { get; set; }
        public RelayCommand EditUserCommand { get; set; }
        public RelayCommand AddUserCommand { get; set; }


        public UserListViewModel(IDialogCoordinator dialogCoordinator)
        {
            this.dialogCoordinator = dialogCoordinator;

            LoadDataCommad = new RelayCommand(OnLoadData);
            EditUserCommand = new RelayCommand(OnEditUser);
            AddUserCommand = new RelayCommand(OnAddUser);

            userService = new UserService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private async void OnAddUser()
        {
            IsActive = true;

            CurrentViewModel = null;
            await Task.Delay(100);

            EditUserViewModel editUserViewModel = new EditUserViewModel(dialogCoordinator, null);
            editUserViewModel.OnBackFromEditRequested += OnBackFromEditUser;
            editUserViewModel.OnBackFromEditUserSavedRequested += OnBackFromEditUserSaved;
            CurrentViewModel = editUserViewModel;
        }

        private void OnBackFromEditUserSaved(User user, bool isUpdated)
        {
            if (isUpdated)
            {
                int index = Users.ToList().FindIndex(s => s.Id == user.Id);

                if (index != -1)
                    Users[index] = user;
            }
            else
            {
                Users.Add(user);
                int sectionIndex = Users.IndexOf(user);
                int firstIndex = 0;
                Users.Move(sectionIndex, firstIndex);
            }
            IsActive = false;
        }

        private void OnBackFromEditUser()
        {
            IsActive = false;
        }

        private async void OnEditUser()
        {
            if (SelectedUser == null)
                return;

            CurrentViewModel = null;
            await Task.Delay(100);

            IsActive = true;
            EditUserViewModel editUserViewModel = new EditUserViewModel(dialogCoordinator,SelectedUser);
            editUserViewModel.OnBackFromEditRequested += OnBackFromEditUser;
            editUserViewModel.OnBackFromEditUserSavedRequested += OnBackFromEditUserSaved;
            CurrentViewModel = editUserViewModel;
        }

        public async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Loading Users", "Please Wait...");

                Users = userService.GetUsers().ToObservableCollection();
                IsActive = false;

                await messageService.EndMessage($"Users Loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }
    }
}
