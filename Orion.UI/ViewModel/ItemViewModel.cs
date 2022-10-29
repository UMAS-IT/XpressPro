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

namespace Orion.UI.ViewModel
{
    public class ItemViewModel : BindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        private ItemService itemService;
        private ProjectService projectService;
        private QuoteService quoteService;
        private MainWindowViewModel mw;
        private int projectId;
        private int quoteId;

        private bool _needUpdate;
        public bool NeedUpdate
        {
            get => _needUpdate;
            set => SetProperty(ref _needUpdate, value);
        }

        private IItem _item;
        public IItem Item
        {
            get => _item;
            set => SetProperty(ref _item, value);
        }

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }

        //private ObservableCollection<IItemICatalog> _itemICatalogs;
        //public ObservableCollection<IItemICatalog> ItemICatalogs
        //{
        //    get => _itemICatalogs;
        //    set => SetProperty(ref _itemICatalogs, value);
        //}

        private ObservableCollection<IItemICatalog> _itemICatalogsRemoved;
        public ObservableCollection<IItemICatalog> ItemICatalogsRemoved
        {
            get => _itemICatalogsRemoved;
            set => SetProperty(ref _itemICatalogsRemoved, value);
        }

        //private ObservableCollection<IItemICatalog> _airCooledChillers;
        //public ObservableCollection<IItemICatalog> AirCooledChillers
        //{
        //    get => _airCooledChillers;
        //    set => SetProperty(ref _airCooledChillers, value);
        //}

        //private ObservableCollection<IItemICatalog> _units;
        //public ObservableCollection<IItemICatalog> Units
        //{
        //    get => _units;
        //    set => SetProperty(ref _units, value);
        //}

        //private ObservableCollection<IItemICatalog> _pumps;
        //public ObservableCollection<IItemICatalog> Pumps
        //{
        //    get => _pumps;
        //    set => SetProperty(ref _pumps, value);
        //}

        //private ObservableCollection<IItemICatalog> _vfds;
        //public ObservableCollection<IItemICatalog> Vfds
        //{
        //    get => _vfds;
        //    set => SetProperty(ref _vfds, value);
        //}

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand AddItemAirCooledChillerCommand { get; set; }
        public RelayCommand AddItemPumpCommand { get; set; }
        public RelayCommand AddItemUnitCommand { get; set; }
        public RelayCommand AddItemVfdCommand { get; set; }

        public RelayCommand<IItem> EditItemCommand { get; set; }
        public RelayCommand<IItem> MoveToStartCommand { get; set; }
        public RelayCommand<IItem> MoveToUpCommand { get; set; }
        public RelayCommand<IItem> DeleteItemCommand { get; set; }
        public RelayCommand<IItem> MoveToDownCommand { get; set; }
        public RelayCommand<IItem> MoveToEndCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public RelayCommand UpdateCommand { get; set; }

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
            EditItemCommand = new RelayCommand<IItem>(OnEditItem);
            MoveToStartCommand = new RelayCommand<IItem>(OnMoveToStart);
            MoveToUpCommand = new RelayCommand<IItem>(OnMoveToUp);
            DeleteItemCommand = new RelayCommand<IItem>(OnDeleteItem);
            MoveToDownCommand = new RelayCommand<IItem>(OnMoveToDown);
            MoveToEndCommand = new RelayCommand<IItem>(OnMoveToEnd);
            BackCommand = new RelayCommand(OnBack);

            itemService = new ItemService();
            projectService = new ProjectService();
            quoteService = new QuoteService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnMoveToEnd(IItem obj)
        {
            throw new NotImplementedException();
        }

        private void OnMoveToDown(IItem obj)
        {
            throw new NotImplementedException();
        }

        private void OnDeleteItem(IItem obj)
        {
            throw new NotImplementedException();
        }

        private void OnMoveToUp(IItem obj)
        {
            throw new NotImplementedException();
        }

        private void OnMoveToStart(IItem obj)
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

                NeedUpdate = false;
                ItemICatalogsRemoved = new ObservableCollection<IItemICatalog>();

                Project = projectService.GetProjectById(projectId);
                Quote = quoteService.GetQuoteByQuoteId(quoteId);
                mw.Title = $@"XpressPro ({Project.Name} / {Quote.Name})";

                ItemICatalogsRemoved = new ObservableCollection<IItemICatalog>();
                //ItemICatalogs = itemService.GetItemCatalogsByQuoteId(quoteId).ToObservableCollection();
                //AirCooledChillers = ItemICatalogs.Where(x => x.Item is ItemAirCooledChiller).ToObservableCollection();
                //Units = ItemICatalogs.Where(x => x.Item is ItemUnit).ToObservableCollection();
                //Pumps = ItemICatalogs.Where(x => x.Item is ItemPump).ToObservableCollection();
                //Vfds = ItemICatalogs.Where(x => x.Item is ItemVfd).ToObservableCollection();

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
                NeedUpdate = false;

                await messageService.EndMessage("Quote Items", "Quote items configuration saved successfully");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
