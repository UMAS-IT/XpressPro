using MahApps.Metro.Controls.Dialogs;
using Orion.Binding.Binding;
using Orion.DataAccess.DataBase;
using Orion.DataAccess.Repository;
using Orion.DataAccess.Service;
using Orion.DataAccess.UnitOfWork;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using Orion.UI.Command;
using Orion.UI.Service;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using static Orion.Helper.Misc.GV;

namespace Orion.UI.ViewModel.Quantech.CatalogList
{
    public class CatalogA1ListViewModel : MasterCatalogListViewModel
    {
        //private readonly TestService testService;

        public CatalogA1ListViewModel(IDialogCoordinator dialogCoordinator, ItemType itemType) : base(dialogCoordinator, itemType)
        {
            //testService = new TestService();
        }

        //public override async Task OnLoadData()
        //{
        //    CatalogsBase = testService.CatalogA1Repository.GetAll().ToList<ICatalog>().ToObservableCollection();
        //    Catalogs = CatalogsBase;
        //}
    }
}
