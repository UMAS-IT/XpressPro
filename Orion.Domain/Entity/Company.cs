using Orion.Binding.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Entity
{
    public class Company : ValidatableBindableBase
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _product;
        public string Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        private string _index;
        public string Index
        {
            get => _index;
            set => SetProperty(ref _index, value);
        }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        public Company()
        {
            Titles = new ObservableCollection<Title>();
        }
    }
}
