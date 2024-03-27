using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogAmericanWheatley
{
    // American Wheatley - BFT Tanks
    public class CatalogC5 : Catalog
    {
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        private string _volume;
        public string Volume
        {
            get => _volume;
            set => SetProperty(ref _volume, value);
        }

        private string _heightA;
        public string HeightA
        {
            get => _heightA;
            set => SetProperty(ref _heightA, value);
        }

        private string _diameterB;
        public string DiameterB
        {
            get => _diameterB;
            set => SetProperty(ref _diameterB, value);
        }

        private string _Weight;
        public string Weight
        {
            get => _Weight;
            set => SetProperty(ref _Weight, value);
        }

        [NotMapped]
        public override string Company { get => "American Wheatley"; }
        [NotMapped]
        public override string Product { get => "BFT Tanks"; }
        [NotMapped]
        public override string Index { get => "C5"; }

        public CatalogC5() : base()
        {
            Description = "";
            Volume = "";
            HeightA = "";
            DiameterB = "";
            Weight = "";
        }
    }
}
