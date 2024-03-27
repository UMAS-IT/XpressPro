using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Multiaqua.Catalog
{
    public class CatalogK3 : Entity.Catalog
    {

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        [NotMapped]
        public override string Company { get => "Multiaqua"; }
        [NotMapped]
        public override string Product { get => "Accesories And Freight"; }
        [NotMapped]
        public override string Index { get => "k3"; }

        public CatalogK3() : base()
        {
            Description = "";
        }
    }
}
