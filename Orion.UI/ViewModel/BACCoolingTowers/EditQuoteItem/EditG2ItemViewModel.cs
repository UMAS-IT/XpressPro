﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using System.Collections.Generic;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.BACCoolingTowers.EditQuoteItem
{
    public class EditG2ItemViewModel : MasterEditItemViewModel
    {
        public EditG2ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
        }
    }
}
