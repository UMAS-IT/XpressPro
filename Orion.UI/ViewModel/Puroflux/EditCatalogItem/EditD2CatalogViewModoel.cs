using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogPuroflux;
using Orion.Domain.EntityCatalogQuantech;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Puroflux.EditCatalogItem
{
    public class EditD2CatalogViewModel : BindableBase, IEditCatalogViewModel
    {
        MessageService messageService;
        CatalogService catalogService;
        private bool isUpdated;

        private ICatalog _catalog;
        public ICatalog Catalog
        {
            get => _catalog;
            set => SetProperty(ref _catalog, value);
        }
        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand BackFromEditCommand { get; set; }
        public RelayCommand UpdateCatalogItemCommand { get; set; }

        public Action BackFromEditRequested { get; set; } = delegate { };

        public Action<ICatalog, bool> BackFromEditItemSavedRequested { get; set; } = delegate { };

        public EditD2CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog)
        {
            Catalog = catalog;

            LoadDataCommand = new RelayCommand(OnLoadData);
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
            CatalogD2 catalog = Catalog as CatalogD2;

            if (string.IsNullOrWhiteSpace(catalog.Model))
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

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Catalog Items", "Loading catalog items, please wait...");

                if (Catalog == null || Catalog.Id == 0)
                {
                    Catalog = new CatalogD2();
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
