﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.GeneralProduct.CatalogList
{
    public class CatalogL1ListViewModel : MasterCatalogListViewModel
    {
        public CatalogL1ListViewModel(IDialogCoordinator dialogCoordinator, GV.ItemType itemType) : base(dialogCoordinator, itemType)
        {
        }
    }
}
