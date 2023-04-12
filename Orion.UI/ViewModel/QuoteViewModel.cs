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
    public class QuoteViewModel : BindableBase
    {
        private readonly AirTreatmentViewModel airTreatmentViewModel = new AirTreatmentViewModel();
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private QuoteService quoteService;
        private int userId;
        private int projectId;
        private MainWindowViewModel mw;

        private ObservableCollection<Quote> _quotes;
        public ObservableCollection<Quote> Quotes
        {
            get => _quotes;
            set => SetProperty(ref _quotes, value);
        }

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private bool _isVisible;
        public bool IsVisible
        {
            get => _isVisible;
            set => SetProperty(ref _isVisible, value);
        }

        private bool _isEnabled;
        public bool IsEnabled
        {
            get => _isEnabled;
            set => SetProperty(ref _isEnabled, value);
        }

        private Quote _quoteSelected;
        public Quote QuoteSelected
        {
            get => _quoteSelected;
            set => SetProperty(ref _quoteSelected, value);
        }

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }

        public RelayCommand<object> LoadDataCommand { get; set; }
        public RelayCommand CreateQuoteCommand { get; set; }
        public RelayCommand<Quote> DeleteQuoteCommand { get; set; }
        public RelayCommand<Quote> CloneQuoteCommand { get; set; }
        public RelayCommand<Quote> LoadQuoteCommand { get; set; }

        public QuoteViewModel(IDialogCoordinator dialogCoordinator, int userId, int projectId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.userId = userId;
            this.projectId = projectId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand<object>(OnLoadData);
            CreateQuoteCommand = new RelayCommand(OnCreateQuote);
            DeleteQuoteCommand = new RelayCommand<Quote>(OnDeleteQuote);
            CloneQuoteCommand = new RelayCommand<Quote>(OnCloneQuote);
            LoadQuoteCommand = new RelayCommand<Quote>(OnLoadQuote);

            messageService = new MessageService(dialogCoordinator, this);
            quoteService = new QuoteService();
        }

        private async void OnLoadData(object obj)
        {
            try
            {
                await messageService.StartMessage("Project Information", "Loading related quotes to this project");

                IsVisible = true;
                IsEnabled = true;
                Quotes = quoteService.GetQuotesByProjectId(projectId).ToObservableCollection();
                Project = new ProjectService().GetProjectById(projectId);
                mw.Title = $@"XpressPro ({Project.Name})";
                CurrentViewModel = airTreatmentViewModel;
                await messageService.EndMessage("Project Information", "Quote(s) has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private async void OnCreateQuote()
        {
            CurrentViewModel = null;
            await Task.Delay(100);
            IsEnabled = false;

            CreateQuoteViewModel createQuoteViewModel = new CreateQuoteViewModel(dialogCoordinator, projectId);
            createQuoteViewModel.QuoteCreatedRequested += OnQuoteCreated;
            CurrentViewModel = createQuoteViewModel;
        }

        private async void OnQuoteCreated(bool unitTagCreated)
        {
            IsEnabled = true;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = airTreatmentViewModel;

            if (unitTagCreated)
                OnLoadData(null);
        }

        private async void OnDeleteQuote(Quote quote)
        {
            if (quote == null)
                return;

            if (await dialogCoordinator.ShowMessageAsync(this, "Delete Quote", $"Are you sure to perform this action ?", MessageDialogStyle.AffirmativeAndNegative) == MessageDialogResult.Affirmative)
            {
                try
                {
                    await messageService.StartMessage("Deleting Quote");

                    await quoteService.DeleteQuoteAsync(quote.Id);
                    Quotes = quoteService.GetQuotesByProjectId(projectId).ToObservableCollection();

                    await messageService.EndMessage("Quote Deleted");
                }
                catch (Exception ex)
                {
                    await messageService.ExceptionMessage(ex);
                }
            }
        }

        private async void OnCloneQuote(Quote quote)
        {
            if (quote == null)
                return;

            IsEnabled = false;
            CurrentViewModel = null;
            await Task.Delay(100);

            CloneQuoteViewModel cloneQuoteViewModel = new CloneQuoteViewModel(dialogCoordinator, Project, quote);
            cloneQuoteViewModel.QuoteClonedRequested += OnQuoteCloned;
            CurrentViewModel = cloneQuoteViewModel;
        }

        private async void OnQuoteCloned(bool quoteCloned)
        {
            IsEnabled = true;
            CurrentViewModel = null;
            await Task.Delay(100);

            if (quoteCloned)
                OnLoadData(null);
        }

        private async void OnLoadQuote(Quote quote)
        {
            if (quote == null)
                return;

            IsEnabled = false;
            IsVisible = false;
            CurrentViewModel = null;
            await Task.Delay(100);

            ItemViewModel itemViewModel = new ItemViewModel(dialogCoordinator, projectId, quote.Id, mw);
            itemViewModel.BackToQuotesRequested += OkBackToQuote;
            CurrentViewModel = itemViewModel;
        }

        private async void OkBackToQuote()
        {
            mw.Title = $@"XpressPro ({Project.Name})";
            IsVisible = true;
            IsEnabled = true;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = airTreatmentViewModel;
        }
    }
}
