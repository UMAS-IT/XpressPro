using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EnviroTec.Catalog
{
    public class CatalogR3 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Enviro-Tec"; }
        [NotMapped]
        public override string Product { get => "HLP"; }
        [NotMapped]
        public override string Index { get => "R3"; }

        public CatalogR3() : base()
        {
        }
    }
}
