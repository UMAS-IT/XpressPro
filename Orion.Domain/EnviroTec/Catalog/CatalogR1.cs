using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EnviroTec.Catalog
{
    public class CatalogR1 : Entity.Catalog
    {
        [NotMapped]
        public override string Company { get => "Enviro-Tec"; }
        [NotMapped]
        public override string Product { get => "HDD"; }
        [NotMapped]
        public override string Index { get => "R1"; }

        public CatalogR1() : base()
        {
        }
    }
}
