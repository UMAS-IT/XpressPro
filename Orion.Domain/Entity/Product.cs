using Orion.Binding.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Entity
{
    public class Product: ValidatableBindableBase
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

        private string _index;
        public string Index
        {
            get => _index;
            set => SetProperty(ref _index, value);
        }

        private IList<DataSheet> _dataSheets;
        public IList<DataSheet> DataSheets
        {
            get => _dataSheets;
            set => SetProperty(ref _dataSheets, value);
        }

        private int _companyId;
        public int CompanyId
        {
            get => _companyId;
            set => SetProperty(ref _companyId, value);
        }

        private Company _comapy;
        public Company Company
        {
            get => _comapy;
            set => SetProperty(ref _comapy, value);
        }

        private bool _inService;
        public bool InService
        {
            get => _inService;
            set => SetProperty(ref _inService, value);
        }

        private string _color;
        public string Color
        {
            get => _color;
            set => SetProperty(ref _color, value);
        }

        public Product()
        {
            DataSheets = new ObservableCollection<DataSheet>();
        }
    }
}
