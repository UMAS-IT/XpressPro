using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Domain.Entity
{
    public class Spec : ValidatableBindableBase, IEntity, ICloneable
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

        private double _price;
        public double Price
        {
            get => _price;
            set => SetProperty(ref _price, value);
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

        private bool _saved;
        [NotMapped]
        public bool Saved
        {
            get => _saved;
            set => SetProperty(ref _saved, value);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public Spec()
        {
            Name = "Default Spec Name";
        }
    }
}
