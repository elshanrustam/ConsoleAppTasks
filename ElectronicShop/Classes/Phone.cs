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
    internal class Phone : Electronic
    {
        public virtual int CameraMegaPixels { get; set; }

    }
}
