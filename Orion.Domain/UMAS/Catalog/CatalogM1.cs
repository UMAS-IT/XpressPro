using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.UMAS.Catalog
{
    public class CatalogM1 :Entity.Catalog
    {
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        [NotMapped]
        public override string Company { get => "UMAS AHU"; }
        [NotMapped]
        public override string Product { get => "Units"; }
        [NotMapped]
        public override string Index { get => "M1"; }

        public CatalogM1() : base()
        {
            Description = "";
        }
    }
}
