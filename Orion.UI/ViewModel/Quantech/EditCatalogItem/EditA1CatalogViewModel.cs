﻿using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Quantech.EditCatalogItem
{
    public class EditA1CatalogViewModel : BindableBase
    {
        MessageService messageService;
        CatalogService catalogService;

        private ICatalog _catalog;
        public ICatalog Catalog
        {
            get => _catalog;
            set => SetProperty(ref _catalog, value);
        }
        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand BackFromEditCommand { get; set; }

        public Action BackFromEditRequested = delegate { };

        public EditA1CatalogViewModel(IDialogCoordinator dialogCoordinator, ICatalog catalog)
        {
            Catalog = catalog;

            LoadDataCommand = new RelayCommand(OnLoadData);
            BackFromEditCommand = new RelayCommand(OnBackFromEdit);

            catalogService = new CatalogService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnBackFromEdit()
        {
            BackFromEditRequested();
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Catalog Items", "Loading catalog items, please wait...");

                Catalog = catalogService.GetCatalogByCatalogId(Catalog);

                await messageService.EndMessage("Catalog Items", "Catalog items has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
