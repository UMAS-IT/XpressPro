using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogUvResources;
using Orion.Domain.EntityItemABB;
using Orion.Domain.EntityItemUvResources;
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
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.UvResources.EditQuoteItem
{
    public class EditF1ItemViewModel : MasterEditItemViewModel
    {
        private RelatedService relatedService;

        private ObservableCollection<CatalogF1ProductType> _catalogF1ProductTypes;
        public ObservableCollection<CatalogF1ProductType> CatalogF1ProductTypes
        {
            get => _catalogF1ProductTypes;
            set => SetProperty(ref _catalogF1ProductTypes, value);
        }

        public RelayCommand ClearProductTypesCommand { get; set; }

        public EditF1ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
            relatedService = new RelatedService();

            ClearProductTypesCommand = new RelayCommand(OnClearProductTypes);
        }

        private void OnClearProductTypes()
        {
            CatalogF1ProductTypes.ToList().ForEach(x => x.IsSelected = false);
        }

        public override async Task OnLoadData()
        {
            try
            {
                await base.OnLoadData();

                CatalogF1ProductTypes = relatedService.GetCatalogF1ProductTypes().ToObservableCollection();
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        public override void OnSearch()
        {
            base.OnSearch();

            if (CatalogF1ProductTypes.Any(x => x.IsSelected))
            {
                Catalogs = Catalogs.Where(x => CatalogF1ProductTypes.Any(y => y.IsSelected && (x as CatalogF1).CatalogF1ProductType.Id == y.Id)).ToObservableCollection();
            }
        }
    }
}
