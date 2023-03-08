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
        private readonly AirTreatmentViewModel airTreatmentViewModel = new AirTreatmentViewModel();
        IDialogCoordinator dialogCoordinator;
        private CompanyService companyService;
        private MessageService messageService;
        private DataSheetService dataSheetService;

        private ObservableCollection<Company> _companies;
        public ObservableCollection<Company> Companies
        {
            get => _companies;
            set => SetProperty(ref _companies, value);
        }

        private string _companyProductName;
        public string CompanyProductName
        {
            get => _companyProductName;
            set => SetProperty(ref _companyProductName, value);
        }

        private ObservableCollection<DataSheet> _dataSheets;
        public ObservableCollection<DataSheet> DataSheets
        {
            get => _dataSheets;
            set => SetProperty(ref _dataSheets, value);
        }

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private ObservableCollection<BindableBase> _dataSheetViewModels;
        public ObservableCollection<BindableBase> DataSheetViewModels
        {
            get => _dataSheetViewModels;
            set => SetProperty(ref _dataSheetViewModels, value);
        }

        private bool _productsActive;
        public bool ProductsActive
        {
            get => _productsActive;
            set => SetProperty(ref _productsActive, value);
        }

        private Product _product;
        public Product Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<Product> OpenDataSheetsCommand { get; set; }
        public RelayCommand AddDataSheetCommand { get; set; }
        public RelayCommand BackToProductsCommand { get; set; }


        public DataSheetListViewModel(IDialogCoordinator dialogCoordinator)
        {
            this.dialogCoordinator = dialogCoordinator;
            companyService = new CompanyService();
            messageService = new MessageService(dialogCoordinator, this);
            dataSheetService = new DataSheetService();

            LoadDataCommand = new RelayCommand(OnLoadData);
            OpenDataSheetsCommand = new RelayCommand<Product>(OnOpenDataSheets);
            AddDataSheetCommand = new RelayCommand(OnAddDataSheet);
            BackToProductsCommand = new RelayCommand(OnBackToProducts);
        }

        private void OnBackToProducts()
        {
            ProductsActive = true;
        }

        private void OnAddDataSheet()
        {
            DataSheet dataSheet = new DataSheet();

            TitleViewModel titleViewModel = new TitleViewModel(dialogCoordinator, dataSheet, Product);
            titleViewModel.OnDataSheetDeletedRequested += DataSheetDeletedRequested;

            DataSheetViewModels.Add(titleViewModel);
        }

        private async void OnOpenDataSheets(Product productSelected)
        {
            if (productSelected == null)
                return;

            try
            {
                await messageService.StartMessage("Data Sheets", "Loading data sheets, please wait...");

                ProductsActive = false;

                Product = productSelected;

                DataSheetViewModels = new ObservableCollection<BindableBase>();

                CompanyProductName = $"{productSelected.Company.Name}: {productSelected.Name}";

                DataSheets = dataSheetService.GetDataSheetsByProductId(productSelected.Id).ToObservableCollection();

                foreach (DataSheet dataSheet in DataSheets)
                {
                    TitleViewModel titleViewModel = new TitleViewModel(dialogCoordinator, dataSheet, Product);
                    titleViewModel.OnDataSheetDeletedRequested += DataSheetDeletedRequested;

                    DataSheetViewModels.Add(titleViewModel);
                }

                await messageService.EndMessage("Products", "Data sheets has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }

        }

        private void DataSheetDeletedRequested(DataSheet dataSheetDeleted)
        {
            //DataSheets.Remove(dataSheetDeleted);
            DataSheetViewModels.Remove(DataSheetViewModels.First(x => (x as TitleViewModel).DataSheet == dataSheetDeleted));
        }

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Products", "Loading company products, please wait...");

                ProductsActive = true;

                CurrentViewModel = airTreatmentViewModel;

                Companies = companyService.GetCompanies().ToObservableCollection();

                await messageService.EndMessage("Products", "Company products has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        //private void GetDataSheets(int productId)
        //{
        //    DataSheets = dataSheetService.GetDataSheetsByProductId(productId).ToObservableCollection();
        //}
    }
}
