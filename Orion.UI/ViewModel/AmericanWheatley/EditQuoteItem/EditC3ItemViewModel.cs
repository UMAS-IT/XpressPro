using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
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
    public class EditC3ItemViewModel : MasterEditItemViewModel
    {
        private RelatedService relatedService;

        private ObservableCollection<CatalogC3ProductType> _catalogC3ProductTypes;
        public ObservableCollection<CatalogC3ProductType> CatalogC3ProductTypes
        {
            get => _catalogC3ProductTypes;
            set => SetProperty(ref _catalogC3ProductTypes, value);
        }

        public RelayCommand ClearProductTypesCommand { get; set; }

        public EditC3ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
            relatedService = new RelatedService();

            ClearProductTypesCommand = new RelayCommand(OnClearProductTypes);
        }

        private void OnClearProductTypes()
        {
            CatalogC3ProductTypes.ToList().ForEach(x => x.IsSelected = false);
        }

        public override async Task OnLoadData()
        {
            try
            {
                await base.OnLoadData();

                CatalogC3ProductTypes = relatedService.GetCatalogC3ProductTypes().ToObservableCollection();
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        public override void OnSearch()
        {
            base.OnSearch();

            if (CatalogC3ProductTypes.Any(x => x.IsSelected))
            {
                Catalogs = Catalogs.Where(x => CatalogC3ProductTypes.Any(y => y.IsSelected && (x as CatalogC3).CatalogC3ProductType.Id == y.Id)).ToObservableCollection();
            }
        }
    }
}
