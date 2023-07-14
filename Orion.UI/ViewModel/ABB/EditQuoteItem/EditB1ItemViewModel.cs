using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.ABB.Fake;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogABB;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Domain.EntityItem;
using Orion.Domain.EntityItemABB;
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

namespace Orion.UI.ViewModel.ABB.EditQuoteItem
{
    public class EditB1ItemViewModel : MasterEditItemViewModel
    {

        private ObservableCollection<CatalogB1HorsePower> _catalogB1HorsePowers;
        public ObservableCollection<CatalogB1HorsePower> CatalogB1HorsePowers
        {
            get => _catalogB1HorsePowers;
            set => SetProperty(ref _catalogB1HorsePowers, value);
        }

        public RelayCommand ClearHPsCommand { get; set; }


        public EditB1ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {

            ClearHPsCommand = new RelayCommand(OnClearHPs);
        }

        private void OnClearHPs()
        {
            CatalogB1HorsePowers.ToList().ForEach(x => x.IsSelected = false);
        }

        public override async Task OnLoadData()
        {
            try
            {
                await base.OnLoadData();

                CatalogB1HorsePowers = new ObservableCollection<CatalogB1HorsePower>();

                Catalogs.OfType<CatalogB1>().GroupBy(x => x.Hp).ToList().ForEach(x => CatalogB1HorsePowers.Add(new CatalogB1HorsePower(x.First().Hp)));
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
        public override void OnSearch()
        {
            base.OnSearch();

            if (CatalogB1HorsePowers.Any(x => x.IsSelected))
            {
                Catalogs = Catalogs.Where(x => CatalogB1HorsePowers.Any(y => y.IsSelected && (x as CatalogB1).Hp == y.Hp)).ToObservableCollection();
            }
        }
    }
}
