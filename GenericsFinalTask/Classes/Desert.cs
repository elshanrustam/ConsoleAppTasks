using GenericsFinalTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFinalTask.Classes
{
    internal class Desert : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string? Indrigient { get; set; }
    }
}
