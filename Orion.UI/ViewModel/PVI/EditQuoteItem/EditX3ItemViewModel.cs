﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.PVI.EditQuoteItem
{
    internal class EditX3ItemViewModel : MasterEditItemViewModel
    {
        public EditX3ItemViewModel(IDialogCoordinator dialogCoordinator, Quote quote, IList<IItem> items, GV.ItemType itemType) : base(dialogCoordinator, quote, items, itemType)
        {
        }
    }
}
