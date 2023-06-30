using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Orion.UI.ViewModel
{
    public class LoginViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;

        private UserService userService;
        private MessageService messageService;

        private string _userName;
        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        private bool _userRequestLogOut;
        public bool UserRequestLogOut
        {
            get => _userRequestLogOut;
            set => SetProperty(ref _userRequestLogOut, value);
        }

        public RelayCommand<object> LoadDataCommand { get; set; }
        public RelayCommand<PasswordBox> SignInCommand { get; set; }
        public RelayCommand<dynamic> CloseCommand { get; set; }

        public event Action<User> MenuViewRequested = delegate { };

        public LoginViewModel(IDialogCoordinator dialogCoordinator)
        {
            this.dialogCoordinator = dialogCoordinator;

            LoadDataCommand = new RelayCommand<object>(OnLoadData);
            SignInCommand = new RelayCommand<PasswordBox>(OnSignInAsync);
            CloseCommand = new RelayCommand<dynamic>(OnClose);

            userService = new UserService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnLoadData(object obj)
        {
            UserName = "";
            UserName = "jcastaneda";
            OnSignInAsync(new PasswordBox() { Password = "1256" });
        }

        private void OnClose(dynamic window)
        {
            window.Close();
        }

        private User _user;
        public User User
        {
            get => _user;
            set
            {
                SetProperty(ref _user, value);
            }
        }

        private async void OnSignInAsync(PasswordBox passwordBox)
        {
            try
            {
                await messageService.StartMessage("Signing in", "Please Wait...");
                if (!await CanSignIn(passwordBox))
                    return;

                User = await userService.GetUserAsync(UserName, passwordBox.Password);

                await messageService.EndMessage($"Welcome {User.Name}");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }

            MenuViewRequested(User);
        }

        private async Task<bool> CanSignIn(PasswordBox passwordBox)
        {
            if (string.IsNullOrWhiteSpace(UserName)
                || string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                await messageService.ResultMessage("Signing in", "Error. Please, verify and complete your sign in information");
                return false;
            }

            if (!userService.UserExist(UserName, passwordBox.Password))
            {
                await messageService.ResultMessage("Signing in", "Invalid Credentials. Username or password incorrect");
                return false;
            }

            else
                return true;
        }
    }
}
