using Orion.Domain.Entity;
using Orion.Domain.Nortek.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Nortek.Item
{
    public class ItemT3 : Entity.Item
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

        private string _tsp;
        public string Tsp
        {
            get => _tsp;
            set => SetProperty(ref _tsp, value);
        }

        private string _bhp;
        public string Bhp
        {
            get => _bhp;
            set => SetProperty(ref _bhp, value);
        }

        private string _totalHp;
        public string TotalHp
        {
            get => _totalHp;
            set => SetProperty(ref _totalHp, value);
        }

        private string _vfdHp;
        public string VfdHp
        {
            get => _vfdHp;
            set => SetProperty(ref _vfdHp, value);
        }

        private string _activeFans;
        public string ActiveFans
        {
            get => _activeFans;
            set => SetProperty(ref _activeFans, value);
        }

        private string _fanArrays;
        public string FanArrays
        {
            get => _fanArrays;
            set => SetProperty(ref _fanArrays, value);
        }

        private string _cell;
        public string Cell
        {
            get => _cell;
            set => SetProperty(ref _cell, value);
        }

        private string _array;
        public string Array
        {
            get => _array;
            set => SetProperty(ref _array, value);
        }

        private int? _catalogT3Id;
        public int? CatalogT3Id
        {
            get => _catalogT3Id;
            set => SetProperty(ref _catalogT3Id, value);
        }

        private CatalogT3 _catalogT3;
        public CatalogT3 CatalogT3
        {
            get => _catalogT3;
            set => SetProperty(ref _catalogT3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogT3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogT3Id; } }

        public ItemT3() : base()
        {
            Model = "";
            Cfm = "";
            Tsp = "";
            Bhp = "";
            TotalHp = "";
            VfdHp = "";
            ActiveFans = "";
            FanArrays = "";
            Cell = "";
            Array = "";
        }
    }
}
