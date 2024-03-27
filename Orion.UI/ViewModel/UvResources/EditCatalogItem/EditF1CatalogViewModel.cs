using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Domain.UvResources.Related;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
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
    public class EditF1CatalogViewModel : MasterEditCatalogViewModel
    {
        private RelatedService relatedService;

        private ObservableCollection<CatalogF1ProductType> _catalogF1ProductTypes;
        public ObservableCollection<CatalogF1ProductType> CatalogF1ProductTypes
        {
            get => _catalogF1ProductTypes;
            set => SetProperty(ref _catalogF1ProductTypes, value);
        }

        public EditF1CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
            relatedService = new RelatedService();
        }
        
        public override async Task OnLoadData()
        {
            try
            {
                await base.OnLoadData();

                CatalogF1ProductTypes = relatedService.GetCatalogF1ProductTypes().ToObservableCollection();

                (Catalog as CatalogF1).CatalogF1ProductType = CatalogF1ProductTypes.SetEntity((Catalog as CatalogF1).CatalogF1ProductType);
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
