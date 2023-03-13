using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityCatalogQuantech
{
    // QUANTECH - Air Cooled Stock Post Coated
    public class CatalogA3 : Catalog
    {
        private string _unitSize;
        public string UnitSize
        {
            get => _unitSize;
            set => SetProperty(ref _unitSize, value);
        }

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _voltage;
        public string Voltage
        {
            get => _voltage;
            set => SetProperty(ref _voltage, value);
        }

        [NotMapped]
        public override string Company { get => "QUANTECH"; }
        [NotMapped]
        public override string Product { get => "Air Cooled Chillers Post Coated Condenser"; }
        [NotMapped]
        public override string Index { get => "a3"; }

        public CatalogA3() : base()
        {
            UnitSize = "";
            Description = "";
            Voltage = "";
        }
    }
}
