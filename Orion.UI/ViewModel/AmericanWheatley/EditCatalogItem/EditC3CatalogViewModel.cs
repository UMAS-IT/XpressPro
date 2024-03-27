using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
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

namespace Orion.UI.ViewModel.AmericanWheatley.EditCatalogItem
{
    public class EditC3CatalogViewModel : MasterEditCatalogViewModel
    {
        private RelatedService relatedService;

        private ObservableCollection<CatalogC3ProductType> _catalogC3ProductType;
        public ObservableCollection<CatalogC3ProductType> CatalogC3ProductTypes
        {
            get => _catalogC3ProductType;
            set => SetProperty(ref _catalogC3ProductType, value);
        }

        public EditC3CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
            relatedService = new RelatedService();
        }

        public override async Task OnLoadData()
        {
            try
            {
                await base.OnLoadData();

                CatalogC3ProductTypes = relatedService.GetCatalogC3ProductTypes().ToObservableCollection();

                (Catalog as CatalogC3).CatalogC3ProductType = CatalogC3ProductTypes.SetEntity((Catalog as CatalogC3).CatalogC3ProductType);
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
