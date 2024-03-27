using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.PACE.Catalog
{
    public class CatalogJ1 : Entity.Catalog
    {
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        [NotMapped]
        public override string Company { get => "PACE AHU"; }
        [NotMapped]
        public override string Product { get => "Units"; }
        [NotMapped]
        public override string Index { get => "j1"; }

        public CatalogJ1() : base()
        {
            Description = "";
        }
    }
}
