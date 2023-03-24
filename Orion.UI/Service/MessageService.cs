using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.Service
{
    public class MessageService
    {
        private IDialogCoordinator dialogCoordinator;
        private object dataContext;
        private ProgressDialogController controller;
        private MessageDialogResult dialogResult;

        public MessageService(IDialogCoordinator dialogCoordinator, object dataContext)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.dataContext = dataContext;
        }

        public async Task StartMessage(string title, string message = "")
        {
            controller = await dialogCoordinator.ShowProgressAsync(dataContext, title, message);
            await Task.Delay(250);
        }

        public async Task ExceptionMessage(Exception ex)
        {
            await controller.CloseAsync();
            controller = await dialogCoordinator.ShowProgressAsync(dataContext, "Error", "Please contact your system administrator \n" + ex.Message);
            await Task.Delay(3000);
            await controller.CloseAsync();
        }

        public async Task EndMessage(string title, string message = "")
        {
            controller.SetTitle(title);
            controller.SetMessage(message);
            //await Task.Delay(1000); original
            await Task.Delay(500);
            await controller.CloseAsync();
        }

        public async Task<bool> CancelMessage(string title, string message)
        {
            dialogResult = await dialogCoordinator.ShowMessageAsync(dataContext, title, message, MessageDialogStyle.AffirmativeAndNegative);
            return dialogResult == MessageDialogResult.Affirmative;
        }

        public async Task OkMessage(string title, string message)
        {
            await dialogCoordinator.ShowMessageAsync(dataContext, title, message, MessageDialogStyle.Affirmative);
        }


        public async Task ResultMessage(string title, string message)
        {
            controller.SetMessage(String.Empty);
            controller.SetTitle(String.Empty);
            await dialogCoordinator.ShowMessageAsync(dataContext, title, message, MessageDialogStyle.Affirmative);
            await Task.Delay(250);
            await controller.CloseAsync();
        }
    }
}
