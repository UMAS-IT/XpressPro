using Orion.Binding.Binding;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Entity
{
    public class DataSheet : ValidatableBindableBase
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private int _productId;
        public int ProductId
        {
            get => _productId;
            set => SetProperty(ref _productId, value);
        }

        private Product _product;
        public Product Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        private IList<Title> _titles;
        public IList<Title> Titles
        {
            get => _titles;
            set => SetProperty(ref _titles, value);
        }

        private bool _writed;
        [NotMapped]
        public bool Writed
        {
            get => _writed;
            set => SetProperty(ref _writed, value);
        }

        public DataSheet()
        {
            Titles = new ObservableCollection<Title>();
        }
    }
}
