using Orion.Domain.ABOVEAIR.Catalog;
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
    public class ItemT1 : Entity.Item
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

        private string _size;
        public string Size
        {
            get => _size;
            set => SetProperty(ref _size, value);
        }

        private string _rows;
        public string Rows
        {
            get => _rows;
            set => SetProperty(ref _rows, value);
        }

        private string _fpi;
        public string Fpi
        {
            get => _fpi;
            set => SetProperty(ref _fpi, value);
        }

        private int? _catalogT1Id;
        public int? CatalogT1Id
        {
            get => _catalogT1Id;
            set => SetProperty(ref _catalogT1Id, value);
        }

        private CatalogT1 _catalogT1;
        public CatalogT1 CatalogT1
        {
            get => _catalogT1;
            set => SetProperty(ref _catalogT1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogT1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogT1Id; } }

        public ItemT1() : base()
        {
            Model = "";
            Cfm = "";
            Size = "";
            Rows = "";
            Fpi = "";
        }
    }
}
