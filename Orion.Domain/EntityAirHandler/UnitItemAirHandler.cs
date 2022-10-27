using Orion.Binding.Binding;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityAirHandler
{
    public class UnitItemAirHandler : ValidatableBindableBase
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

        private int _itemAirHandlerId;
        public int ItemAirHandlerId
        {
            get => _itemAirHandlerId;
            set => SetProperty(ref _itemAirHandlerId, value);
        }

        private ItemAirHandler _itemAirHandlerUnit;
        public ItemAirHandler ItemAirHandlerUnit
        {
            get => _itemAirHandlerUnit;
            set => SetProperty(ref _itemAirHandlerUnit, value);
        }
    }
}
