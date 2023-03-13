using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogABB
{
    // ABB - Accesories
    public class CatalogB5 : Catalog
    {

        private string _description;
        public string Description
        {
            get => _description;
            set => SetProperty(ref _description, value);
        }

        [NotMapped]
        public override string Company { get => "ABB"; }
        [NotMapped]
        public override string Product { get => "Accesories"; }
        [NotMapped]
        public override string Index { get => "b5"; }

        public CatalogB5() : base()
        {
            Description = "";
        }
    }
}
