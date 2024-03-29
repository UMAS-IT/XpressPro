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

namespace Orion.UI.ViewModel
{
    public class TitleFromItemViewModel : BindableBase
    {
        private MessageService messageService;
        private TitleService titleService;

        private IItem _item;
        public IItem Item
        {
            get => _item;
            set => SetProperty(ref _item, value);
        }

        private ObservableCollection<Title> _titles;
        public ObservableCollection<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        public RelayCommand LoadDataCommand { get; set; }
        public RelayCommand<Title> DeleteTitleCommand { get; set; }
        public RelayCommand<Title> AddSpecCommand { get; set; }
        public RelayCommand<Spec> DeleteSpecCommand { get; set; }
        public RelayCommand AddTitleCommand { get; set; }
        public RelayCommand UpdateTitlesCommand { get; set; }
        public RelayCommand BackFromTitlesCommand { get; set; }

        public Action BackFromItemTitlesRequested = delegate { };

        public Action<IList<Title>, IItem> BackFromUpdateItemTitlesRequested = delegate { };

        public TitleFromItemViewModel(IDialogCoordinator dialogCoordinator, IItem item)
        {
            Item = item;

            LoadDataCommand = new RelayCommand(OnLoadData);
            DeleteTitleCommand = new RelayCommand<Title>(OnDeleteTitle);
            DeleteSpecCommand = new RelayCommand<Spec>(OnDeleteSpec);
            AddSpecCommand = new RelayCommand<Title>(OnAddSpec);
            AddTitleCommand = new RelayCommand(OnAddTitle);
            UpdateTitlesCommand = new RelayCommand(OnUpdateTitles);
            BackFromTitlesCommand = new RelayCommand(OkBackFromTitles);

            titleService = new TitleService();
            messageService = new MessageService(dialogCoordinator, this);
        }

        private void OkBackFromTitles()
        {
            BackFromItemTitlesRequested();
        }

        private async void OnUpdateTitles()
        {
            try
            {
                await messageService.StartMessage("Item Specs", "Saving item specs, please wait...");


                if (!await CanUpdateTitles())
                    return;

                Titles = titleService.UpdateTitlesFromItem(Item, Titles).ToObservableCollection();

                await messageService.EndMessage("Item Specs", "Item specs has been saved");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
                return;
            }
            BackFromUpdateItemTitlesRequested(Titles, Item);
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

        private async void OnLoadData()
        {
            try
            {
                await messageService.StartMessage("Catalog Specs", "Loading catalog specs, please wait...");

                Titles = titleService.GetTitlesFromItem(Item).ToObservableCollection();

                await messageService.EndMessage("Catalog Specs", "Catalog specs has been loaded");
            }
            catch (Exception ex)
            {
                await messageService.ExceptionMessage(ex);
            }
        }
    }
}
