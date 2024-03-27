using Orion.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain.Quantech.Related
{
    public class ItemA : Item
    {

        private string _tons;
        public string Tons
        {
            get => _tons;
            set => SetProperty(ref _tons, value);
        }

        public ItemA() :base() 
        {
            Tons = "";            
        }
    }
}
