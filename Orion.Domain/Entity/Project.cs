using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.Entity
{
    public class Project : ValidatableBindableBase , IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private int _number;
        public int Number
        {
            get => _number;
            set => SetProperty(ref _number, value);
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        private string _notes;
        public string Notes
        {
            get => _notes;
            set => SetProperty(ref _notes, value);
        }

        private int _userId;
        public int UserId
        {
            get => _userId;
            set => SetProperty(ref _userId, value);
        }

        private User _user;
        public User User
        {
            get => _user;
            set => SetProperty(ref _user, value);
        }

        private IList<Unit> _units;
        public IList<Unit> Units
        {
            get => _units;
            set => SetProperty(ref _units, value);
        }

        private DateTime _creationDate;
        public DateTime CreationDate
        {
            get => _creationDate;
            set => SetProperty(ref _creationDate, value);
        }

        public Project()
        {
            Units = new ObservableCollection<Unit>();
        }
    }
}
