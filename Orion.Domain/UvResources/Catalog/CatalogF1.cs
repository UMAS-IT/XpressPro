using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Domain.UvResources.Related;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogUvResources
{
    // UV Resources
    public class CatalogF1 : Catalog
    {
        private string _partNumber;
        public string PartNumber
        {
            get => _partNumber;
            set => SetProperty(ref _partNumber, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private int? _catalogF1ProductTypeId;
        public int? CatalogF1ProductTypeId
        {
            get => _catalogF1ProductTypeId;
            set => SetProperty(ref _catalogF1ProductTypeId, value);
        }

        private CatalogF1ProductType _catalogF1ProductType;
        public CatalogF1ProductType CatalogF1ProductType
        {
            get => _catalogF1ProductType;
            set => SetProperty(ref _catalogF1ProductType, value);
        }

        [NotMapped]
        public override string Company { get => "UV Resources"; }
        [NotMapped]
        public override string Product { get => "UV"; }
        [NotMapped]
        public override string Index { get => "f1"; }

        public CatalogF1() : base()
        {
            PartNumber = "";
            Description = "";
        }
    }
}
