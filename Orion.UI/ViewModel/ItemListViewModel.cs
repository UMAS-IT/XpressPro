using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.Service;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.Helper.Misc;
using Orion.UI.Command;
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

            companyService = new CompanyService();
            windowService = new WindowService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        public virtual void OnLoadData()
        {
        }

        public virtual void OnMoveToStart(IItem item)
        {
            if (item is null)
                return;

            ObservableCollection<IItem> currentItems = GetSelectedItems(item);

            int sectionIndex = currentItems.IndexOf(item);
            int firstIndex = currentItems.IndexOf(currentItems.First());

            currentItems.Move(sectionIndex, firstIndex);
            currentItems.ToList().ForEach(s => s.DesignIndex = currentItems.IndexOf(s));
        }

        public virtual void OnMoveToUp(IItem item)
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

        public virtual void OnMoveToDown(IItem item)
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
 
        public virtual void OnMoveToEnd(IItem item)
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

        public virtual void OnTotalPriceChanged(IItem item)
        {
            string propertyName = GetItemListPropertyName(item);

            OnPropertyChange(propertyName);
        }

        public virtual void OnTotalPriceChanged(ItemType itemType)
        {
            string propertyName = GetItemListPropertyName(itemType);

            OnPropertyChange(propertyName);
        }

        public ObservableCollection<IItem> GetSelectedItems(IItem item)
        {
            string propertyName = GetItemListPropertyName(item);

            PropertyInfo propertyInfo = GetType().GetProperty(propertyName);

            return (ObservableCollection<IItem>)propertyInfo.GetValue(this);
        }

        public ObservableCollection<IItem> GetSelectedItems(ItemType itemType)
        {
            string propertyName = GetItemListPropertyName(itemType);

            PropertyInfo propertyInfo = GetType().GetProperty(propertyName);

            return (ObservableCollection<IItem>)propertyInfo.GetValue(this);
        }

        public string GetItemListPropertyName(IItem item)
        {
            return item.GetType().Name + "s";
        }

        public string GetItemListPropertyName(ItemType itemType)
        {
            return itemType.ToString() + "s";
        }

        public Type GetEditViewModelTypeForItemType(ItemType itemType)
        {
            // Crea un diccionario que mapee ItemType a su tipo de ViewModel correspondiente
            Dictionary<ItemType, Type> viewModelTypeMap = new Dictionary<ItemType, Type>
    {
        { ItemType.ItemA1, typeof(EditA1ItemViewModel) },
        { ItemType.ItemA2, typeof(EditA2ItemViewModel) },
        { ItemType.ItemA3, typeof(EditA3ItemViewModel) },
        { ItemType.ItemA4, typeof(EditA4ItemViewModel) },

        { ItemType.ItemB1, typeof(EditB1ItemViewModel) },
        { ItemType.ItemB2, typeof(EditB2ItemViewModel) },
        { ItemType.ItemB3, typeof(EditB3ItemViewModel) },
        { ItemType.ItemB4, typeof(EditB4ItemViewModel) },
        { ItemType.ItemB5, typeof(EditB5ItemViewModel) },

        { ItemType.ItemC1, typeof(EditC1ItemViewModel) },
        { ItemType.ItemC2, typeof(EditC2ItemViewModel) },
        { ItemType.ItemC3, typeof(EditC3ItemViewModel) },
        { ItemType.ItemC4, typeof(EditC4ItemViewModel) },
        { ItemType.ItemC5, typeof(EditC5ItemViewModel) },
        { ItemType.ItemC6, typeof(EditC6ItemViewModel) },
        { ItemType.ItemC7, typeof(EditC7ItemViewModel) },

        { ItemType.ItemD1, typeof(EditD1ItemViewModel) },
        { ItemType.ItemD2, typeof(EditD2ItemViewModel) },

        { ItemType.ItemE1, typeof(EditE1ItemViewModel) },
        { ItemType.ItemE2, typeof(EditE2ItemViewModel) },
        { ItemType.ItemE3, typeof(EditE3ItemViewModel) },
        { ItemType.ItemE4, typeof(EditE4ItemViewModel) },
        { ItemType.ItemE5, typeof(EditE5ItemViewModel) },
        { ItemType.ItemE6, typeof(EditE6ItemViewModel) },
        { ItemType.ItemE7, typeof(EditE7ItemViewModel) },

        { ItemType.ItemF1, typeof(EditF1ItemViewModel) },

        { ItemType.ItemG1, typeof(EditG1ItemViewModel) },
        { ItemType.ItemG2, typeof(EditG2ItemViewModel) },
        { ItemType.ItemG3, typeof(EditG3ItemViewModel) },
        { ItemType.ItemG4, typeof(EditG4ItemViewModel) },
        { ItemType.ItemG5, typeof(EditG5ItemViewModel) },
        { ItemType.ItemG6, typeof(EditG6ItemViewModel) },

        { ItemType.ItemH1, typeof(EditH1ItemViewModel) },
        { ItemType.ItemH2, typeof(EditH2ItemViewModel) },
        { ItemType.ItemH3, typeof(EditH3ItemViewModel) },
        { ItemType.ItemH4, typeof(EditH4ItemViewModel) },
        { ItemType.ItemH5, typeof(EditH5ItemViewModel) },

        { ItemType.ItemI1, typeof(EditI1ItemViewModel) },
        { ItemType.ItemI2, typeof(EditI2ItemViewModel) },

        { ItemType.ItemJ1, typeof(EditJ1ItemViewModel) },

        { ItemType.ItemK1, typeof(EditK1ItemViewModel) },
        { ItemType.ItemK2, typeof(EditK2ItemViewModel) },
        { ItemType.ItemK3, typeof(EditK3ItemViewModel) },

        { ItemType.ItemL1, typeof(EditL1ItemViewModel) }
    };

            // Verifica si el ItemType está en el diccionario, y si es así, devuelve el tipo de ViewModel correspondiente
            if (viewModelTypeMap.ContainsKey(itemType))
            {
                return viewModelTypeMap[itemType];
            }

            // Si el ItemType no se encuentra en el diccionario, puedes manejarlo según tus necesidades.
            return null; // Tipo no compatible
        }

        public void OnEditItems(string itemsName)
        {

            ItemType itemType = GV.GetItemType(itemsName);

            Type viewModelType = GetEditViewModelTypeForItemType(itemType);

            IEditItemViewModel viewModel = (IEditItemViewModel)Activator.CreateInstance(viewModelType, dialogCoordinator, Quote, GetSelectedItems(itemType), itemType);

            Product product = companyService.GetProduct(Companies, itemsName);
            viewModel.OnItemsSavedRequested += OnItemsSaved;
            windowService.EditItemsWndow(viewModel, $"Edit {product.Name}");
        }
    }
}
