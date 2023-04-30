using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.BACClosedLoopTowers.Related
{
    public class ItemH : Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _flowRate;
        public string FlowRate
        {
            get => _flowRate;
            set => SetProperty(ref _flowRate, value);
        }

        private string _waterTemp;
        public string WaterTemp
        {
            get => _waterTemp;
            set => SetProperty(ref _waterTemp, value);
        }

        private string _designWB;
        public string DesignWB
        {
            get => _designWB;
            set => SetProperty(ref _designWB, value);
        }

        private string _fluidPressureDrop;
        public string FluidPressureDrop
        {
            get => _fluidPressureDrop;
            set => SetProperty(ref _fluidPressureDrop, value);
        }

        private string _fanMotors;
        public string FanMotors
        {
            get => _fanMotors;
            set => SetProperty(ref _fanMotors, value);
        }

        private string _pumpMotor;
        public string PumpMotor
        {
            get => _pumpMotor;
            set => SetProperty(ref _pumpMotor, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }
        public ItemH() : base()
        {
            Model = "TBD";
            FlowRate = "";
            WaterTemp = "";
            DesignWB = "";
            FluidPressureDrop = "";
            FanMotors = "";
            PumpMotor = "";
            Voltage = "";
            OverridePrice = true;
        }
    }
}
