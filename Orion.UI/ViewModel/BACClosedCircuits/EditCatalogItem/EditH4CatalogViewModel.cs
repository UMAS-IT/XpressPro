using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Helper.Misc;

namespace Orion.UI.ViewModel.BACClosedCircuits.EditCatalogItem
{
    public class EditH4CatalogViewModel : MasterEditCatalogViewModel
    {
        public EditH4CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
        }
    }
}
