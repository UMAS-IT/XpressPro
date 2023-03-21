
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.Marvair
{
    public class CatalogI1 : Orion.Domain.Entity.Catalog
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

        [NotMapped]
        public override string Company { get => "Marvair"; }
        [NotMapped]
        public override string Product { get => "Wall Mount AC/HP"; }
        [NotMapped]
        public override string Index { get => "i1"; }

        public CatalogI1() : base()
        {
            UnitSize = "";
            Description = "";
        }
    }
}
