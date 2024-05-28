using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.Classes
{
    internal class Electronic
    {
        public int Id { get; private set; }
        public string Model { get; set; }
        public string Marc { get; set; }
        public virtual double Price { get; set; }
        public virtual string OperatingSystem { get; set; }
    }
}
