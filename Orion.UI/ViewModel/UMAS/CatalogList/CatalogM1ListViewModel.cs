using MahApps.Metro.Controls.Dialogs;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.UMAS.CatalogList
{
    public class CatalogM1ListViewModel : MasterCatalogListViewModel
    {
        public CatalogM1ListViewModel(IDialogCoordinator dialogCoordinator, GV.ItemType itemType) : base(dialogCoordinator, itemType)
        {
        }
    }
}
