using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.Quantech;
using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel
{
    public class ItemViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private ProjectService projectService;
        private QuoteService quoteService;
        private MainWindowViewModel mw;
        WindowService windowService;
        private int projectId;
        private int quoteId;
        private readonly AirTreatmentViewModel airTreatmentViewModel = new AirTreatmentViewModel();


        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private BindableBase _titlesViewModel;
        public BindableBase TitlesViewModel
        {
            get => _titlesViewModel;
            set => SetProperty(ref _titlesViewModel, value);
        }

        private bool _titlesActive;
        public bool TitlesActive
        {
            get => _titlesActive;
            set => SetProperty(ref _titlesActive, value);
        }

        //private bool _productsActive;
        //public bool ProductsActive
        //{
        //    get => _productsActive;
        //    set => SetProperty(ref _productsActive, value);
        //}

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }

        private ObservableCollection<Title> _titles;
        public ObservableCollection<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }

        private ObservableCollection<IItem> _items;
        public ObservableCollection<IItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private ObservableCollection<IItem> _itemA1s;
        public ObservableCollection<IItem> ItemA1s
        {
            get => _itemA1s;
            set => SetProperty(ref _itemA1s, value);
        }

        private ObservableCollection<IItem> _itemA2s;
        public ObservableCollection<IItem> ItemA2s
        {
            get => _itemA2s;
            set => SetProperty(ref _itemA2s, value);
        }

        private ObservableCollection<IItem> _itemA3s;
        public ObservableCollection<IItem> ItemA3s
        {
            get => _itemA3s;
            set => SetProperty(ref _itemA3s, value);
        }

        private ObservableCollection<IItem> _itemA4s;
        public ObservableCollection<IItem> ItemA4s
        {
            get => _itemA4s;
            set => SetProperty(ref _itemA4s, value);
        }

        public RelayCommand BackToQuotesCommad { get; set; }
        public RelayCommand LoadDataCommand { get; set; }

        public RelayCommand ACommand { get; set; }
        public RelayCommand BCommand { get; set; }
        public RelayCommand CCommand { get; set; }


        public Action BackToQuotesRequested = delegate { };

        public ItemViewModel(IDialogCoordinator dialogCoordinator, int projectId, int quoteId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.projectId = projectId;
            this.quoteId = quoteId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand(OnLoadData);
            BackToQuotesCommad = new RelayCommand(OnBackToQuotes);

            ACommand = new RelayCommand(OnA);
            BCommand = new RelayCommand(OnB);
            CCommand = new RelayCommand(OnC);

            projectService = new ProjectService();
            quoteService = new QuoteService();
            messageService = new MessageService(dialogCoordinator, this);
            windowService = new WindowService();
        }

        private async void OnB()
        {
            //if (CurrentViewModel is AQuoteItemListViewModel)
            //    return;

            //ProductsActive = false;

            //CurrentViewModel = null;
            //await Task.Delay(100);

            //AQuoteItemListViewModel aQuoteItemListViewModel = new AQuoteItemListViewModel(dialogCoordinator, quoteId);

            //aQuoteItemListViewModel.ShowItemTitlesRequested += OnShowItemTitles;
            //aQuoteItemListViewModel.BackToProductsRequested += OnBackToProducts;

            //CurrentViewModel = aQuoteItemListViewModel;
        }

        private async void OnC()
        {
            //if (CurrentViewModel is AQuoteItemListViewModel)
            //    return;

            //ProductsActive = false;

            //CurrentViewModel = null;
            //await Task.Delay(100);

            //AQuoteItemListViewModel aQuoteItemListViewModel = new AQuoteItemListViewModel(dialogCoordinator, quoteId);

            //aQuoteItemListViewModel.ShowItemTitlesRequested += OnShowItemTitles;
            //aQuoteItemListViewModel.BackToProductsRequested += OnBackToProducts;

            //CurrentViewModel = aQuoteItemListViewModel;
        }

        private async void OnA()
        {
            if (CurrentViewModel is AQuoteItemListViewModel)
                return;

            //ProductsActive = false;

            CurrentViewModel = null;
            await Task.Delay(100);

            AQuoteItemListViewModel aQuoteItemListViewModel = new AQuoteItemListViewModel(dialogCoordinator, quoteId);

            aQuoteItemListViewModel.ShowItemTitlesRequested += OnShowItemTitles;
            //aQuoteItemListViewModel.BackToProductsRequested += OnBackToProducts;

            CurrentViewModel = aQuoteItemListViewModel;
        }

        //private async void OnBackToProducts()
        //{
        //    //ProductsActive = true;
        //    CurrentViewModel = null;
        //    await Task.Delay(100);
        //    CurrentViewModel = airTreatmentViewModel;
        //}

        private async void OnShowItemTitles(IItem item)
        {
            if (TitlesViewModel is TitleFromItemViewModel)
                return;

            TitlesActive = true;

            TitlesViewModel = null;
            await Task.Delay(100);

            TitleFromItemViewModel titleFromItemViewModel = new TitleFromItemViewModel(dialogCoordinator, item);

            titleFromItemViewModel.BackFromItemTitlesRequested += OnBackFromItemTitles;

            TitlesViewModel = titleFromItemViewModel;
        }

        private async void OnBackFromItemTitles()
        {
            TitlesActive = false;
            TitlesViewModel = null;
            await Task.Delay(100);
        }


        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Loading items, please wait...");

                //ProductsActive = true;
                Project = projectService.GetProjectById(projectId);
                Quote = quoteService.GetQuoteByQuoteId(quoteId);
                mw.Title = $@"XpressPro ({Project.Name} / {Quote.Name})";
                CurrentViewModel = airTreatmentViewModel;

                await messageService.EndMessage("Quote Items", "Items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnBackToQuotes()
        {
            BackToQuotesRequested();
        }
    }
}
