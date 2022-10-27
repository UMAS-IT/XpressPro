using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.EntityAirCooledCondenser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityPump
{
    public class UnitItemPump : ValidatableBindableBase
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

        private int _itemPumpId;
        public int ItemPumpId
        {
            get => _itemPumpId;
            set => SetProperty(ref _itemPumpId, value);
        }

        private ItemPump _itemPump;
        public ItemPump ItemPump
        {
            get => _itemPump;
            set => SetProperty(ref _itemPump, value);
        }
    }
}
