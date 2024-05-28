using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFinalTask.Interfaces
{
    internal interface IGeneric<T> where T : IProduct, new()
    {
        IEnumerable<T> GetAll();
        void Add(T product);
        void Remove(int index);
        void Update(int id,T product);

    }
}
