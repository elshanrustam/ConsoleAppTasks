using GenericsFinalTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFinalTask.Managers
{
    internal class GenericManager<T> : IGeneric<T> where T : IProduct, new()
    {
        protected readonly List<T> _list;
        public GenericManager(List<T> values)
        {
            _list = values;
        }
        public void Add(T product)
        {
            _list.Add(product);
        }

        public IEnumerable<T> GetAll()
        {
            return _list;
        }

        public void Remove(int index)
        {
            _list.RemoveAt(index);
        }

        public void Update(int id, T product)
        {
            foreach (T searchedList in _list)
            {
                if (searchedList.Id == id)
                {
                    searchedList.Name = product.Name;
                    searchedList.Price = product.Price;
                }
            }
        }
    }
}
