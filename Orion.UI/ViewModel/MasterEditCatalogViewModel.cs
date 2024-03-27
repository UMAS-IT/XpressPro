using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel
{
    public class MasterEditCatalogViewModel : BindableBase, IEditCatalogViewModel
    {
        public MessageService messageService;
        public CatalogService catalogService;
        private bool isUpdated;

        private ICatalog _catalog;
        public ICatalog Catalog
        {
            get => _catalog;
            set => SetProperty(ref _catalog, value);
        }

        private ItemType _itemType;
        public ItemType ItemType
        {
            get => _itemType;
            set => SetProperty(ref _itemType, value);
        }

        public AsyncRelayCommand LoadDataCommand { get; set; }
        public RelayCommand BackFromEditCommand { get; set; }
        public RelayCommand UpdateCatalogItemCommand { get; set; }

        public Action BackFromEditRequested { get; set; } = delegate { };
        public Action<ICatalog, bool> BackFromEditItemSavedRequested { get; set; } = delegate { };

        public MasterEditCatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, ItemType itemType)
        {
            Catalog = catalog;
            ItemType = itemType;

            LoadDataCommand = new AsyncRelayCommand(OnLoadData);
            BackFromEditCommand = new RelayCommand(OnBackFromEdit);
            UpdateCatalogItemCommand = new RelayCommand(OnUpdateCatalogItem);

            catalogService = new CatalogService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private async void OnUpdateCatalogItem()
        {
            try
            {
                await messageService.StartMessage("Catalog Items", "Saving catalog item, please wait...");

                if (!await CanUpdate())
                    return;

                Catalog = catalogService.UpdateCatalogItem(Catalog);

                await messageService.EndMessage("Catalog Items", "Catalog item has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
            BackFromEditItemSavedRequested(Catalog, isUpdated);
        }

        private async Task<bool> CanUpdate()
        {
            if (string.IsNullOrWhiteSpace(Catalog.Model))
            {
                await messageService.ResultMessage("Error", "Please verify and complete your input information");
                return false;
            }

            if (catalogService.CatalogModelNameExist(Catalog))
            {
                await messageService.ResultMessage("Error", "This Model Name already exist in this catalog");
                return false;
            }

            return true;
        }

        private void OnBackFromEdit()
        {
            BackFromEditRequested();
        }

        public virtual async Task OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Catalog Items", "Loading catalog items, please wait...");

                if (Catalog == null || Catalog.Id == 0)
                {
                    Catalog = catalogService.CreateCatalog(ItemType);
                    isUpdated = false;
                }
                else
                {
                    Catalog = catalogService.GetCatalog(Catalog);
                    isUpdated = true;
                }

                await messageService.EndMessage("Catalog Items", "Catalog items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
