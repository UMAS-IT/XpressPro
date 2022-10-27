using Orion.Binding.Binding;
using Orion.Binding.Interfaces;
using Orion.Domain.EntityAirCooledChiller;
using Orion.Domain.EntityAirCooledCondenser;
using Orion.Domain.EntityAirHandler;
using Orion.Domain.EntityPump;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Entity
{
    public class Unit: ValidatableBindableBase, IEntity
    {
        private int _id;
        public int Id
        {
            get => _id;
            set => SetProperty(ref _id, value);
        }

        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }

        private int _projectId;
        public int ProjectId
        {
            get => _projectId;
            set => SetProperty(ref _projectId, value);
        }

        private Project _project;
        public Project Project
        {
            get => _project;
            set => SetProperty(ref _project, value);
        }

        private IList<UnitItemAirCooledChiller> _unitItemAirCooledChillers;
        public IList<UnitItemAirCooledChiller> UnitItemAirCooledChillers
        {
            get => _unitItemAirCooledChillers;
            set => SetProperty(ref _unitItemAirCooledChillers, value);
        }

        private IList<UnitItemPump> _unitItemPumps;
        public IList<UnitItemPump> UnitItemPumps
        {
            get => _unitItemPumps;
            set => SetProperty(ref _unitItemPumps, value);
        }

        private IList<UnitItemAirHandler> _unitItemAirHandlers;
        public IList<UnitItemAirHandler> UnitItemAirHandlers
        {
            get => _unitItemAirHandlers;
            set => SetProperty(ref _unitItemAirHandlers, value);
        }

        public Unit()
        {
            UnitItemAirCooledChillers = new ObservableCollection<UnitItemAirCooledChiller>();
            UnitItemPumps = new ObservableCollection<UnitItemPump>();
            UnitItemAirHandlers = new ObservableCollection<UnitItemAirHandler>();
        }
    }
}
