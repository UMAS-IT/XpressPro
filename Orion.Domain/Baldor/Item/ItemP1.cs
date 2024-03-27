using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Baldor.Catalog;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Baldor.Item
{
    public class ItemP1 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _frame;
        public string Frame
        {
            get => _frame;
            set => SetProperty(ref _frame, value);
        }

        private string _hp;
        public string Hp
        {
            get => _hp;
            set => SetProperty(ref _hp, value);
        }

        private string _rpm;
        public string Rpm
        {
            get => _rpm;
            set => SetProperty(ref _rpm, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        private string _enclosure;
        public string Enclosure
        {
            get => _enclosure;
            set => SetProperty(ref _enclosure, value);
        }

        private string _efficiency;
        public string Efficiency
        {
            get => _efficiency;
            set => SetProperty(ref _efficiency, value);
        }

        private string _weight;
        public string Weight
        {
            get => _weight;
            set => SetProperty(ref _weight, value);
        }

        private int? _catalogP1Id;
        public int? CatalogP1Id
        {
            get => _catalogP1Id;
            set => SetProperty(ref _catalogP1Id, value);
        }

        private CatalogP1 _catalogP1;
        public CatalogP1 CatalogP1
        {
            get => _catalogP1;
            set => SetProperty(ref _catalogP1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogP1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogP1Id; } }

        public ItemP1() : base()
        {
            Model = "";
            Frame = "";
            Hp = "";
            Rpm = "";
            Voltage = "";
            Enclosure = "";
            Efficiency = "";
            Weight = "";
        }
    }
}
