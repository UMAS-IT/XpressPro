﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.BACCoolingTowers.CatalogList
{
    public class CatalogG3ListViewModel : MasterCatalogListViewModel
    {
        public CatalogG3ListViewModel(IDialogCoordinator dialogCoordinator, ItemType itemType) : base(dialogCoordinator, itemType)
        {
        }
    }
}
