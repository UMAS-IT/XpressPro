using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EnviroTec.Related
{
    public class ItemR : Entity.Item
    {
        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _cfm;
        public string Cfm
        {
            get => _cfm;
            set => SetProperty(ref _cfm, value);
        }

        private string _chwCapacity;
        public string ChwCapacity
        {
            get => _chwCapacity;
            set => SetProperty(ref _chwCapacity, value);
        }

        private string _chwRowsFpi;
        public string ChwRowsFpi
        {
            get => _chwRowsFpi;
            set => SetProperty(ref _chwRowsFpi, value);
        }

        private string _hwCapacity;
        public string HwCapacity
        {
            get => _hwCapacity;
            set => SetProperty(ref _hwCapacity, value);
        }

        private string _hwRowsFpi;
        public string HwRowsFpi
        {
            get => _hwRowsFpi;
            set => SetProperty(ref _hwRowsFpi, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        public ItemR() : base()
        {
            Model = "";
            Cfm = "";
            ChwCapacity = "";
            ChwRowsFpi = "";
            HwCapacity = "";
            HwRowsFpi = "";
            Voltage = "";
        }
    }
}
