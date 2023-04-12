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
using System.Web.UI.WebControls;

namespace Orion.UI.ViewModel
{
    public class CloneQuoteViewModel : BindableBase
    {
        MessageService messageService;
        QuoteService quoteService;
        ItemService itemService;

        private Project project;

        private string _QuoteName;
        public string QuoteName
        {
            get => _QuoteName;
            set => SetProperty(ref _QuoteName, value);
        }

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }

        public RelayCommand CancelCommand { get; set; }
        public RelayCommand CloneQuoteCommand { get; set; }

        public Action<bool> QuoteClonedRequested = delegate { };

        public CloneQuoteViewModel(IDialogCoordinator dialogCoordinator, Project project, Quote quote)
        {
            this.project = project;
            this.Quote = quote;

            messageService = new MessageService(dialogCoordinator, this);
            quoteService = new QuoteService();
            itemService = new ItemService();

            CancelCommand = new RelayCommand(OnCancel);
            CloneQuoteCommand = new RelayCommand(OnCloneQuote);
        }

        private async void OnCloneQuote()
        {
            if (!await CanCloneQuote())
                return;

            try
            {
                await messageService.StartMessage($"Cloning Quote", "Please Wait");

                Quote newQuote = quoteService.CreateQuote(project.Id, QuoteName);

                itemService.CloneQuoteItems(Quote, newQuote);

                await messageService.EndMessage($"Quote Cloned");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }

            QuoteClonedRequested(true);
        }

        private async Task<bool> CanCloneQuote()
        {
            if (string.IsNullOrWhiteSpace(QuoteName))
            {
                await messageService.OkMessage("Error", "Quote Name is Empty");
                return false;
            }

            if (quoteService.QuoteInProjectExist(project.Id, QuoteName))
            {
                await messageService.OkMessage("Error", "This quote name already exist in this project");
                return false;
            }

            return true;
        }

        private void OnCancel()
        {
            QuoteClonedRequested(false);
        }
    }
}
