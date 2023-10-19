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
using System.Threading.Tasks;

namespace Orion.UI.ViewModel
{
    public class TitleViewModel : BindableBase
    {
        private MessageService messageService;
        private TitleService titleService;
        private IDialogCoordinator dialogCoordinator;
        private DataSheetService dataSheetService;

        private ObservableCollection<Title> _titles;
        public ObservableCollection<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private DataSheet _dataSheet;
        public DataSheet DataSheet
        {
            get => _dataSheet;
            set => SetProperty(ref _dataSheet, value);
        }

        private Product _product;
        public Product Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        private bool _SelectionMode;
        public bool SelectionMode
        {
            get => _SelectionMode;
            set => SetProperty(ref _SelectionMode, value);
        }

        public RelayCommand<Title> DeleteTitleCommand { get; set; }
        public RelayCommand<ITexteable> HighlightTextCommand { get; set; }
        public RelayCommand<Title> AddSpecCommand { get; set; }
        public RelayCommand<Spec> DeleteSpecCommand { get; set; }
        public RelayCommand AddTitleCommand { get; set; }
        public RelayCommand UpdateTitlesCommand { get; set; }
        public RelayCommand DeleteDataSheetCommand { get; set; }

        public Action<DataSheet> OnDataSheetDeletedRequested = delegate { };

        public TitleViewModel(IDialogCoordinator dialogCoordinator, DataSheet dataSheet, Product product, bool selectionMode = false)
        {
            this.dialogCoordinator = dialogCoordinator;
            this.Product = product;
            this.DataSheet = dataSheet;
            this.SelectionMode = selectionMode;
            Titles = dataSheet.Titles.ToObservableCollection();

            DeleteTitleCommand = new RelayCommand<Title>(OnDeleteTitle);
            DeleteSpecCommand = new RelayCommand<Spec>(OnDeleteSpec);
            AddSpecCommand = new RelayCommand<Title>(OnAddSpec);
            AddTitleCommand = new RelayCommand(OnAddTitle);
            UpdateTitlesCommand = new RelayCommand(OnUpdateTitles);
            DeleteDataSheetCommand = new RelayCommand(OnDeleteDataSheet);
            HighlightTextCommand = new RelayCommand<ITexteable>(OnHighlightText);

            titleService = new TitleService();
            dataSheetService = new DataSheetService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OnHighlightText(ITexteable texteable)
        {
            texteable.Highlighted = !texteable.Highlighted;
        }

        private async void OnDeleteDataSheet()
        {
            if (DataSheet.Id != 0)
            {
                if (await dialogCoordinator.ShowMessageAsync(this, "Delete Data Sheert", $"Are you sure to delete this data sheet?", MessageDialogStyle.AffirmativeAndNegative) != MessageDialogResult.Affirmative)
                    return;

                try
                {
                    await messageService.StartMessage("Data Sheet", "Deleting data sheet, please wait...");

                        dataSheetService.DeleteDataSheet(DataSheet);

                        await messageService.EndMessage("Data Sheet", "Data sheet has been deleted");
                }
                catch (Exception ex)
                {
                    await messageService.ExceptionMessage(ex);
                    return;
                }
            }


            OnDataSheetDeletedRequested(DataSheet);
        }

        private async void OnUpdateTitles()
        {
            try
            {
                await messageService.StartMessage("Data Sheet", "Saving data sheet, please wait...");


                if (!await CanUpdateTitles())
                    return;

                if (DataSheet.Id == 0)
                    DataSheet = dataSheetService.CreateDataSheet(Titles, Product);
                else
                Titles = titleService.UpdataTitlesFromDataSheet(DataSheet, Titles).ToObservableCollection();

                await messageService.EndMessage("Data Sheet", "Data Sheet has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
        }

        private async Task<bool> CanUpdateTitles()
        {
            if (Titles.Any(x => string.IsNullOrWhiteSpace(x.Name)))
            {
                await messageService.ResultMessage("Error", "Some titles name are empty, please review your titles information");
                return false;
            }

            if (Titles.SelectMany(x => x.Specs).Any(x => string.IsNullOrWhiteSpace(x.Name)))
            {
                await messageService.ResultMessage("Error", "Some specs name are empty, please review your specs information");
                return false;
            }

            return true;
        }

        private void OnAddTitle()
        {
            Titles.Add(new Title());
        }

        private void OnAddSpec(Title title)
        {
            title.Specs.Add(new Spec() { Title = title });
        }

        private void OnDeleteTitle(Title title)
        {
            if (title is null)
                return;

            Titles.Remove(title);
        }

        private void OnDeleteSpec(Spec spec)
        {
            if (spec is null)
                return;

            int titleIndex = Titles.IndexOf(spec.Title);

            Title selectedTitle = Titles[titleIndex];

            selectedTitle.Specs.Remove(spec);
        }

        public static explicit operator TitleViewModel(List<BindableBase> v)
        {
            throw new NotImplementedException();
        }
    }
}
