using MahApps.Metro.Controls.Dialogs;
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

        //    CatalogsBase.Union(testService.CatalogA2Repository.GetAll().ToList<ICatalog>().ToObservableCollection());

        //    Catalogs = CatalogsBase;

        //}
    }
}
