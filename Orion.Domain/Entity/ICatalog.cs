using Orion.Binding.Interfaces;
using System.Collections.Generic;

namespace Orion.Domain.Entity
{
    public interface ICatalog : IEntity, IPrice
    {
        string Model { get; set; }
        IList<Title> Titles { get; set; }
        string Company { get;}
        string Product { get; }
        string Index { get; }
    }
}
