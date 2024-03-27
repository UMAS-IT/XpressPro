using Orion.Domain.ABOVEAIR.Catalog;
using Orion.Domain.Entity;
using Orion.Domain.PVI.Catalog;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.PVI.Item
{
    public class ItemX4 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _weight;
        public string Weight
        {
            get => _weight;
            set => SetProperty(ref _weight, value);
        }

        private int? _catalogX4Id;
        public int? CatalogX4Id
        {
            get => _catalogX4Id;
            set => SetProperty(ref _catalogX4Id, value);
        }

        private CatalogX4 _catalogX4;
        public CatalogX4 CatalogX4
        {
            get => _catalogX4;
            set => SetProperty(ref _catalogX4, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogX4; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogX4Id; } }

        public ItemX4() : base()
        {
            Model = "";
            Weight = "";
        }
    }
}
