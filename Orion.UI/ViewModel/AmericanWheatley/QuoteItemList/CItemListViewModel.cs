using MahApps.Metro.Controls.Dialogs;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel.AmericanWheatley.QuoteItemList
{
    public class CItemListViewModel : ItemListViewModel
    {
        public CItemListViewModel(IDialogCoordinator dialogCoordinator, IList<IItem> items, Quote quote, IList<Company> companies) : base(dialogCoordinator, items, quote, companies)
        {
        }
    }
}
