using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Helper.Misc;

namespace Orion.UI.ViewModel.BACClosedCircuits.EditCatalogItem
{
    public class EditH1CatalogViewModel : MasterEditCatalogViewModel
    {
        public EditH1CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
        }
    }
}
