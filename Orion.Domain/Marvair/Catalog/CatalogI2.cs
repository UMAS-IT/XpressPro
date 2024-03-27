using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Marvair.Catalog
{
    public class CatalogI2 : Entity.Catalog
    {
        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        [NotMapped]
        public override string Company { get => "Marvair"; }
        [NotMapped]
        public override string Product { get => "Accesories"; }
        [NotMapped]
        public override string Index { get => "i2"; }

        public CatalogI2() : base()
        {
            Description = "";
        }
    }
}
