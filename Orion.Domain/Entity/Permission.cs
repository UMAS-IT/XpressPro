using Orion.Binding.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Entity
{
    public class Permission : ValidatableBindableBase
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private bool _canEditCatalogs;
        public bool CanEditCatalogs
        {
            get => _canEditCatalogs;
            set => SetProperty(ref _canEditCatalogs, value);
        }

        private bool _generalAccess;
        public bool GeneralAccess
        {
            get => _generalAccess;
            set => SetProperty(ref _generalAccess, value);
        }

        private bool _isAdmin;
        public bool IsAdmin
        {
            get => _isAdmin;
            set => SetProperty(ref _isAdmin, value);
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
    }
}
