using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.AboveAir.EditCatalogItem
{
    public class EditN1CatalogViewModel : MasterEditCatalogViewModel
    {
        public EditN1CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
        }
    }
}
