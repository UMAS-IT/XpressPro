using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.AERCO.Related
{
    public class ItemO : Entity.Item
    {
        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _fuelType;
        public string FuelType
        {
            get => _fuelType;
            set => SetProperty(ref _fuelType, value);
        }

        private string _capacity;
        public string Capacity
        {
            get => _capacity;
            set => SetProperty(ref _capacity, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        public ItemO() : base()
        {
            Model = "";
            FuelType = "";
            Capacity = "";
            Voltage = "";
        }
    }
}
