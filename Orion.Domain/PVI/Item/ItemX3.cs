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
    public class ItemX3 : Entity.Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _tank;
        public string Tank
        {
            get => _tank;
            set => SetProperty(ref _tank, value);
        }

        private string _connection;
        public string Connection
        {
            get => _connection;
            set => SetProperty(ref _connection, value);
        }

        private string _location;
        public string Location
        {
            get => _location;
            set => SetProperty(ref _location, value);
        }

        private int? _catalogX3Id;
        public int? CatalogX3Id
        {
            get => _catalogX3Id;
            set => SetProperty(ref _catalogX3Id, value);
        }

        private CatalogX3 _catalogX3;
        public CatalogX3 CatalogX3
        {
            get => _catalogX3;
            set => SetProperty(ref _catalogX3, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogX3; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogX3Id; } }

        public ItemX3() : base()
        {
            Model = "";
            Tank = "";
            Connection = "";
            Location = "";
        }
    }
}
