using Orion.Domain.Entity;
using Orion.Domain.EntityCatalogGeneralProduct;
using Orion.Domain.EntityCatalogGroundfos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityItemGeneralProduct
{
    public class ItemL1 : Item
    {

        private string _model;
        public string Model
        {
            get => _model;
            set => SetProperty(ref _model, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private int? _catalogL1Id;
        public int? CatalogL1Id
        {
            get => _catalogL1Id;
            set => SetProperty(ref _catalogL1Id, value);
        }

        private CatalogL1 _catalogL1;
        public CatalogL1 CatalogL1
        {
            get => _catalogL1;
            set => SetProperty(ref _catalogL1, value);
        }

        [NotMapped]
        public override ICatalog Catalog { get { return CatalogL1; } }

        [NotMapped]
        public override int? CatalogId { get { return CatalogL1Id; } }

        public ItemL1() : base()
        {
            Model = "TBD";
            Description = "TBD";
            OverridePrice = true;
        }
    }
}
