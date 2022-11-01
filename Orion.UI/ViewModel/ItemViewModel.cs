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
using Orion.Helper.Extension;
using System.Web.UI.WebControls;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemCatalog;
using System.Windows.Media.Media3D;

namespace Orion.UI.ViewModel
{
    public class ItemViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private ItemService itemService;
        private ProjectService projectService;
        private QuoteService quoteService;
        private TitleService titleService;
        private MainWindowViewModel mw;
        private int projectId;
        private int quoteId;

        private bool _itemTitlesActive;
        public bool ItemTitlesActive
        {
            get => _itemTitlesActive;
            set => SetProperty(ref _itemTitlesActive, value);
        }

        private IItemICatalog _itemIcatalogSelected;
        public IItemICatalog ItemICatalogSeleced
        {
            get => _itemIcatalogSelected;
            set => SetProperty(ref _itemIcatalogSelected, value);
        }

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

        private ObservableCollection<IItemICatalog> _itemICatalogs;
        public ObservableCollection<IItemICatalog> ItemICatalogs
        {
            get => _itemICatalogs;
            set => SetProperty(ref _itemICatalogs, value);
        }

        private ObservableCollection<IItemICatalog> _airCooledChillers;
        public ObservableCollection<IItemICatalog> AirCooledChillers
        {
            get => _airCooledChillers;
            set => SetProperty(ref _airCooledChillers, value);
        }

        private ObservableCollection<IItemICatalog> _units;
        public ObservableCollection<IItemICatalog> Units
        {
            get => _units;
            set => SetProperty(ref _units, value);
        }

        private ObservableCollection<IItemICatalog> _pumps;
        public ObservableCollection<IItemICatalog> Pumps
        {
            get => _pumps;
            set => SetProperty(ref _pumps, value);
        }

        private ObservableCollection<IItemICatalog> _vfds;
        public ObservableCollection<IItemICatalog> Vfds
        {
            get => _vfds;
            set => SetProperty(ref _vfds, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<IItem> EditItemsCommand { get; set; }

        public RelayCommand<IItemICatalog> MoveToStartCommand { get; set; }
        public RelayCommand<IItemICatalog> MoveToUpCommand { get; set; }
        public RelayCommand<IItemICatalog> DeleteItemCommand { get; set; }
        public RelayCommand<IItemICatalog> ShowItemTitlesCommand { get; set; }
        public RelayCommand<IItemICatalog> MoveToDownCommand { get; set; }
        public RelayCommand<IItemICatalog> MoveToEndCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }


        public RelayCommand AddTitleCommand { get; set; }
        public RelayCommand<Title> AddSpecCommand { get; set; }
        public RelayCommand<Title> DeleteTitleCommand { get; set; }
        public RelayCommand<Spec> DeleteSpecCommand { get; set; }
        public RelayCommand UpdateItemTitlesCommand { get; set; }
        public RelayCommand BackFromTitlesCommand { get; set; }

        public Action OnUpdateItemsRequested = delegate { };

        public ItemViewModel(IDialogCoordinator dialogCoordinator, int projectId, int quoteId, MainWindowViewModel mw)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.projectId = projectId;
            this.quoteId = quoteId;
            this.mw = mw;

            LoadDataCommand = new RelayCommand(OnLoadData);
            EditItemsCommand = new RelayCommand<IItem>(OnEditItems);

            MoveToStartCommand = new RelayCommand<IItemICatalog>(OnMoveToStart);
            MoveToUpCommand = new RelayCommand<IItemICatalog>(OnMoveToUp);
            DeleteItemCommand = new RelayCommand<IItemICatalog>(OnDeleteItem);
            ShowItemTitlesCommand = new RelayCommand<IItemICatalog>(OnShowItemTitles);
            MoveToDownCommand = new RelayCommand<IItemICatalog>(OnMoveToDown);
            MoveToEndCommand = new RelayCommand<IItemICatalog>(OnMoveToEnd);
            BackCommand = new RelayCommand(OnBack);

            AddTitleCommand = new RelayCommand(OnAddTitle);
            AddSpecCommand = new RelayCommand<Title>(OnAddSpec);
            DeleteTitleCommand = new RelayCommand<Title>(OnDeleteTitle);
            DeleteSpecCommand = new RelayCommand<Spec>(OnDeleteSpec);
            UpdateItemTitlesCommand = new RelayCommand(OnUpdateItemTitles);
            BackFromTitlesCommand = new RelayCommand(OnBackFromItemTitles);

            itemService = new ItemService();
            projectService = new ProjectService();
            quoteService = new QuoteService();
            titleService = new TitleService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnEditItems(IItem item)
        {
            if (item is ItemAirCooledChiller)
            {

            }
            else if (item is ItemUnit)
            {

            }
            else if (item is ItemPump)
            {

            }
            else if (item is ItemVfd)
            {

            }
        }

        private void OnDeleteTitle(Title title)
        {
            if (title is null)
                return;

            Titles.Remove(title);
        }

        private void OnDeleteSpec(Spec obj)
        {
            if (obj is null)
                return;

                int titleIndex = Titles.IndexOf(obj.Title);

            Title selectedTitle = Titles[titleIndex];

            selectedTitle.Specs.Remove(obj);
        }

        private void OnAddSpec(Title title)
        {
            title.Specs.Add(new Spec());
        }

        private void OnAddTitle()
        {
            Titles.Add(new Title());
        }

        private void OnBackFromItemTitles()
        {
            ItemTitlesActive = false;
        }

        private async void OnUpdateItemTitles()
        {
            try
            {
                await messageService.StartMessage("Item Specs", "Saving item specs, please wait...");


                if (!await CanUpdateTitles())
                    return;

                Titles = titleService.UpdateTitles(ItemICatalogSeleced, Titles).ToObservableCollection();

                await messageService.EndMessage("Item Specs", "Item specs has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        private async Task<bool> CanUpdateTitles()
        {
            if (Titles.Any(x => string.IsNullOrWhiteSpace(x.Name)))
            {
                await messageService.ResultMessage("Error", "Some titles name are empty, please review your titles information");
                return false;
            }

            if (Titles.SelectMany(x => x.Specs).Any(x => string.IsNullOrWhiteSpace(x.Name)))
            {
                await messageService.ResultMessage("Error", "Some specs name are empty, please review your specs information");
                return false;
            }

            return true;
        }

        private async void OnShowItemTitles(IItemICatalog itemICatalog)
        {
            if (itemICatalog is null)
                return;

            try
            {
                await messageService.StartMessage("Item Specs", "Loading item specs, please wait...");

                ItemTitlesActive = true;
                ItemICatalogSeleced = itemICatalog;
                Titles = titleService.GetTitles(itemICatalog).ToObservableCollection();

                await messageService.EndMessage("Item Specs", "Item specs has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnMoveToEnd(IItemICatalog itemICatalog)
        {
            if (itemICatalog is null)
                return;

            ObservableCollection<IItemICatalog> currentItemICatalogs = GetSelectedItemICatalogs(itemICatalog);
            
            int sectionIndex = currentItemICatalogs.IndexOf(itemICatalog);
            int lastIndex = currentItemICatalogs.IndexOf(currentItemICatalogs.Last());
            
            currentItemICatalogs.Move(sectionIndex, lastIndex);
            currentItemICatalogs.ToList().ForEach(s => s.DesignIndex = currentItemICatalogs.IndexOf(s));
        }

        private void OnMoveToDown(IItemICatalog itemICatalog)
        {
            if (itemICatalog is null)
                return;

            ObservableCollection<IItemICatalog> currentItemICatalogs = GetSelectedItemICatalogs(itemICatalog);

            int oldIndex = currentItemICatalogs.IndexOf(itemICatalog);
            int lastIndex = currentItemICatalogs.IndexOf(currentItemICatalogs.Last());

            if (oldIndex == lastIndex)
                return;

            currentItemICatalogs.Move(oldIndex, oldIndex + 1);
            currentItemICatalogs.ToList().ForEach(s => s.DesignIndex = currentItemICatalogs.IndexOf(s));
        }

        private void OnDeleteItem(IItemICatalog itemICatalog)
        {
            ObservableCollection<IItemICatalog> currentItemICatalogs = GetSelectedItemICatalogs(itemICatalog);

            currentItemICatalogs.Remove(itemICatalog);
            currentItemICatalogs.ToList().ForEach(s => s.DesignIndex = currentItemICatalogs.IndexOf(s));
        }

        private void OnMoveToUp(IItemICatalog itemICatalog)
        {
            if (itemICatalog is null)
                return;

            ObservableCollection<IItemICatalog> currentItemICatalogs = GetSelectedItemICatalogs(itemICatalog);
            
            int oldIndex = currentItemICatalogs.IndexOf(itemICatalog);
            
            if (oldIndex == 0)
                return;

            currentItemICatalogs.Move(oldIndex, oldIndex - 1);
            currentItemICatalogs.ToList().ForEach(s => s.DesignIndex = currentItemICatalogs.IndexOf(s));
        }

        private void OnMoveToStart(IItemICatalog itemICatalog)
        {
            if (itemICatalog is null)
                return;

            ObservableCollection<IItemICatalog> currentItemICatalogs= GetSelectedItemICatalogs(itemICatalog);
           
            int sectionIndex = currentItemICatalogs.IndexOf(itemICatalog);
            int firstIndex = currentItemICatalogs.IndexOf(currentItemICatalogs.First());
           
            currentItemICatalogs.Move(sectionIndex, firstIndex);
            currentItemICatalogs.ToList().ForEach(s => s.DesignIndex = currentItemICatalogs.IndexOf(s));
        }

        private ObservableCollection<IItemICatalog> GetSelectedItemICatalogs(IItemICatalog itemICatalog)
        {
            ObservableCollection<IItemICatalog> selectedItemICatalogs = null;

            if (itemICatalog is ItemAirCooledChillerCatalogAirCooledChiller)
                selectedItemICatalogs = AirCooledChillers;
            else if (itemICatalog is ItemUnitCatalogUnit)
                selectedItemICatalogs = Units;
            else if (itemICatalog is ItemPumpCatalogPump)
                selectedItemICatalogs = Pumps;
            else if (itemICatalog is ItemVfdCatalogVfd)
                selectedItemICatalogs = Vfds;
            return selectedItemICatalogs;
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Getting items belong to this quote, please wait...");


                Project = projectService.GetProjectById(projectId);
                Quote = quoteService.GetQuoteByQuoteId(quoteId);
                mw.Title = $@"XpressPro ({Project.Name} / {Quote.Name})";
                Titles = new ObservableCollection<Title>();
                ItemICatalogs = itemService.GetItemCatalogsByQuoteId(quoteId).ToObservableCollection();
                AirCooledChillers = ItemICatalogs.Where(x => x is ItemAirCooledChillerCatalogAirCooledChiller).ToObservableCollection();
                Units = ItemICatalogs.Where(x => x is ItemUnitCatalogUnit).ToObservableCollection();
                Pumps = ItemICatalogs.Where(x => x is ItemPumpCatalogPump).ToObservableCollection();
                Vfds = ItemICatalogs.Where(x => x is ItemVfdCatalogVfd).ToObservableCollection();

                await messageService.EndMessage("Quote Items", "Items belong to this unit have been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }


        }

        private void OnBack()
        {
            OnUpdateItemsRequested();
        }

        private async void OnUpdate(object obj)
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Saving current quote items configuration, please wait...");

                //Items = itemService.UpdateItems(Items, quoteId).ToObservableCollection();

                await messageService.EndMessage("Quote Items", "Quote items configuration saved successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
