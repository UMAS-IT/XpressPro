using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityAirCooledCondenser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityAirCooledChiller
{
    public class UnitItemAirCooledChiller : ValidatableBindableBase
    {
        private int _unitId;
        public int UnitId
        {
            get => _unitId;
            set => SetProperty(ref _unitId, value);
        }

        private Unit _unit;
        public Unit Unit
        {
            get => _unit;
            set => SetProperty(ref _unit, value);
        }

        private int _itemAirCooledChillerId;
        public int ItemAirCooledChillerId
        {
            get => _itemAirCooledChillerId;
            set => SetProperty(ref _itemAirCooledChillerId, value);
        }

        private ItemAirCooledChiller _itemAirCooledChiller;
        public ItemAirCooledChiller ItemAirCooledChiller
        {
            get => _itemAirCooledChiller;
            set => SetProperty(ref _itemAirCooledChiller, value);
        }
    }
}
