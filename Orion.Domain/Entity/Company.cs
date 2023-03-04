﻿using Orion.Binding.Binding;
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

        private IList<Product> _products;
        public IList<Product> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }

        public Company()
        {
            Products = new ObservableCollection<Product>();
        }
    }
}
