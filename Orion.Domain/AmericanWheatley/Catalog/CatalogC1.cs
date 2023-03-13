﻿using Orion.Binding.Binding;
using Orion.Domain.Entity;
using Orion.Helper.Extension;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalogAmericanWheatley
{
    // American Wheatley - Triple Duty Valves
    public class CatalogC1 : Catalog
    {
        [NotMapped]
        public override string Company { get => "American Wheatley"; }
        [NotMapped]
        public override string Product { get => "Triple Duty Valves"; }
        [NotMapped]
        public override string Index { get => "C1"; }

        public CatalogC1() : base()
        {
        }
    }
}

