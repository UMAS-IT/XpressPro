using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemAmericanWheatley;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem
{
    public class EditC1ItemViewModel : MasterEditItemViewModel
    {
        private RelatedService relatedService;

        private ObservableCollection<CatalogC1ProductType> _catalogC1ProductTypes;
        public ObservableCollection<CatalogC1ProductType> CatalogC1ProductTypes
        {
            get => _catalogC1ProductTypes;
            set => SetProperty(ref _catalogC1ProductTypes, value);
        }

        public RelayCommand ClearProductTypesCommand { get; set; }
        public EditC1ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
            relatedService = new RelatedService();

            ClearProductTypesCommand = new RelayCommand(OnClearProductTypes);
        }

        private void OnClearProductTypes()
        {
            CatalogC1ProductTypes.ToList().ForEach(x => x.IsSelected = false);
        }

        public override async Task OnLoadData()
        {
            try
            {
                await base.OnLoadData();

                CatalogC1ProductTypes = relatedService.GetCatalogC1ProductTypes().ToObservableCollection();
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        public override void OnSearch()
        {
            base.OnSearch();

            if (CatalogC1ProductTypes.Any(x => x.IsSelected))
            {
                Catalogs = Catalogs.Where(x => CatalogC1ProductTypes.Any(y => y.IsSelected && (x as CatalogC1).CatalogC1ProductType.Id == y.Id)).ToObservableCollection();
            }
        }
    }
}
