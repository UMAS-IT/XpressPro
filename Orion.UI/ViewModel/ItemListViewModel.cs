using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using Orion.UI.Command;
using Orion.UI.Misc;
using Orion.UI.Service;
using Orion.UI.ViewModel.ABB.EditQuoteItem;
using Orion.UI.ViewModel.AmericanWheatley.EditQuoteItem;
using Orion.UI.ViewModel.BACClosedCircuits.EditQuoteItem;
using Orion.UI.ViewModel.BACCoolingTowers.EditQuoteItem;
using Orion.UI.ViewModel.GeneralProduct.EditQuoteItem;
using Orion.UI.ViewModel.Groundfos.EditQuoteItem;
using Orion.UI.ViewModel.Mavair.EditQuoteItem;
using Orion.UI.ViewModel.Multiaqua.EditQuoteItem;
using Orion.UI.ViewModel.PACE.EditQuoteItem;
using Orion.UI.ViewModel.Puroflux.EditQuoteItem;
using Orion.UI.ViewModel.Quantech.EditQuoteItem;
using Orion.UI.ViewModel.UvResources.EditQuoteItem;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel
{
    public class ItemListViewModel : BindableBase, IListViewModel
    {
        public IDialogCoordinator dialogCoordinator;
        private MessageService messageService;
        public CompanyService companyService;
        public WindowService windowService;
        public ItemService itemService;

        private ObservableCollection<IItem> _items;
        public ObservableCollection<IItem> Items
        {
            get => _items;
            set => SetProperty(ref _items, value);
        }

        private Quote _quote;
        public Quote Quote
        {
            get => _quote;
            set => SetProperty(ref _quote, value);
        }

        private ObservableCollection<Company> _companies;
        public ObservableCollection<Company> Companies
        {
            get => _companies;
            set => SetProperty(ref _companies, value);
        }

        private ObservableCollection<IItem> _CurrentItems;
        public ObservableCollection<IItem> CurrentItems
        {
            get => _CurrentItems;
            set => SetProperty(ref _CurrentItems, value);
        }

        private QuoteCompanies _quoteCompany;
        public QuoteCompanies QuoteCompany
        {
            get => _quoteCompany;
            set => SetProperty(ref _quoteCompany, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<string> EditItemsCommand { get; set; }
        public RelayCommand<IItem> MoveToStartCommand { get; set; }
        public RelayCommand<IItem> MoveToUpCommand { get; set; }
        public RelayCommand<IItem> DeleteItemCommand { get; set; }
        public RelayCommand<IItem> ShowItemTitlesCommand { get; set; }
        public RelayCommand<IItem> MoveToDownCommand { get; set; }
        public RelayCommand<IItem> MoveToEndCommand { get; set; }
        public RelayCommand<IItem> TotalPriceChangedCommand { get; set; }

        public Action<IItem> ShowTitlesRequested { get; set; } = delegate { };
        public Action<IListViewModel> DeleteItemListViewRequested { get; set; } = delegate { };

        public ItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.Items = items.ToObservableCollection();
            this.Quote = quote;
            this.Companies = companies.ToObservableCollection();

            LoadDataCommand = new RelayCommand(OnLoadData);
            EditItemsCommand = new RelayCommand<string>(OnEditItems);
            MoveToStartCommand = new RelayCommand<IItem>(OnMoveToStart);
            MoveToUpCommand = new RelayCommand<IItem>(OnMoveToUp);
            DeleteItemCommand = new RelayCommand<IItem>(OnDeleteItem);
            MoveToDownCommand = new RelayCommand<IItem>(OnMoveToDown);
            MoveToEndCommand = new RelayCommand<IItem>(OnMoveToEnd);
            TotalPriceChangedCommand = new RelayCommand<IItem>(OnTotalPriceChanged);
            ShowItemTitlesCommand = new RelayCommand<IItem>(OnShowTitles);

            companyService = new CompanyService();
            windowService = new WindowService();
            itemService = new ItemService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        public virtual void OnLoadData()
        {
        }

        public void OnMoveToStart(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            int sectionIndex = currentItems.IndexOf(item);
            int firstIndex = currentItems.IndexOf(currentItems.First());

            currentItems.Move(sectionIndex, firstIndex);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }

        public void OnMoveToUp(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            int oldIndex = currentItems.IndexOf(item);

            if (oldIndex == 0)
                return;

            currentItems.Move(oldIndex, oldIndex - 1);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }

        public virtual void OnDeleteItem(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            currentItems.Remove(item);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }

        public void OnMoveToDown(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            int oldIndex = currentItems.IndexOf(item);
            int lastIndex = currentItems.IndexOf(currentItems.Last());

            if (oldIndex == lastIndex)
                return;

            currentItems.Move(oldIndex, oldIndex + 1);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }
 
        public void OnMoveToEnd(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            int sectionIndex = currentItems.IndexOf(item);
            int lastIndex = currentItems.IndexOf(currentItems.Last());

            currentItems.Move(sectionIndex, lastIndex);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }

        public void OnItemsSaved(IList<IItem> items, ItemType itemType)
        {
            items.ToList().ForEach(x => x.HasTitles = x.Titles != null && x.Titles.Count() > 0);

            ObservableCollection<IItem> currentItems = GetSelectedItems(itemType);

            // Actualiza la propiedad actual en lugar de cambiar la referencia
            currentItems.Clear();
            foreach (var item in items)
            {
                currentItems.Add(item);
            }


            OnTotalPriceChanged(itemType);
        }

        public void OnTotalPriceChanged(IItem item)
        {
            string propertyName = VmHelper.GetItemListPropertyName(item);

            OnPropertyChange(propertyName);
        }

        public void OnTotalPriceChanged(ItemType itemType)
        {
            string propertyName = VmHelper.GetItemListPropertyName(itemType);

            OnPropertyChange(propertyName);
        }

        public ObservableCollection<IItem> GetSelectedItems(IItem item)
        {
            string propertyName = VmHelper.GetItemListPropertyName(item);

            PropertyInfo propertyInfo = GetType().GetProperty(propertyName);

            return (ObservableCollection<IItem>)propertyInfo.GetValue(this);
        }

        public ObservableCollection<IItem> GetSelectedItems(ItemType itemType)
        {
            string propertyName = VmHelper.GetItemListPropertyName(itemType);

            PropertyInfo propertyInfo = GetType().GetProperty(propertyName);

            return (ObservableCollection<IItem>)propertyInfo.GetValue(this);
        }

        public void OnEditItems(string itemsName)
        {
            ItemType itemType = VmHelper.GetItemType(itemsName);

            Type viewModelType = VmHelper.GetEditViewModelTypeForItemType(itemType);

            IEditItemViewModel viewModel = (IEditItemViewModel)Activator.CreateInstance(viewModelType, dialogCoordinator, Quote, GetSelectedItems(itemType), itemType);

            Product product = companyService.GetProduct(Companies, itemsName);
            viewModel.OnItemsSavedRequested += OnItemsSaved;
            windowService.EditItemsWndow(viewModel, $"Edit {product.Name}");
        }

        private void OnShowTitles(IItem item)
        {
            ShowTitlesRequested(item);
        }

        public virtual IList<IItem> GetItems()
        {
            return new ObservableCollection<IItem>();
        }
    }
}
