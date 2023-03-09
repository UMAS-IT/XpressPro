using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogQuantech;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using Orion.UI.ViewModel.ABB.CatalogList;
using Orion.UI.ViewModel.ABB.EditCatalogItem;
using Orion.UI.ViewModel.AmericanWheatley.CatalogList;
using Orion.UI.ViewModel.AmericanWheatley.EditCatalogItem;
using Orion.UI.ViewModel.BACClosedCircuits.CatalogList;
using Orion.UI.ViewModel.BACClosedCircuits.EditCatalogItem;
using Orion.UI.ViewModel.BACCoolingTowers.CatalogList;
using Orion.UI.ViewModel.BACCoolingTowers.EditCatalogItem;
using Orion.UI.ViewModel.Groundfos.CatalogList;
using Orion.UI.ViewModel.Groundfos.EditCatalogItem;
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


        private void OnEditCatalogItem(ICatalog catalog)
        {
            EditActive = true;

            IEditCatalogViewModel viewModel = null;

            if (CurrentViewModel is CatalogA1ListViewModel)
                viewModel = new EditA1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogA2ListViewModel)
                viewModel = new EditA2CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogA3ListViewModel)
                viewModel = new EditA3CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogA4ListViewModel)
                viewModel = new EditA4CatalogViewModel(dialogCoordinator, catalog);
            
            else if (CurrentViewModel is CatalogB1ListViewModel)
                viewModel = new EditB1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB2ListViewModel)
                viewModel = new EditB2CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB3ListViewModel)
                viewModel = new EditB3CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB4ListViewModel)
                viewModel = new EditB4CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogB5ListViewModel)
                viewModel = new EditB5CatalogViewModel(dialogCoordinator, catalog);

            else if (CurrentViewModel is CatalogC1ListViewModel)
                viewModel = new EditC1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogC2ListViewModel)
                viewModel = new EditC2CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogC3ListViewModel)
                viewModel = new EditC3CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogC4ListViewModel)
                viewModel = new EditC4CatalogViewModel(dialogCoordinator, catalog);

            else if (CurrentViewModel is CatalogD1ListViewModel)
                viewModel = new EditD1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogD2ListViewModel)
                viewModel = new EditD2CatalogViewModel(dialogCoordinator, catalog);

            else if (CurrentViewModel is CatalogE1ListViewModel)
                viewModel = new EditE1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogE2ListViewModel)
                viewModel = new EditE2CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogE3ListViewModel)
                viewModel = new EditE3CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogE4ListViewModel)
                viewModel = new EditE4CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogE5ListViewModel)
                viewModel = new EditE5CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogE6ListViewModel)
                viewModel = new EditE6CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogE7ListViewModel)
                viewModel = new EditE7CatalogViewModel(dialogCoordinator, catalog);

            else if (CurrentViewModel is CatalogF1ListViewModel)
                viewModel = new EditF1CatalogViewModel(dialogCoordinator, catalog);

            else if (CurrentViewModel is CatalogG1ListViewModel)
                viewModel = new EditG1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogG2ListViewModel)
                viewModel = new EditG2CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogG3ListViewModel)
                viewModel = new EditG3CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogG4ListViewModel)
                viewModel = new EditG4CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogG5ListViewModel)
                viewModel = new EditG5CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogG6ListViewModel)
                viewModel = new EditG6CatalogViewModel(dialogCoordinator, catalog);

            else if (CurrentViewModel is CatalogH1ListViewModel)
                viewModel = new EditH1CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogH2ListViewModel)
                viewModel = new EditH2CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogH3ListViewModel)
                viewModel = new EditH3CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogH4ListViewModel)
                viewModel = new EditH4CatalogViewModel(dialogCoordinator, catalog);
            else if (CurrentViewModel is CatalogH5ListViewModel)
                viewModel = new EditH5CatalogViewModel(dialogCoordinator, catalog);


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

            ICatalogListViewModel viewModel = null;

            if (catalogName == "a1")
                viewModel = new CatalogA1ListViewModel(dialogCoordinator);
            else if (catalogName == "a2")
                viewModel = new CatalogA2ListViewModel(dialogCoordinator);
            else if (catalogName == "a3")
                viewModel = new CatalogA3ListViewModel(dialogCoordinator);
            else if (catalogName == "a4")
                viewModel = new CatalogA4ListViewModel(dialogCoordinator);

            else if (catalogName == "b1")
                viewModel = new CatalogB1ListViewModel(dialogCoordinator);
            else if (catalogName == "b2")
                viewModel = new CatalogB2ListViewModel(dialogCoordinator);
            else if (catalogName == "b3")
                viewModel = new CatalogB3ListViewModel(dialogCoordinator);
            else if (catalogName == "b4")
                viewModel = new CatalogB4ListViewModel(dialogCoordinator);
            else if (catalogName == "b5")
                viewModel = new CatalogB5ListViewModel(dialogCoordinator);

            else if (catalogName == "c1")
                viewModel = new CatalogC1ListViewModel(dialogCoordinator);
            else if (catalogName == "c2")
                viewModel = new CatalogC2ListViewModel(dialogCoordinator);
            else if (catalogName == "c3")
                viewModel = new CatalogC3ListViewModel(dialogCoordinator);
            else if (catalogName == "c4")
                viewModel = new CatalogC4ListViewModel(dialogCoordinator);

            else if (catalogName == "d1")
                viewModel = new CatalogD1ListViewModel(dialogCoordinator);
            else if (catalogName == "d2")
                viewModel = new CatalogD2ListViewModel(dialogCoordinator);

            else if (catalogName == "e1")
                viewModel = new CatalogE1ListViewModel(dialogCoordinator);
            else if (catalogName == "e2")
                viewModel = new CatalogE2ListViewModel(dialogCoordinator);
            else if (catalogName == "e3")
                viewModel = new CatalogE3ListViewModel(dialogCoordinator);
            else if (catalogName == "e4")
                viewModel = new CatalogE4ListViewModel(dialogCoordinator);
            else if (catalogName == "e5")
                viewModel = new CatalogE5ListViewModel(dialogCoordinator);
            else if (catalogName == "e6")
                viewModel = new CatalogE6ListViewModel(dialogCoordinator);
            else if (catalogName == "e7")
                viewModel = new CatalogE7ListViewModel(dialogCoordinator);

            else if (catalogName == "f1")
                viewModel = new CatalogF1ListViewModel(dialogCoordinator);

            else if (catalogName == "g1")
                viewModel = new CatalogG1ListViewModel(dialogCoordinator);
            else if (catalogName == "g2")
                viewModel = new CatalogG2ListViewModel(dialogCoordinator);
            else if (catalogName == "g3")
                viewModel = new CatalogG3ListViewModel(dialogCoordinator);
            else if (catalogName == "g4")
                viewModel = new CatalogG4ListViewModel(dialogCoordinator);
            else if (catalogName == "g5")
                viewModel = new CatalogG5ListViewModel(dialogCoordinator);
            else if (catalogName == "g6")
                viewModel = new CatalogG6ListViewModel(dialogCoordinator);


            else if (catalogName == "h1")
                viewModel = new CatalogH1ListViewModel(dialogCoordinator);
            else if (catalogName == "g2")
                viewModel = new CatalogH2ListViewModel(dialogCoordinator);
            else if (catalogName == "h3")
                viewModel = new CatalogH3ListViewModel(dialogCoordinator);
            else if (catalogName == "h4")
                viewModel = new CatalogH4ListViewModel(dialogCoordinator);
            else if (catalogName == "h5")
                viewModel = new CatalogH5ListViewModel(dialogCoordinator);


            if (viewModel != null)
            {
                viewModel.BackToProductsRequested += OnBackToProducts;
                viewModel.OnEditCatalogTitlesRequested += OnEditCatalogTitles;
                viewModel.OnEditCatalogItemRequested += OnEditCatalogItem;

                CurrentViewModel = (BindableBase)viewModel;
            }
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

                CatalogSelected = catalogService.GetCatalogByCatalogId(catalog);

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
