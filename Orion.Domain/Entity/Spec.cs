using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Orion.Domain.Entity
{
    public class Spec : ValidatableBindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private int _titleId;
        public int TitleId
        {
            get => _titleId;
            set => SetProperty(ref _titleId, value);
        }

        private Title _title;
        public Title Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
        public Spec()
        {
            Name = "Default Spec Name";
        }
    }
}
