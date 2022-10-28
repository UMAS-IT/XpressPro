using Orion.Binding.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.Entity
{
    public interface IItem : IEntity
    {
        string Name { get; set; }
        
        int DesignIndex { get; set; }

        [NotMapped]
        string DefaultItemName { get; }
    }
}

