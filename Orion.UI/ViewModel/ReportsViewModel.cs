using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.Report.Pricing;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Orion.UI.ViewModel
{
    public class ReportsViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private QuoteService quoteService;
        private ProjectService projectService;
        //private SectionService sectionService;
        UserService userService;
        private PricingReport pricingReport;
        private MainWindowViewModel mw;

        private int userId;
        private int projectId;


        private bool _allReportsSelected;
        public bool AllReportsSelected
        {
            get => _allReportsSelected;
            set => SetProperty(ref _allReportsSelected, value);
        }

        private bool _pricingSelected;
        public bool PricingSelected
        {
            get => _pricingSelected;
            set => SetProperty(ref _pricingSelected, value);
        }

        private bool _allUnitTagsSelected;
        public bool AllUnitTagsSelected
        {
            get => _allUnitTagsSelected;
            set => SetProperty(ref _allUnitTagsSelected, value);
        }

        private ObservableCollection<Quote> _quotes;
        public ObservableCollection<Quote> Quotes
        {
            get => _quotes;
            set => SetProperty(ref _quotes, value);
        }

        private User _user;
        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        private Project _porject;
        public Project Project
        {
            get => _porject;
            set => SetProperty(ref _porject, value);
        }

        public RelayCommand<object> LoadDataCommand { get; set; }
        public RelayCommand<object> SingleReportSelectedCommand { get; set; }
        public RelayCommand<object> SingleUnitTagSelectedCommand { get; set; }
        public RelayCommand<object> AllReportsSelectedCommand { get; set; }
        public RelayCommand<object> AllUnitTagsSelectedCommand { get; set; }
        public RelayCommand<object> CreateReportsCommand { get; set; }

        public ReportsViewModel(IDialogCoordinator dialogCoordinator, int userId, int projectId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.userId = userId;
            this.projectId = projectId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand<object>(OnLoadData);
            SingleReportSelectedCommand = new RelayCommand<object>(OnSingleReportSelected);
            SingleUnitTagSelectedCommand = new RelayCommand<object>(OnSingleUnitTagSelected);
            AllReportsSelectedCommand = new RelayCommand<object>(OnAllReportsSelected);
            AllUnitTagsSelectedCommand = new RelayCommand<object>(OnAllUnitTagsSelected);
            CreateReportsCommand = new RelayCommand<object>(OnCreateReports);

            messageService = new MessageService(dialogCoordinator, this);
            quoteService = new QuoteService();
            projectService = new ProjectService();
            pricingReport = new PricingReport();
            userService = new UserService();
        }

        private async void OnCreateReports(object obj)
        {
            if (!PricingSelected || Quotes.All(x => !x.IsSelected))
                return;
            try
            {
                await messageService.StartMessage("Creating Report(s)", "This will take a few minutes, please wait...");

                pricingReport.Create(Project, Quotes); 
                //report = new Report(projectId, sectionService, projectService, Units, SubmittalSelected, PricingSelected, WeightSelected, CadDrawingSelected, User);

                await messageService.EndMessage("Reports done");
                await messageService.OkMessage("Reports", "Report(s) created successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnAllReportsSelected(object obj)
        {
            PricingSelected = AllReportsSelected;
        }

        private void OnSingleReportSelected(object obj)
        {
            if (PricingSelected)
            {
                AllReportsSelected = true;
            }
            else
            {
                AllReportsSelected = false;
            }
        }

        private void OnSingleUnitTagSelected(object obj)
        {
            if (Quotes.Where(x => x.CanCreateReports).All(x => x.IsSelected))
            {
                AllUnitTagsSelected = true;
            }
            else if (Quotes.Where(x => x.CanCreateReports).Any(x => !x.IsSelected))
            {
                AllUnitTagsSelected = false;
            }
        }

        private void OnAllUnitTagsSelected(object obj)
        {
            Quotes.ToList().ForEach(x => x.IsSelected = AllUnitTagsSelected == x.CanCreateReports && x.CanCreateReports);
        }

        private async void OnLoadData(object obj)
        {
            try
            {
                await messageService.StartMessage("Loading...");

                User = await userService.GetUserAsync(userId);

                Project = projectService.GetProjectById(projectId);

                Quotes = quoteService.GetQuotesForReportsByProjectId(projectId).ToObservableCollection();

                mw.Title = $"ENIGMA ({projectService.GetProjectById(projectId).Name})";

                await messageService.EndMessage("Loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
