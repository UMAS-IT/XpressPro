using Orion.Binding.Interfaces;

namespace Orion.Domain.Entity
{
    public interface IItem : IEntity
    {
        string Name { get; set; }
    }
}

