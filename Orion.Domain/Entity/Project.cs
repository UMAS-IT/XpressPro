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

        private string _contractor;
        // To
        public string Contractor
        {
            get => _contractor;
            set => SetProperty(ref _contractor, value);
        }

        private string _contact;
        // Attention
        public string Contact
        {
            get => _contact;
            set => SetProperty(ref _contact, value);
        }

        private string _engineer;
        // Engineer
        public string Engineer
        {
            get => _engineer;
            set => SetProperty(ref _engineer, value);
        }

        private string _proposalNumber;
        public string ProposalNumber
        {
            get => _proposalNumber;
            set => SetProperty(ref _proposalNumber, value);
        }

        private string _Addendum;
        public string Addendum
        {
            get => _Addendum;
            set => SetProperty(ref _Addendum, value);
        }


        private string _location;
        //Not Used
        public string Location
        {
            get => _location;
            set => SetProperty(ref _location, value);
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

        private IList<Quote> _quotes;
        public IList<Quote> Quotes
        {
            get => _quotes;
            set => SetProperty(ref _quotes, value);
        }

        private DateTime _creationDate;
        public DateTime CreationDate
        {
            get => _creationDate;
            set => SetProperty(ref _creationDate, value);
        }

        private DateTime _plansDate;
        public DateTime PlansDate
        {
            get => _plansDate;
            set => SetProperty(ref _plansDate, value);
        }

        public Project()
        {
            Quotes = new ObservableCollection<Quote>();
            Notes = "";
            Contractor = "";
            Engineer = "";
            Contact = "";
            Location = "";
            ProposalNumber = "";
            Addendum = "";
            CreationDate = DateTime.Now;
            PlansDate = DateTime.Now;
        }
    }
}
