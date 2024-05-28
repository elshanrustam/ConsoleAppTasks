using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Interfaces
{
    internal interface IComputer : IElectronic
    {
        public void GetUsefullOrNot();
    }
}
