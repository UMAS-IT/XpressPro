using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.UI.ViewModel
{
    public interface IListViewModel
    {
        ObservableCollection<IItem> Items { get; set; }
        ObservableCollection<Company> Companies { get; set; }
        Quote Quote { get; set; }
        QuoteCompanies QuoteCompany { get; set; }
    }
}
