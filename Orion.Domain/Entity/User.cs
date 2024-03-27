﻿using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Orion.Domain.Entity
{
    public class User : ValidatableBindableBase, IEntity
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

        private string _loginName;
        public string LoginName
        {
            get => _loginName;
            set => SetProperty(ref _loginName, value);
        }

        private string _email;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        private string _telephone;
        public string Telephone
        {
            get => _telephone;
            set => SetProperty(ref _telephone, value);
        }

        private string _passKey;
        public string PassKey
        {
            get => _passKey;
            set => SetProperty(ref _passKey, value);
        }

        private IList<Project> _projects;
        public IList<Project> Projects
        {
            get => _projects;
            set => SetProperty(ref _projects, value);
        }

        private Permission _permission;
        public Permission Permission
        {
            get => _permission;
            set => SetProperty(ref _permission, value);
        }

        public User()
        {
            Projects = new ObservableCollection<Project>();
            Permission = new Permission();  
        }
    }
}
