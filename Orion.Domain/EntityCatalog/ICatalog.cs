using Orion.Binding.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.EntityCatalog
{
    public interface ICatalog : IEntity
    {
        string Name { get; set; }
    }
}
