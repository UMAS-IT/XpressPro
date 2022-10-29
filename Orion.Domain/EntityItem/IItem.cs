using Orion.Binding.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.EntityItem
{
    public interface IItem : IEntity
    {
        string Name { get; set; }      
        [NotMapped]
        string DefaultItemName { get; }
        [NotMapped]
        bool HasItems { get; }
    }
}

