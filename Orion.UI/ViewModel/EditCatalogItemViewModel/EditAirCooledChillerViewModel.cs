using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalog;
using Orion.Domain.EntityItem;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.EditCatalogItemViewModel
{
    public class EditAirCooledChillerViewModel : BindableBase
    {
        MessageService messageService;
        CatalogService catalogService;


        private ICatalog _catalog;
        public ICatalog Catalog
        {
            get => _catalog;
            set => SetProperty(ref _catalog, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand SaveCatalogCommand { get; set; }
        public RelayCommand BackCommand { get; set; }

        public Action<ICatalog> CatalogSavedRequested = delegate { };
        public Action BackRequested = delegate { };

        public EditAirCooledChillerViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog)
        {
            Catalog = catalog;
            LoadDataCommand = new RelayCommand(OnLoadData);
            SaveCatalogCommand = new RelayCommand(OnSaveCatalog);
            BackCommand = new RelayCommand(OnBack);

            messageService = new MessageService(dialogCoordinator, this);
            catalogService = new CatalogService();
        }

        private void OnBack()
        {
            BackRequested();
        }

        private void OnSaveCatalog()
        {
            CatalogSavedRequested(Catalog);
        }

        private async void OnLoadData()
        {
            await messageService.StartMessage("Catalog Item", "Loading catalog item, please wait...");

            if (Catalog is null)
            {
                Catalog = new CatalogAirCooledChiller();
            }
            else
            {
                Catalog = catalogService.GetCatalogByCatalogId(Catalog);
            }



            await messageService.EndMessage("Catalog Item", "Catalog item has been saved");
        }
    }
}
