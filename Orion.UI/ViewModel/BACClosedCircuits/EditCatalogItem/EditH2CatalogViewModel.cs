using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Helper.Misc;

namespace Orion.UI.ViewModel.BACClosedCircuits.EditCatalogItem
{
    public class EditH2CatalogViewModel : MasterEditCatalogViewModel
    {
        public EditH2CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
        }
    }
}
