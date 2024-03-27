using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Groundfos.Related
{
    public class ItemE : Item
    {
        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _gpm;
        public string Gpm
        {
            get => _gpm;
            set => SetProperty(ref _gpm, value);
        }

        private string _tdh;
        public string Tdh
        {
            get => _tdh;
            set => SetProperty(ref _tdh, value);
        }

        private string _hp;
        public string Hp
        {
            get => _hp;
            set => SetProperty(ref _hp, value);
        }

        private string _motor;
        public string Motor
        {
            get => _motor;
            set => SetProperty(ref _motor, value);
        }

        private string _rpm;
        public string Rpm
        {
            get => _rpm;
            set => SetProperty(ref _rpm, value);
        }

        private string _electrical;
        public string Electrical
        {
            get => _electrical;
            set => SetProperty(ref _electrical, value);
        }

        public ItemE() : base()
        {
            Model = "TBD";
            Gpm = "";
            Tdh = "";
            Hp = "";
            Motor = "TEFC/ODP";
            Rpm = "";
            Electrical = "";
            OverridePrice = true;
        }
    }
}
