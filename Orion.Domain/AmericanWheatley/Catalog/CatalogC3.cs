using Orion.Binding.Binding;
using Orion.Domain.AmericanWheatley.Related;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogAmericanWheatley
{
    // American Wheatley - Tanks
    public class CatalogC3 : Catalog
    {
        private string _partNumber;
        public string PartNumber
        {
            get => _partNumber;
            set => SetProperty(ref _partNumber, value);
        }

        private string _acceptableVolume;
        public string AcceptableVolume
        {
            get => _acceptableVolume;
            set => SetProperty(ref _acceptableVolume, value);
        }

        private string _diameterA;
        public string DiameterA
        {
            get => _diameterA;
            set => SetProperty(ref _diameterA, value);
        }

        private string _HeightB;
        public string HeightB
        {
            get => _HeightB;
            set => SetProperty(ref _HeightB, value);
        }

        private string _systemConnect;
        public string SystemConnect
        {
            get => _systemConnect;
            set => SetProperty(ref _systemConnect, value);
        }

        private string _weight;
        public string Weight
        {
            get => _weight;
            set => SetProperty(ref _weight, value);
        }

        private string _workingPressure;
        public string WorkingPressure
        {
            get => _workingPressure;
            set => SetProperty(ref _workingPressure, value);
        }

        private int? _catalogC3ProductTypeId;
        public int? CatalogC3ProductTypeId
        {
            get => _catalogC3ProductTypeId;
            set => SetProperty(ref _catalogC3ProductTypeId, value);
        }

        private CatalogC3ProductType _catalogC3ProductType;
        public CatalogC3ProductType CatalogC3ProductType
        {
            get => _catalogC3ProductType;
            set => SetProperty(ref _catalogC3ProductType, value);
        }

        [NotMapped]
        public override string Company { get => "American Wheatley"; }
        [NotMapped]
        public override string Product { get => "Tanks"; }
        [NotMapped]
        public override string Index { get => "C3"; }

        public CatalogC3() : base()
        {
            PartNumber = "";
            AcceptableVolume = "";
            DiameterA = "";
            HeightB = "";
            SystemConnect = "";
            Weight = "";
            WorkingPressure = "";
        }
    }
}
