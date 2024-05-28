﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFinalTask.Interfaces
{
    internal interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
    }
}
