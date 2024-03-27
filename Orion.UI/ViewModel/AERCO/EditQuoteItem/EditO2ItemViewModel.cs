using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.AERCO.EditQuoteItem
{
    internal class EditO2ItemViewModel : MasterEditItemViewModel
    {
        public EditO2ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, GV.ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
        }
    }
}
