using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.EnviroTec.EditQuoteItem
{
    internal class EditR3ItemViewModel : MasterEditItemViewModel
    {
        public EditR3ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, GV.ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
        }
    }
}
