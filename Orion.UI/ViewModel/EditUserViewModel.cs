using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
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
    public class EditUserViewModel : BindableBase
    {
        private ConfigurationMenuViewModel vm;

        private UserService userService;
        private MessageService messageService;
        private bool isUpdated;

        private User _user;

        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand BackFromEditCommand { get; set; }
        public RelayCommand UpdateUserCommand { get; set; }

        public Action OnBackFromEditRequested = delegate { };
        public Action<User, bool> OnBackFromEditUserSavedRequested = delegate { };

        public EditUserViewModel(IDialogCoordinator dialogCoordinator, User user)
        {
            User = user;

            LoadDataCommand = new RelayCommand(OnLoadData);
            BackFromEditCommand = new RelayCommand(OnBackFromEdit);
            UpdateUserCommand = new RelayCommand(OnUpdateUser);

            userService = new UserService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private async void OnUpdateUser()
        {
            try
            {
                await messageService.StartMessage("User", "Saving user data, please wait...");

                if (!await CanUpdate())
                    return;

                User = userService.UpdateUser(User);

                await messageService.EndMessage("Users", "User data has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
            OnBackFromEditUserSavedRequested(User, isUpdated);
        }

        private void OnBackFromEdit()
        {
            OnBackFromEditRequested();
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Loading User", "Please Wait...");

                if (User == null || User.Id == 0)
                {
                    User = new User();
                    isUpdated = false;
                }
                else
                {
                    User = userService.GetUser(User);
                    isUpdated = true;
                }

                await messageService.EndMessage($"User Loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        private async Task<bool> CanUpdate()
        {
            if (string.IsNullOrWhiteSpace(User.Name)
                || string.IsNullOrWhiteSpace(User.LoginName)
                || string.IsNullOrWhiteSpace(User.PassKey)
                || string.IsNullOrWhiteSpace(User.Email)
                || string.IsNullOrWhiteSpace(User.Telephone)
                )
            {
                await messageService.ResultMessage("Error", "Please verify and complete your input information");
                return false;
            }

            if (userService.LoginNameExist(User))
            {
                await messageService.ResultMessage("Error", "This user login name already exist, please type another different");
                return false;
            }

            return true;
        }
    }
}
