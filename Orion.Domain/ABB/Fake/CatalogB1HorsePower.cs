using Orion.Binding.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.ABB.Fake
{
    public class CatalogB1HorsePower : ValidatableBindableBase
    {

        private double _hp;
        public double Hp
        {
            get => _hp;
            set => SetProperty(ref _hp, value);
        }

        private bool _isSelected;
        public bool IsSelected
        {
            get => _isSelected;
            set => SetProperty(ref _isSelected, value);
        }
        public CatalogB1HorsePower(double hp)
        {
            this.Hp = hp;
        }
    }
}
