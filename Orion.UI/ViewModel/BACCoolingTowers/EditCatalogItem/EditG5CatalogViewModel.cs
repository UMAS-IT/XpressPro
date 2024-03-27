using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Helper.Misc;

namespace Orion.UI.ViewModel.BACCoolingTowers.EditCatalogItem
{
    public class EditG5CatalogViewModel : MasterEditCatalogViewModel
    {
        public EditG5CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
        }
    }
}
