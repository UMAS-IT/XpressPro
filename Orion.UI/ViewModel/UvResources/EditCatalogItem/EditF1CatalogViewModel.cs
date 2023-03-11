using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Domain.UvResources.Related;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.UvResources.EditCatalogItem
{
    public class EditF1CatalogViewModel : BindableBase, IEditCatalogViewModel
    {
        MessageService messageService;
        CatalogService catalogService;
        private bool isUpdated;
        private RelatedService relatedService;

        private ICatalog _catalog;
        public ICatalog Catalog
        {
            get => _catalog;
            set => SetProperty(ref _catalog, value);
        }

        private ObservableCollection<CatalogF1ProductType> _catalogF1ProductTypes;
        public ObservableCollection<CatalogF1ProductType> CatalogF1ProductTypes
        {
            get => _catalogF1ProductTypes;
            set => SetProperty(ref _catalogF1ProductTypes, value);
        }
        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand BackFromEditCommand { get; set; }
        public RelayCommand UpdateCatalogItemCommand { get; set; }

        public Action BackFromEditRequested { get; set; } = delegate { };
        public Action<ICatalog, bool> BackFromEditItemSavedRequested { get; set; } = delegate { };

        public EditF1CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog)
        {
            Catalog = catalog;

            LoadDataCommand = new RelayCommand(OnLoadData);
            BackFromEditCommand = new RelayCommand(OnBackFromEdit);
            UpdateCatalogItemCommand = new RelayCommand(OnUpdateCatalogItem);

            catalogService = new CatalogService();
            messageService = new MessageService(dialogCoordinator, this);
            relatedService = new RelatedService();
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
            CatalogF1 catalog = Catalog as CatalogF1;

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
                    Catalog = new CatalogF1();
                    isUpdated = false;
                }
                else
                {
                    Catalog = catalogService.GetCatalog(Catalog);
                    isUpdated = true;
                }

                CatalogF1ProductTypes = relatedService.GetCatalogF1ProductTypes().ToObservableCollection();

                (Catalog as CatalogF1).CatalogF1ProductType = CatalogF1ProductTypes.SetEntity((Catalog as CatalogF1).CatalogF1ProductType);


                await messageService.EndMessage("Catalog Items", "Catalog items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
