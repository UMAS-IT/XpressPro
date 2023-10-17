using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.Puroflux.QuoteItemList
{
    public class DItemListViewModel : ItemListViewModel
    {
        public DItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }
    }
}
