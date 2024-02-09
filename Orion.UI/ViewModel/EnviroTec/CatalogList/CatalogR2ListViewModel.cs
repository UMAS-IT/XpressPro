﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Helper.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.EnviroTec.CatalogList
{
    internal class CatalogR2ListViewModel : MasterCatalogListViewModel
    {
        public CatalogR2ListViewModel(IDialogCoordinator dialogCoordinator, GV.ItemType itemType) : base(dialogCoordinator, itemType)
        {
        }
    }
}
