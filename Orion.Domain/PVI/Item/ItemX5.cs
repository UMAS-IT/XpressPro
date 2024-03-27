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
    public class ItemX5 : Entity.Item
    {
        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _Weight;
        public string Weight
        {
            get => _Weight;
            set => SetProperty(ref _Weight, value);
        }

        private int? _catalogX5Id;
        public int? CatalogX5Id
        {
            get => _catalogX5Id;
            set => SetProperty(ref _catalogX5Id, value);
        }

        private CatalogX5 _catalogX5;
        public CatalogX5 CatalogX5
        {
            get => _catalogX5;
            set => SetProperty(ref _catalogX5, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogX5; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogX5Id; } }

        public ItemX5() : base()
        {
            Model = "";
            Weight = "";
        }
    }
}
