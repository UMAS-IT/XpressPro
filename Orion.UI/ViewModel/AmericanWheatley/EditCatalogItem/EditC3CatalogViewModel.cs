using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogAmericanWheatley;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Misc;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.AmericanWheatley.EditCatalogItem
{
    public class EditC3CatalogViewModel : MasterEditCatalogViewModel
    {
        public EditC3CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog, GV.ItemType itemType) : base(dialogCoordinator, catalog, itemType)
        {
        }
    }
}
