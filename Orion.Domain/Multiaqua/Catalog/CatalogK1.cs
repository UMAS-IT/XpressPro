using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Multiaqua.Catalog
{
    public class CatalogK1 : Entity.Catalog
    {
        private string _Description;
        public string Description
        {
            get => _Description;
            set => SetProperty(ref _Description, value);
        }

        [NotMapped]
        public override string Company { get => "Multiaqua"; }
        [NotMapped]
        public override string Product { get => "Chillers"; }
        [NotMapped]
        public override string Index { get => "k1"; }

        public CatalogK1() : base()
        {
            Description = "";
        }
    }
}
