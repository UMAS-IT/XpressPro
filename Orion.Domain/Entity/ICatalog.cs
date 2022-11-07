﻿using Orion.Binding.Interfaces;
using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Entity
{
    public interface ICatalog : IEntity, IPrice
    {
        string Model { get; set; }

        IList<Title> Titles { get; set; }
    }
}