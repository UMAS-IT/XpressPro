using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel
{
    public class CreateQuoteViewModel : BindableBase
    {
        private MessageService messageService;
        private IDialogCoordinator dialogCoordinator;
        private QuoteService quoteService;
        private int projectId;

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }

        public RelayCommand<object> LoadDataCommand { get; set; }
        public RelayCommand<object> CreateQuoteCommand { get; set; }
        public RelayCommand<object> CancelCommand { get; set; }

        public Action<bool> QuoteCreatedRequested = delegate { };

        public CreateQuoteViewModel(IDialogCoordinator dialogCoordinator, int projectId)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.projectId = projectId;

            LoadDataCommand = new RelayCommand<object>(OnLoadData);
            CreateQuoteCommand = new RelayCommand<object>(OnCreateQuote);
            CancelCommand = new RelayCommand<object>(OnCancel);

            messageService = new MessageService(dialogCoordinator, this);
            quoteService = new QuoteService();
        }

        private  void OnLoadData(object obj)
        {
            Quote = new Quote();
        }


        private async void OnCreateQuote(object obj)
        {
            if (!await CanCreateQuote())
                return;

            try
            {
                await messageService.StartMessage($"Creating Quote {Quote.Name}");

                await quoteService.CreateQuoteAsync(projectId, Quote);

                await messageService.EndMessage($"Quote {Quote.Name} created");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }

            QuoteCreatedRequested(true);
        }

        private void OnCancel(object obj)
        {
            QuoteCreatedRequested(false);
        }

        private async Task<bool> CanCreateQuote()
        {
            if (Quote is null
                || string.IsNullOrWhiteSpace(Quote.Name))
            {
                await messageService.OkMessage("Error", "Please verify and complete your input information");
                return false;
            }

            if (quoteService.QuoteInProjectExist(projectId, Quote.Name))
            {
                await messageService.OkMessage("Error", "This quote name already exist in this project");
                return false;
            }

            return true;
        }

    }
}
