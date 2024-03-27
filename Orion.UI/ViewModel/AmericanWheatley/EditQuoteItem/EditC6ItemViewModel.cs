using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem
{
    public class EditC6ItemViewModel : MasterEditItemViewModel
    {
        public EditC6ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
        }
    }
}
