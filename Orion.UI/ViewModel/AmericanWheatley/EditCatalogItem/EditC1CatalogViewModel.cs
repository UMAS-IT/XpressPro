using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
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

namespace Orion.UI.ViewModel.AmericanWheatley.EditCatalogItem
{
    public class EditC1CatalogViewModel : MasterEditCatalogViewModel
    {
        private RelatedService relatedService;

        private ObservableCollection<CatalogC1ProductType> _catalogC1ProductType;
        public ObservableCollection<CatalogC1ProductType> CatalogC1ProductTypes
        {
            get => _catalogC1ProductType;
            set => SetProperty(ref _catalogC1ProductType, value);
        }

        public EditC1CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
            relatedService = new RelatedService();
        }

        public override async Task OnLoadData()
        {
            try
            {
                await base.OnLoadData();

                CatalogC1ProductTypes = relatedService.GetCatalogC1ProductTypes().ToObservableCollection();

                (Catalog as CatalogC1).CatalogC1ProductType = CatalogC1ProductTypes.SetEntity((Catalog as CatalogC1).CatalogC1ProductType);
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
