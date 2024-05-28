using ElectronicShop.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Classes
{
    internal class Computer : Electronic
    {
        public virtual string ProcessorType { get; set; }
        public virtual int Ram { get; set; }


    }
}
