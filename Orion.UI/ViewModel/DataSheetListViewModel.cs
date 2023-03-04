using MahApps.Metro.Controls.Dialogs;
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

namespace Orion.UI.ViewModel
{
    public class DataSheetListViewModel : ValidatableBindableBase
    {
        private IDialogCoordinator dialogCoordinator;
        private CompanyService companyService;
        private MessageService messageService;

        private ObservableCollection<Company> _companies;
        public ObservableCollection<Company> Companies
        {
            get => _companies;
            set => SetProperty(ref _companies, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand OpenDataSheetsCommand { get; set; }

        public DataSheetListViewModel(IDialogCoordinator dialogCoordinator)
        {
            this.dialogCoordinator = dialogCoordinator;

            companyService = new CompanyService();
            messageService = new MessageService(dialogCoordinator, this);

            LoadDataCommand = new RelayCommand(OnLoadData);
            OpenDataSheetsCommand = new RelayCommand(OnOpenDataSheets);
        }

        private void OnOpenDataSheets()
        {
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Products", "Loading company products, please wait...");

                Companies = companyService.GetCompanies().ToObservableCollection();

                await messageService.EndMessage("Products", "Company products has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
