using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Misc;
using Orion.UI.Service;
using Orion.UI.ViewModel.ABB.CatalogList;
using Orion.UI.ViewModel.ABB.EditCatalogItem;
using Orion.UI.ViewModel.AmericanWheatley.CatalogList;
using Orion.UI.ViewModel.AmericanWheatley.EditCatalogItem;
using Orion.UI.ViewModel.BACClosedCircuits.CatalogList;
using Orion.UI.ViewModel.BACClosedCircuits.EditCatalogItem;
using Orion.UI.ViewModel.BACCoolingTowers.CatalogList;
using Orion.UI.ViewModel.BACCoolingTowers.EditCatalogItem;
using Orion.UI.ViewModel.GeneralProduct.CatalogList;
using Orion.UI.ViewModel.GeneralProduct.EditCatalogItem;
using Orion.UI.ViewModel.Groundfos.CatalogList;
using Orion.UI.ViewModel.Groundfos.EditCatalogItem;
using Orion.UI.ViewModel.Mavair.CatalogList;
using Orion.UI.ViewModel.Mavair.EditCatalogItem;
using Orion.UI.ViewModel.Multiaqua.CatalogList;
using Orion.UI.ViewModel.Multiaqua.EditCatalogItem;
using Orion.UI.ViewModel.PACE.CatalogList;
using Orion.UI.ViewModel.PACE.EditCatalogItem;
using Orion.UI.ViewModel.Puroflux.CatalogList;
using Orion.UI.ViewModel.Puroflux.EditCatalogItem;
using Orion.UI.ViewModel.Quantech.CatalogList;
using Orion.UI.ViewModel.Quantech.EditCatalogItem;
using Orion.UI.ViewModel.UvResources.CatalogList;
using Orion.UI.ViewModel.UvResources.EditCatalogItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel
{
    public class CatalogViewModel : BindableBase
    {
        private AirTreatmentViewModel airTreatmentViewModel = new AirTreatmentViewModel();
        MessageService messageService;
        IDialogCoordinator dialogCoordinator;
        CompanyService companyService;
        private DataSheetService dataSheetService;
        CatalogService catalogService;

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get => _currentViewModel;
            set => SetProperty(ref _currentViewModel, value);
        }

        private BindableBase _editViewModel;
        public BindableBase EditViewModel
        {
            get => _editViewModel;
            set => SetProperty(ref _editViewModel, value);
        }

        private bool _productsActive;
        public bool ProductsActive
        {
            get => _productsActive;
            set => SetProperty(ref _productsActive, value);
        }

        private bool _editActive;
        public bool EditActive
        {
            get => _editActive;
            set => SetProperty(ref _editActive, value);
        }

        private bool _dataSheetActive;
        public bool DataSheetActive
        {
            get => _dataSheetActive;
            set => SetProperty(ref _dataSheetActive, value);
        }

        private ObservableCollection<Company> _companies;
        public ObservableCollection<Company> Companies
        {
            get => _companies;
            set => SetProperty(ref _companies, value);
        }

        private ObservableCollection<BindableBase> _dataSheetViewModels;
        public ObservableCollection<BindableBase> DataSheetViewModels
        {
            get => _dataSheetViewModels;
            set => SetProperty(ref _dataSheetViewModels, value);
        }

        private ICatalog _catalogSelected;
        public ICatalog CatalogSelected
        {
            get => _catalogSelected;
            set => SetProperty(ref _catalogSelected, value);
        }

        public RelayCommand LoadDataCommand { get; set; }

        public RelayCommand<string> OpenCatalogCommand { get; set; }
        public RelayCommand<BindableBase> DataSheetCheckedCommand { get; set; }
        public RelayCommand<BindableBase> DataSheetUnchekedCommand { get; set; }
        public RelayCommand BackFromDataSheetsCommand { get; set; }
        public RelayCommand UpdateDataSheetSelectedCommand { get; set; }

        public CatalogViewModel(IDialogCoordinator dialogCoordinator)
        {
            this.dialogCoordinator = dialogCoordinator;

            LoadDataCommand = new RelayCommand(OnLoadData);
            OpenCatalogCommand = new RelayCommand<string>(OnOpenCatalog);
            DataSheetCheckedCommand = new RelayCommand<BindableBase>(OnDataSheetChecked);
            DataSheetUnchekedCommand = new RelayCommand<BindableBase>(OnDataSheetUnchecked);
            BackFromDataSheetsCommand = new RelayCommand(OnBackFromDataSheets);
            UpdateDataSheetSelectedCommand = new RelayCommand(OnUpdateDataSheetSelected);

            messageService = new MessageService(dialogCoordinator, this);
            companyService = new CompanyService();
            dataSheetService = new DataSheetService();
            catalogService = new CatalogService();
        }


        private void OnEditCatalogItem(ICatalog catalog, ItemType itemType)
        {
            EditActive = true;

            Type viewModelType = VmHelper.GetEditCatalogViewModelTypeForItemType(itemType);

            IEditCatalogViewModel viewModel = (IEditCatalogViewModel)Activator.CreateInstance(viewModelType, dialogCoordinator, catalog, itemType);

            viewModel.BackFromEditRequested += OnBackFromEdit;
            viewModel.BackFromEditItemSavedRequested += OnBackFromEditItemSaved;
            EditViewModel = (BindableBase)viewModel;

        }

        private void OnBackFromEditItemSaved(ICatalog catalog, bool isUpdated)
        {
            ICatalogListViewModel viewModel = null;

            #region Old Code
            //if (CurrentViewModel is CatalogA1ListViewModel)
            //    viewModel = CurrentViewModel as CatalogA1ListViewModel;
            //else if (CurrentViewModel is CatalogA2ListViewModel)
            //    viewModel = CurrentViewModel as CatalogA2ListViewModel;
            //else if (CurrentViewModel is CatalogA3ListViewModel)
            //    viewModel = CurrentViewModel as CatalogA3ListViewModel;
            //else if (CurrentViewModel is CatalogA4ListViewModel)
            //    viewModel = CurrentViewModel as CatalogA4ListViewModel;

            //else if (CurrentViewModel is CatalogB1ListViewModel)
            //    viewModel = CurrentViewModel as CatalogB1ListViewModel;
            //else if (CurrentViewModel is CatalogB2ListViewModel)
            //    viewModel = CurrentViewModel as CatalogB2ListViewModel;
            //else if (CurrentViewModel is CatalogB3ListViewModel)
            //    viewModel = CurrentViewModel as CatalogB3ListViewModel;
            //else if (CurrentViewModel is CatalogB4ListViewModel)
            //    viewModel = CurrentViewModel as CatalogB4ListViewModel;
            //else if (CurrentViewModel is CatalogB5ListViewModel)
            //    viewModel = CurrentViewModel as CatalogB5ListViewModel;

            //else if (CurrentViewModel is CatalogC1ListViewModel)
            //    viewModel = CurrentViewModel as CatalogC1ListViewModel;
            //else if (CurrentViewModel is CatalogC2ListViewModel)
            //    viewModel = CurrentViewModel as CatalogC2ListViewModel;
            //else if (CurrentViewModel is CatalogC3ListViewModel)
            //    viewModel = CurrentViewModel as CatalogC3ListViewModel;
            //else if (CurrentViewModel is CatalogC4ListViewModel)
            //    viewModel = CurrentViewModel as CatalogC4ListViewModel;

            //else if (CurrentViewModel is CatalogD1ListViewModel)
            //    viewModel = CurrentViewModel as CatalogD1ListViewModel;
            //else if (CurrentViewModel is CatalogD2ListViewModel)
            //    viewModel = CurrentViewModel as CatalogD2ListViewModel;

            //else if (CurrentViewModel is CatalogE1ListViewModel)
            //    viewModel = CurrentViewModel as CatalogE1ListViewModel;
            //else if (CurrentViewModel is CatalogE2ListViewModel)
            //    viewModel = CurrentViewModel as CatalogE2ListViewModel;
            //else if (CurrentViewModel is CatalogE3ListViewModel)
            //    viewModel = CurrentViewModel as CatalogE3ListViewModel;
            //else if (CurrentViewModel is CatalogE4ListViewModel)
            //    viewModel = CurrentViewModel as CatalogE4ListViewModel;
            //else if (CurrentViewModel is CatalogE5ListViewModel)
            //    viewModel = CurrentViewModel as CatalogE5ListViewModel;
            //else if (CurrentViewModel is CatalogE6ListViewModel)
            //    viewModel = CurrentViewModel as CatalogE6ListViewModel;
            //else if (CurrentViewModel is CatalogE7ListViewModel)
            //    viewModel = CurrentViewModel as CatalogE7ListViewModel;

            //else if (CurrentViewModel is CatalogF1ListViewModel)
            //    viewModel = CurrentViewModel as CatalogF1ListViewModel;

            //else if (CurrentViewModel is CatalogG1ListViewModel)
            //    viewModel = CurrentViewModel as CatalogG1ListViewModel;
            //else if (CurrentViewModel is CatalogG2ListViewModel)
            //    viewModel = CurrentViewModel as CatalogG2ListViewModel;
            //else if (CurrentViewModel is CatalogG3ListViewModel)
            //    viewModel = CurrentViewModel as CatalogG3ListViewModel;
            //else if (CurrentViewModel is CatalogG4ListViewModel)
            //    viewModel = CurrentViewModel as CatalogG4ListViewModel;
            //else if (CurrentViewModel is CatalogG5ListViewModel)
            //    viewModel = CurrentViewModel as CatalogG5ListViewModel;
            //else if (CurrentViewModel is CatalogG6ListViewModel)
            //    viewModel = CurrentViewModel as CatalogG6ListViewModel;

            //else if (CurrentViewModel is CatalogH1ListViewModel)
            //    viewModel = CurrentViewModel as CatalogH1ListViewModel;
            //else if (CurrentViewModel is CatalogH2ListViewModel)
            //    viewModel = CurrentViewModel as CatalogH2ListViewModel;
            //else if (CurrentViewModel is CatalogH3ListViewModel)
            //    viewModel = CurrentViewModel as CatalogH3ListViewModel;
            //else if (CurrentViewModel is CatalogH4ListViewModel)
            //    viewModel = CurrentViewModel as CatalogH4ListViewModel;
            //else if (CurrentViewModel is CatalogH5ListViewModel)
            //    viewModel = CurrentViewModel as CatalogH5ListViewModel;
            #endregion

            viewModel = (ICatalogListViewModel)CurrentViewModel;

            if (isUpdated)
            {
                ReplaceUpdatedCatalogFromCatalogList(viewModel, catalog);
            }
            else
            {
                viewModel.Catalogs.Add(catalog);
                int sectionIndex = viewModel.Catalogs.IndexOf(catalog);
                int firstIndex = 0;
                viewModel.Catalogs.Move(sectionIndex, firstIndex);
            }

            OnBackFromEdit();
        }

        private void ReplaceUpdatedCatalogFromCatalogList(ICatalogListViewModel viewModel, ICatalog catalog)
        {
            int index = viewModel.Catalogs.ToList().FindIndex(s => s.Id == catalog.Id);

            if (index != -1)
                viewModel.Catalogs[index] = catalog;
        }

        private async void OnOpenCatalog(string catalogName)
        {
            CurrentViewModel = null;
            await Task.Delay(100);
            ProductsActive = false;

            catalogName = catalogName.ToFormat();

            ItemType itemType = VmHelper.GetItemType(catalogName);

            Type catalogListViewModelType = VmHelper.GetCatalogListViewModelTypeForItemType(itemType);

            ICatalogListViewModel viewModel = (ICatalogListViewModel)Activator.CreateInstance(catalogListViewModelType, dialogCoordinator, itemType);

            viewModel.BackToProductsRequested += OnBackToProducts;
            viewModel.OnEditCatalogTitlesRequested += OnEditCatalogTitles;
            viewModel.OnEditCatalogItemRequested += OnEditCatalogItem;

            CurrentViewModel = (BindableBase)viewModel;
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

        private async void OnEditCatalogTitles(ICatalog catalog)
        {
            try
            {
                await messageService.StartMessage("Data Sheets", "Loading data sheets, please wait...");

                DataSheetActive = true;

                DataSheetViewModels = new ObservableCollection<BindableBase>();

                CatalogSelected = catalogService.GetCatalog(catalog);

                List<DataSheet> dataSheets = dataSheetService.GetDataSheetsByIndex(CatalogSelected.Index).ToList();

                foreach (DataSheet dataSheet in dataSheets)
                {
                    dataSheet.IsSelected = catalog.DataSheet != null && catalog.DataSheet.Id == dataSheet.Id;

                    TitleViewModel titleViewModel = new TitleViewModel(dialogCoordinator, dataSheet, dataSheet.Product, true);

                    DataSheetViewModels.Add(titleViewModel);
                }

                await messageService.EndMessage("Data Sheets", "Data sheets has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
       
        private async void OnUpdateDataSheetSelected()
        {
            try
            {
                await messageService.StartMessage("Data Sheets", "Updating data sheet selection");

                List<DataSheet> dataSheets = DataSheetViewModels
                                .Select(dataSheetViewModel => dataSheetViewModel as TitleViewModel)
                                .Where(titleViewModel => titleViewModel != null)
                                .ToList().Select(x => x.DataSheet).ToList();

                CatalogSelected = catalogService.UpdateCatalogDataSheet(CatalogSelected, dataSheets);
                DataSheetActive = false;

                ReplaceUpdatedCatalogFromCatalogList((ICatalogListViewModel)CurrentViewModel, CatalogSelected);

                await messageService.EndMessage("Data Sheets", "Data sheet selection updated");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }

        private void OnDataSheetUnchecked(BindableBase viewModel)
        {

        }

        private void OnDataSheetChecked(BindableBase viewModel)
        {
            foreach (BindableBase bindableBase in DataSheetViewModels)
            {
                if (((TitleViewModel)bindableBase).DataSheet.Id != ((TitleViewModel)viewModel).DataSheet.Id)
                {
                    ((TitleViewModel)bindableBase).DataSheet.IsSelected = false;
                }
            }
        }

        private async void OnBackToProducts()
        {
            ProductsActive = true;
            CurrentViewModel = null;
            await Task.Delay(100);
            CurrentViewModel = airTreatmentViewModel;
        }

        private async void OnBackFromEdit()
        {
            EditActive = false;
            EditViewModel = null;
            await Task.Delay(100);
        }

        private void OnBackFromDataSheets()
        {
            DataSheetActive = false;
        }


    }
}
