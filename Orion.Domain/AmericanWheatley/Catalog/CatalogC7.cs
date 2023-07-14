using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogAmericanWheatley
{
    public class CatalogC7 : Catalog
    {

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        [NotMapped]
        public override string Company { get => "American Wheatley"; }
        [NotMapped]
        public override string Product { get => "Tank Accessories"; }
        [NotMapped]
        public override string Index { get => "C7"; }

        public CatalogC7() : base()
        {
            Description = "";
        }
    }
}
