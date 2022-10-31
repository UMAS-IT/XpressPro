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

        private ObservableCollection<IItemICatalog> _itemICatalogsRemoved;
        public ObservableCollection<IItemICatalog> ItemICatalogsRemoved
        {
            get => _itemICatalogsRemoved;
            set => SetProperty(ref _itemICatalogsRemoved, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand AddItemAirCooledChillerCommand { get; set; }
        public RelayCommand AddItemPumpCommand { get; set; }
        public RelayCommand AddItemUnitCommand { get; set; }
        public RelayCommand AddItemVfdCommand { get; set; }

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
            AddItemAirCooledChillerCommand = new RelayCommand(OnAddItemAirCooledChiller);
            AddItemPumpCommand = new RelayCommand(OnAddItemPump);
            AddItemUnitCommand = new RelayCommand(OnAddItemUnit);
            AddItemVfdCommand = new RelayCommand(OnAddItemVdf);

            MoveToStartCommand = new RelayCommand<IItemICatalog>(OnMoveToStart);
            MoveToUpCommand = new RelayCommand<IItemICatalog>(OnMoveToUp);
            DeleteItemCommand = new RelayCommand<IItemICatalog>(OnDeleteItem);
            ShowItemTitlesCommand = new RelayCommand<IItemICatalog>(OnShowItemTitles);
            MoveToDownCommand = new RelayCommand<IItemICatalog>(OnMoveToDown);
            MoveToEndCommand = new RelayCommand<IItemICatalog>(OnMoveToEnd);
            BackCommand = new RelayCommand(OnBack);

            AddTitleCommand = new RelayCommand(OnAddTitle);
            AddSpecCommand = new RelayCommand<Title>(OnAddSpec);
            UpdateItemTitlesCommand = new RelayCommand(OnUpdateItemTitles);
            BackFromTitlesCommand = new RelayCommand(OnBackFromItemTitles);

            itemService = new ItemService();
            projectService = new ProjectService();
            quoteService = new QuoteService();
            titleService = new TitleService();
            messageService = new MessageService(dialogCoordinator, this);
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

        private async void OnShowItemTitles(IItemICatalog item)
        {
            if (item is null)
                return;

            try
            {
                await messageService.StartMessage("Item Specs", "Loading item specs, please wait...");

                ItemTitlesActive = true;
                ItemICatalogSeleced = item;
                Titles = titleService.GetTitles(item).ToObservableCollection();

                await messageService.EndMessage("Item Specs", "Item specs has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnMoveToEnd(IItemICatalog obj)
        {
            throw new NotImplementedException();
        }

        private void OnMoveToDown(IItemICatalog obj)
        {
            throw new NotImplementedException();
        }

        private void OnDeleteItem(IItemICatalog obj)
        {
            throw new NotImplementedException();
        }

        private void OnMoveToUp(IItemICatalog obj)
        {
            throw new NotImplementedException();
        }

        private void OnMoveToStart(IItemICatalog obj)
        {
            throw new NotImplementedException();
        }

        private void OnAddItemVdf()
        {
            throw new NotImplementedException();
        }

        private void OnAddItemUnit()
        {
            throw new NotImplementedException();
        }

        private void OnAddItemPump()
        {
            throw new NotImplementedException();
        }

        private void OnAddItemAirCooledChiller()
        {
            throw new NotImplementedException();
        }

        private void OnEditItem(IItem item)
        {
            throw new NotImplementedException();
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Quote Items", "Getting items belong to this quote, please wait...");

                ItemICatalogsRemoved = new ObservableCollection<IItemICatalog>();

                Project = projectService.GetProjectById(projectId);
                Quote = quoteService.GetQuoteByQuoteId(quoteId);
                mw.Title = $@"XpressPro ({Project.Name} / {Quote.Name})";
                Titles = new ObservableCollection<Title>();
                ItemICatalogsRemoved = new ObservableCollection<IItemICatalog>();

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
                ItemICatalogsRemoved.Clear();

                await messageService.EndMessage("Quote Items", "Quote items configuration saved successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
