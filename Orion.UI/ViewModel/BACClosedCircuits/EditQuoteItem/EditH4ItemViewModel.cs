﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using System.Collections.Generic;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.BACClosedCircuits.EditQuoteItem
{
    public class EditH4ItemViewModel : MasterEditItemViewModel
    {
        public EditH4ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
        }
    }
}
